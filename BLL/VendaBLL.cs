using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data;
using System.Data;

namespace GVC.BLL
{
    internal class VendaBLL
    {
        private readonly VendaRepository _vendaRepository;
        private readonly ParcelaRepository _parcelaRepository;
        private readonly ItemVendaRepository _itemRepository;
        private readonly ProdutoRepository _produtoRepository;

        // ✅ CONSTRUTOR PADRÃO (NÃO QUEBRA O SISTEMA)
        public VendaBLL()
        {
            _vendaRepository = new VendaRepository();
            _parcelaRepository = new ParcelaRepository();
            _itemRepository = new ItemVendaRepository();
            _produtoRepository = new ProdutoRepository();
        }

        // ✅ OVERLOAD PARA USO EM TRANSAÇÕES/CONEXÃO EXTERNA (ERP)
        public VendaBLL(SqlConnection conn)
        {
            _vendaRepository = new VendaRepository(conn);
            _parcelaRepository = new ParcelaRepository(conn);
            _itemRepository = new ItemVendaRepository(); // (se quiser, dá pra criar overload também)
            _produtoRepository = new ProdutoRepository();
        }
        public void AtualizarStatusVenda(int vendaId, SqlConnection conn, SqlTransaction tran)
        { 
        }
       
        public EnumStatusVenda CalcularStatusVendaPorParcelas(IEnumerable<ParcelaModel> parcelas)
        {
            if (parcelas == null || !parcelas.Any())
                return EnumStatusVenda.Aberta;

            bool todasPagas = parcelas.All(p =>
                (p.ValorRecebido ?? 0) >=
                (p.ValorParcela + (p.Juros ?? 0) + (p.Multa ?? 0))
            );

            if (todasPagas)
                return EnumStatusVenda.Concluida;

            bool algumaPaga = parcelas.Any(p => (p.ValorRecebido ?? 0) > 0);

            if (algumaPaga)
                return EnumStatusVenda.Aberta;

            return EnumStatusVenda.AguardandoPagamento;
        }

        private void CalcularSubtotal(ItemVendaModel item)
        {
            var desconto = item.DescontoItem ?? 0m;
            item.Subtotal = (item.Quantidade * item.PrecoUnitario) - desconto;
        }

        public ClienteModel BuscarClienteVenda(int clienteId)
        {
            if (clienteId <= 0)
                return null;

            using var repo = new ClienteRepository();
            return repo.BuscarPorId(clienteId);
        }
       
        // =========================================
        // STATUS DA VENDA
        // =========================================
        public EnumStatusVenda CalcularStatusVenda(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return EnumStatusVenda.AguardandoPagamento;

            if (parcelas.All(p => p.Status == EnumStatusParcela.Pago))
                return EnumStatusVenda.Concluida;

            if (parcelas.Any(p => p.Status == EnumStatusParcela.ParcialmentePago))
                return EnumStatusVenda.Aberta;

            return EnumStatusVenda.AguardandoPagamento;
        }

        // =========================================
        // SALVAR VENDA COMPLETA
        // =========================================
        public int SalvarVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel>? parcelas = null)
         {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda));

            if (itens == null || !itens.Any())
                throw new Exception("Adicione pelo menos um item à venda.");

            // =========================
            // REGRAS COMERCIAIS
            // =========================
            venda.Desconto = Math.Max(0m, venda.Desconto ?? 0m);

            foreach (var item in itens)
            {
                if (item.Quantidade <= 0)
                    throw new Exception("Quantidade inválida.");

                if (item.PrecoUnitario < 0)
                    throw new Exception("Preço inválido.");

                item.DescontoItem = Math.Max(0m, item.DescontoItem ?? 0m);
                //item.AtualizarSubtotal();
                //item.Subtotal = (item.Quantidade * item.PrecoUnitario) - (item.DescontoItem ?? 0m);
                CalcularSubtotal(item);

            }

            venda.ValorTotal = Math.Max(0m, itens.Sum(i => i.Subtotal) - venda.Desconto.Value);

            // =========================
            // FINANCEIRO
            // =========================
            if (parcelas != null && parcelas.Any())
            {
                var financeiro = new FinanceiroService();
                financeiro.ProcessarFinanceiroVenda(venda, parcelas);
            }
         
            return _vendaRepository.AddVendaCompleta(venda, itens, parcelas);
        }
     
        public DadosExclusaoVenda ObterDadosParaExclusao(int vendaId)
        {
            using var repo = new VendaRepository();
            return repo.ObterDadosParaExclusao(vendaId);
        }
        public void ExcluirVendaCompleta(int vendaId)
        {
            using var repo = new VendaRepository();
            repo.Excluir(vendaId); // Seu método atual que já faz tudo
        }



        public bool ExistePagamento(int vendaId)
        {
            return new ParcelaRepository().ExistePagamentoPorVenda(vendaId);
        }     
        public void CancelarVenda(int vendaId, string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new Exception("Motivo do cancelamento é obrigatório.");

            _vendaRepository.CancelarVenda(vendaId, motivo);
        }
        public void AtualizarVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel> parcelas)
        {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda));

            if (itens == null || !itens.Any())
                throw new Exception("A venda deve possuir ao menos um item.");

            if (_parcelaRepository.ExistePagamentoPorVenda(venda.VendaID))
                throw new Exception(
                    "Não é possível alterar a venda.\n\nExistem pagamentos registrados.");

            _vendaRepository.AtualizarVendaCompleta(venda, itens, parcelas);
        }
       
        public VendaModel ObterVendaPorId(int vendaId)
        {
            return _vendaRepository.ObterPorId(vendaId);
        }

        public VendaModel ObterVendaCompleta(int vendaId)
        {
            return _vendaRepository.ObterVendaCompleta(vendaId);
        }

        public bool PodeAlterarVenda(int vendaId)
        {
            return !_parcelaRepository.ExistePagamentoPorVenda(vendaId);
        }
        public DataTable ListarVendasParaGrid(
        long? vendaId,
        string? clienteNome,
        DateTime dataInicio,
        DateTime dataFim)
        {
            return _vendaRepository.ListarVendasParaGrid(vendaId, clienteNome, dataInicio, dataFim);
        }
        public VendaVisualizacaoDTO ObterVendaParaVisualizacao(int vendaId)
        {
            using var repo = new VendaRepository();
            return repo.ObterVendaParaVisualizacao(vendaId);
        }
    }
}
