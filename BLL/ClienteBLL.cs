using GVC.DAL;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace GVC.BLL
{
    internal class ClienteBLL
    {
        private readonly ClienteRepository clienteRepository = new ClienteRepository();


        public ClienteBLL()
        {
            clienteRepository = new ClienteRepository();
        }
        public DataTable Listar()
        {
            using var repo = new ClienteRepository();
            return repo.ListarClientes();
        }
        public DataTable ListarVendedores()
        {
            using var repo = new ClienteRepository();
            return repo.ListarClientes();
        }

        public void Salvar(ClienteModel cliente)
        {
            try
            {
                // Validação inicial
                ValidarCliente(cliente, isNovo: true);

                // Normalização dos documentos
                cliente.Cpf = LimparCpf(cliente.Cpf);
                cliente.Cnpj = LimparCnpj(cliente.Cnpj);

                // Metadados de criação
                cliente.DataCriacao = DateTime.Now;
                cliente.UsuarioCriacao = FrmLogin.UsuarioConectado;
                cliente.EmpresaID = Sessao.EmpresaID;

                // 🔒 Garantia absoluta: não permitir atualização no momento da criação
                cliente.DataAtualizacao = null;
                cliente.UsuarioAtualizacao = null;

                using var repo = new ClienteRepository();

                // Verificação de duplicidade
                if (repo.ClienteExiste(cliente.Nome, cliente.Cpf))
                    throw new Exception("Já existe um cliente cadastrado com este nome ou CPF.");

                // Persistência
                cliente.ClienteID = repo.Salvar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar cliente: {ex.Message}", ex);
            }
        }

        public DataTable PesquisarPorNome(string nome)
        {

            return clienteRepository.PesquisarPorNome(nome);
        }
        public DataTable PesquisarVendedor(string nome)
        {
            return clienteRepository.PesquisarVendedores(nome);
        }
        // =========================
        // ALTERAR
        // =========================
        public void Alterar(ClienteModel cliente)
        {
            if (cliente.ClienteID <= 0)
                throw new Exception("Cliente inválido para alteração.");

            ValidarCliente(cliente, isNovo: false);

            // Normalização dos documentos
            cliente.Cpf = LimparCpf(cliente.Cpf);
            cliente.Cnpj = LimparCnpj(cliente.Cnpj);

            // 🔒 NÃO TOCA EM CRIAÇÃO
            cliente.DataCriacao = default;
            cliente.UsuarioCriacao = null;

            // 🔴 SOMENTE UPDATE
            cliente.DataAtualizacao = DateTime.Now;
            cliente.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
            cliente.EmpresaID = Sessao.EmpresaID;

            using var repo = new ClienteRepository();

            // Verificação de existência
            var existente = repo.BuscarPorId(cliente.ClienteID);
            if (existente == null)
                throw new Exception("Cliente não encontrado.");

            // Persistência
            repo.Atualizar(cliente);
        }

        public void Excluir(int clienteId)
        {
            if (clienteId <= 0)
                throw new Exception("ID do cliente inválido.");

            using var repo = new ClienteRepository();
            repo.Excluir(clienteId);
        }

        public ClienteModel? BuscarPorId(int id)
        {
            try
            {
                if (id <= 0) return null;
                using var repo = new ClienteRepository();
                return repo.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente por ID: {ex.Message}", ex);
            }
        }

        // =========================
        // VALIDAÇÃO
        // =========================
        private void ValidarCliente(ClienteModel cliente, bool isNovo)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new Exception("Nome do cliente é obrigatório.");

            if (cliente.TipoCliente == "Jurídica")
            {
                if (!string.IsNullOrEmpty(cliente.Cnpj))
                {
                    if (cliente.Cnpj.Length != 14)
                        throw new Exception("Cnpj deve conter 14 dígitos.");

                    if (!Utilitario.ValidarCNPJ(cliente.Cnpj))
                        throw new Exception("Cnpj inválido.");
                }

                if (!string.IsNullOrEmpty(cliente.Cpf) &&
                    cliente.Cpf.Length == 11 &&
                    Utilitario.ValidarCPF(cliente.Cpf))
                    throw new Exception("Para Pessoa Jurídica, não é permitido informar CPF.");
            }
            else
            {
                if (!string.IsNullOrEmpty(cliente.Cpf))
                {
                    if (cliente.Cpf.Length != 11)
                        throw new Exception("CPF deve conter 11 dígitos.");

                    if (!Utilitario.ValidarCPF(cliente.Cpf))
                        throw new Exception("CPF inválido.");
                }

                if (!string.IsNullOrEmpty(cliente.Cnpj) &&
                    cliente.Cnpj.Length == 14 &&
                    Utilitario.ValidarCNPJ(cliente.Cnpj))
                    throw new Exception("Para Pessoa Física, não é permitido informar Cnpj.");
            }

            if (!string.IsNullOrWhiteSpace(cliente.Email) && !IsValidEmail(cliente.Email))
                throw new Exception("E-mail inválido.");

            if (!string.IsNullOrWhiteSpace(cliente.Telefone) &&
                (cliente.Telefone.Length < 10 || cliente.Telefone.Length > 11))
                throw new Exception("Telefone deve conter 10 ou 11 dígitos.");

            if (!string.IsNullOrWhiteSpace(cliente.Cep) && cliente.Cep.Length != 8)
                throw new Exception("CEP deve conter 8 dígitos.");
        }

        // =========================
        // AUXILIARES
        // =========================
        private static string LimparCpf(string? cpf) =>
            string.IsNullOrWhiteSpace(cpf) ? null : Regex.Replace(cpf, @"\D", "");

        private static string LimparCnpj(string? cnpj) =>
            string.IsNullOrWhiteSpace(cnpj) ? null : Regex.Replace(cnpj, @"\D", "");

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
