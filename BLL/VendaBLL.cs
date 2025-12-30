using GVC.DAL;
using GVC.DALL;
using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GVC.View.FrmVendas;

namespace GVC.BLL
{
    internal class VendaBLL
    {
        private readonly VendaDal vendaDAL;
        // ✅ CONSTRUTOR OBRIGATÓRIO
        public VendaBLL()
        {
            vendaDAL = new VendaDal();
        }       
        //🔹 Passo B — Criar método de cálculo na VendaBLL
        public string CalcularStatusVendaPorParcelas(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return EnumStatusVenda.Aberta.ToDb();

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVenda.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVenda.Concluida.ToDb();

            return EnumStatusVenda.ParcialmentePago.ToDb();
        }      
        public int SalvarVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel>? parcelas = null)
        {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda));

            if (itens == null || !itens.Any())
                throw new Exception("Adicione pelo menos um item à venda.");

            // ====================
            // REGRAS DE NEGÓCIO - TRATAMENTO SEGURO
            // ====================

            // Desconto da venda: se for nullable (decimal?), trata como 0
            decimal descontoVenda = venda.Desconto ?? 0m;
            if (descontoVenda < 0m) descontoVenda = 0m;

            // ====================
            // ITENS - TRATAMENTO DIFERENCIADO POR CAMPO
            // ====================
            foreach (var item in itens)
            {
                // PrecoUnitario é decimal (não nullable) → já tem valor
                decimal preco = item.PrecoUnitario;

                // DescontoItem é decimal? → usa ?? 0m
                decimal descontoItem = (decimal)item.DescontoItem;
                if (descontoItem < 0m) descontoItem = 0m;

                // Subtotal é decimal? → recalcula sempre com segurança
                decimal subtotalCalculado = (item.Quantidade * preco) - descontoItem;
                if (subtotalCalculado < 0m) subtotalCalculado = 0m;

                // Atualiza os campos
                item.DescontoItem = descontoItem;
                item.Subtotal = subtotalCalculado;
            }

            // ====================
            // TOTAL DOS ITENS
            // ====================
            decimal totalDosItens = (decimal)itens.Sum(i => i.Subtotal);

            // Valor esperado = total itens - desconto venda
            decimal valorEsperado = Math.Max(0m, totalDosItens - descontoVenda);

            // Se ValorTotal da venda for inconsistente, corrige
            if (Math.Abs((venda.ValorTotal) - valorEsperado) > 0.01m)
            {
                venda.ValorTotal = valorEsperado;
            }

            // Atualiza o desconto da venda
            venda.Desconto = descontoVenda;

            // ====================
            // PARCELAS
            // ====================
            if (parcelas != null && parcelas.Any())
            {
                decimal totalParcelas = 0m;

                foreach (var p in parcelas)
                {
                    p.ValorParcela = Math.Max(0m, p.ValorParcela);
                    p.ValorRecebido = Math.Max(0m, p.ValorRecebido);
                    p.Juros        = Math.Max(0m, p.Juros);
                    p.Multa        = Math.Max(0m, p.Multa);

                    totalParcelas += p.ValorParcela + p.Juros + p.Multa;

                    if (p.Status == "Paga" || p.Status == EnumStatusParcela.Paga.ToDb())
                    {
                        if (p.DataPagamento == null)
                            p.DataPagamento = DateTime.Now;
                    }
                }

                if (Math.Abs(totalParcelas - (venda.ValorTotal)) > 0.01m)
                {
                    throw new Exception($"Total parcelas (R$ {totalParcelas:N2}) não bate com valor da venda (R$ {venda.ValorTotal:N2}).");
                }
            }
           
            // ====================
            // SALVA
            // ====================
            return vendaDAL.AddVendaCompleta(venda, itens, parcelas);
        }
        public void ExcluirVenda(int vendaID)
        {
            if (ExistePagamento(vendaID))
                throw new Exception("Não é possível excluir venda com pagamentos.");

            new PagamentoParcialDal().ExcluirPorVenda(vendaID);
            new ParcelaDal().ExcluirPorVenda(vendaID);
            new ItemVendaDal().ExcluirPorVenda(vendaID);
            new VendaDal().Excluir(vendaID);
        }
        public bool ExistePagamento(long vendaId)
        {
            return new ParcelaDal().ExistePagamentoPorVenda(vendaId);
        }

        public void Alterar(VendaModel venda)
        {
            vendaDAL.UpdateVenda(venda);
        }

       
        // ⚠️ SE PRECISAR MANTER int
        public VendaModel ObterVendaPorId(int vendaId)
        {
            return vendaDAL.ObterVendaPorId(vendaId);
        }

        public string CalcularStatusVenda(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return EnumStatusVenda.Aberta.ToDb();

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVenda.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVenda.Concluida.ToDb();

            return EnumStatusVenda.ParcialmentePago.ToDb();
        }
        public void CancelarVenda(long vendaId, string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new Exception("Motivo do cancelamento é obrigatório.");

            var vendaDal = new VendaDal();
            var itemDal = new ItemVendaDal();
            var produtoDal = new ProdutoDALL();
            var parcelaDal = new ParcelaDal();
            var parcelaBll = new ParcelaBLL();

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                // ============================
                // 1️⃣ ESTORNAR PAGAMENTOS
                // ============================
                var parcelas = parcelaDal.GetParcelas((int)vendaId);

                foreach (var p in parcelas)
                {
                    if (p.ValorRecebido > 0)
                    {
                        parcelaBll.EstornarPagamento(
                            p.ParcelaID,
                            p.ValorRecebido,
                            motivo
                        );
                    }
                }

                // ============================
                // 2️⃣ CANCELAR PARCELAS
                // ============================
                parcelaDal.CancelarParcelasPorVenda(vendaId);

                // ============================
                // 3️⃣ DEVOLVER ESTOQUE
                // ============================
                var itens = itemDal.ListarItensPorVenda(vendaId);

                foreach (var item in itens)
                {
                    var produto = produtoDal.BuscarPorId(item.ProdutoID);

                    if (produto == null)
                        throw new Exception($"Produto ID {item.ProdutoID} não encontrado.");

                    produto.Estoque += item.Quantidade;
                    produtoDal.Alterar(produto);
                }

                // ============================
                // 4️⃣ CANCELAR VENDA + MOTIVO
                // ============================
                vendaDal.AtualizarStatusVenda(vendaId,  EnumStatusVenda.Cancelada.ToDb(), motivo );

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }



        public bool PodeAlterarVenda(int vendaID)
        {
            return !ExistePagamento(vendaID);
        }       
        public void ExcluirVendaFisicamente(long vendaId)
        {
            var parcelaDal = new ParcelaDal();

            if (parcelaDal.ExistePagamentoPorVenda(vendaId))
                throw new Exception( "EXCLUSÃO BLOQUEADA!\n\n" +
                    "Esta venda possui pagamentos registrados.\n" +
                    "Remova os pagamentos antes de tentar excluir.");

            new PagamentoParcialDal().ExcluirPorVenda(vendaId);
            new ParcelaDal().ExcluirPorVenda(vendaId);
            new ItemVendaDal().ExcluirPorVenda(vendaId);
            new VendaDal().Excluir(vendaId);
        }
        //Abaixo métodos para atualizar venda, 
        public bool VendaPossuiPagamento(long vendaId)
        {
            using var conn = Conexao.Conex();
            conn.Open();

            string sql = @" SELECT COUNT(*)
        FROM PagamentosParciais pp
        INNER JOIN Parcela p ON p.ParcelaID = pp.ParcelaID
        WHERE p.VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            return (int)cmd.ExecuteScalar() > 0;
        }
       
        public VendaCompletaModel ObterVendaCompleta(long vendaId)
        {
            return new VendaConsultaDal().ObterVendaCompleta(vendaId);
        }

        public void AtualizarVendaCompleta( VendaModel venda, List<ItemVendaModel> itens,  List<ParcelaModel> parcelas)
        {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda));

            if (itens == null || !itens.Any())
                throw new Exception("A venda deve possuir ao menos um item.");

            if (ExistePagamento(venda.VendaID))
                throw new Exception(
                    "Não é possível alterar a venda.\n\n" +
                    "Existem pagamentos registrados.");

            // 🔹 Recalcula status da venda
            venda.StatusVenda = CalcularStatusVenda(parcelas);

            // 🔹 Chama DAL (igual salvar)
            new VendaAtualizacaoDal()
                .AtualizarVendaCompleta(venda, itens, parcelas);
        }
    }
}
