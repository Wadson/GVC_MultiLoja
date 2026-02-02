using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.BLL
{
    public class EmpresaBll
    {
        private readonly EmpresaDal _empresaDal = new EmpresaDal();

        public DadosEmpresaPdf ObterDadosParaPdf()
        {
            var empresa = _empresaDal.BuscarEmpresaPrincipal();

            if (empresa == null)
                throw new Exception("Empresa não cadastrada.");

            return new DadosEmpresaPdf
            {
                NomeEmpresa = string.IsNullOrWhiteSpace(empresa.NomeFantasia)
                    ? empresa.RazaoSocial
                    : empresa.NomeFantasia,

                Logo = empresa.Logo
            };
        }       
        public List<EmpresaModel> ObterTodas()
        {
            var lista = new List<EmpresaModel>();

            using var conn = Conexao_.Conex();
            using var cmd = new SqlCommand("SELECT EmpresaID FROM Empresa", conn);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var empresa = _empresaDal.BuscarPorId(reader.GetInt32(0));
                if (empresa != null)
                    lista.Add(empresa);
            }

            return lista;
        }
        public List<EmpresaModel> ListarEmpresas()
        {
            try
            {
                DataTable dt = _empresaDal.ListarEmpresas();
                return ConverterDataTableParaLista(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar empresas: " + ex.Message, ex);
            }
        }

        public EmpresaModel? BuscarPorId(int empresaId)
        {
            return _empresaDal.BuscarPorId(empresaId);
        }
        public EmpresaBll()
        {
            _empresaDal = new EmpresaDal();
        }

        public DataTable Listar()
        {
            try
            {
                return _empresaDal.ListarEmpresas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar Empresas: {ex.Message}", ex);
            }
        }


        public void Inserir(EmpresaModel empresa)
        {
            ValidarEmpresa(empresa, isUpdate: false);

            try
            {
                _empresaDal.SalvarEmpresa(empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir empresa: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Atualiza os dados de uma empresa existente
        /// </summary>
        public void Atualizar(EmpresaModel empresa)
        {
            ValidarEmpresa(empresa, isUpdate: true);

            if (empresa.EmpresaID <= 0)
                throw new ArgumentException("ID da empresa é obrigatório para atualização");

            try
            {
                _empresaDal.Atualizar(empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar empresa: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Exclui uma empresa do sistema
        /// </summary>
        public void Excluir(int empresaId)
        {
            if (empresaId <= 0)
                throw new ArgumentException("ID da empresa inválido para exclusão");

            try
            {
                // Aqui poderia ter verificações adicionais de negócio:
                // - Se a empresa tem movimentações financeiras
                // - Se está vinculada a outros cadastros importantes
                // - Se o usuário tem permissão, etc.

                _empresaDal.ExcluirEmpresa(empresaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir empresa: " + ex.Message, ex);
            }
        }


        public EmpresaModel ObterPorId(int id)
        {
            if (id <= 0)
                return null;

            var empresas = ObterTodas()
                .Where(e => e.EmpresaID == id)
                .ToList();

            return empresas.FirstOrDefault();
        }
              
        public bool ExisteEmpresa(string razaoSocial, string cnpj, int? ignorarEmpresaId = null)
        {
            if (string.IsNullOrWhiteSpace(razaoSocial) && string.IsNullOrWhiteSpace(cnpj))
                return false;

            var empresas = ObterTodas();

            return empresas.Any(e =>
                (ignorarEmpresaId == null || e.EmpresaID != ignorarEmpresaId) &&
                (
                    (!string.IsNullOrWhiteSpace(razaoSocial) && e.RazaoSocial?.Trim().ToUpper() == razaoSocial.Trim().ToUpper()) ||
                    (!string.IsNullOrWhiteSpace(cnpj) && LimparCnpj(e.CNPJ) == LimparCnpj(cnpj))
                ));
        }

     

        #region Validações de Negócio

        private void ValidarEmpresa(EmpresaModel empresa, bool isUpdate)
        {
            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));

            if (string.IsNullOrWhiteSpace(empresa.RazaoSocial))
                throw new ArgumentException("Razão Social é obrigatória");

            if (string.IsNullOrWhiteSpace(empresa.CNPJ))
                throw new ArgumentException("Cnpj é obrigatório");

            if (!ValidarCnpj(empresa.CNPJ))
                throw new ArgumentException("Cnpj inválido");

            // Verifica duplicidade
            if (ExisteEmpresa(empresa.RazaoSocial, empresa.CNPJ, isUpdate ? empresa.EmpresaID : null))
                throw new InvalidOperationException("Já existe uma empresa cadastrada com esta Razão Social ou Cnpj");

            // Outras validações que você pode adicionar:
            // - Uf válida
            // - CEP com formato correto
            // - Email válido (quando preenchido)
        }

        #endregion

        #region Helpers

        private static string LimparCnpj(string cnpj)
        {
            return string.IsNullOrWhiteSpace(cnpj) ? "" : new string(cnpj.Where(char.IsDigit).ToArray());
        }

        private static bool ValidarCnpj(string cnpj)
        {
            cnpj = LimparCnpj(cnpj);

            if (cnpj.Length != 14)
                return false;

            // Verifica se todos dígitos são iguais (11111111111111, etc)
            if (new string(cnpj[0], 14) == cnpj)
                return false;

            // Algoritmo de validação oficial do Cnpj
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private List<EmpresaModel> ConverterDataTableParaLista(DataTable dt)
        {
            var lista = new List<EmpresaModel>();

            foreach (DataRow row in dt.Rows)
            {
                var empresa = new EmpresaModel
                {
                    EmpresaID = Convert.ToInt32(row["EmpresaID"]),
                    RazaoSocial = row["RazaoSocial"]?.ToString(),
                    NomeFantasia = row["NomeFantasia"]?.ToString(),
                    CNPJ = row["CNPJ"]?.ToString(),
                    InscricaoEstadual = row["InscricaoEstadual"]?.ToString(),
                    InscricaoMunicipal = row["InscricaoMunicipal"]?.ToString(),
                    CNAE = row["CNAE"]?.ToString(),

                    Logradouro = row["Logradouro"]?.ToString(),
                    Numero = row["Numero"]?.ToString(),
                    Bairro = row["Bairro"]?.ToString(),
                    Cep = row["Cep"]?.ToString(),
                    Cidade = row["Cidade"]?.ToString(),
                    UF = row["UF"]?.ToString(),

                    Telefone = row["Telefone"]?.ToString(),
                    Email = row["Email"]?.ToString(),
                    Site = row["Site"]?.ToString(),

                    Responsavel = row["Responsavel"]?.ToString(),
                    CertificadoDigital = row["CertificadoDigital"]?.ToString(),
                    DataCriacao = row["DataCriacao"] != DBNull.Value ? Convert.ToDateTime(row["DataCriacao"]) : DateTime.MinValue,
                    DataAtualizacao = row["DataAtualizacao"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["DataAtualizacao"]) : null,
                    UsuarioCriacao = row["UsuarioCriacao"]?.ToString(),
                    UsuarioAtualizacao = row["UsuarioAtualizacao"]?.ToString(),
                };

                lista.Add(empresa);
            }

            return lista;
        }

        #endregion
    }
}