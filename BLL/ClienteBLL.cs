using GVC.DAL;
using GVC.Model;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class ClienteBLL
    {
        private readonly ClienteDal _dal = new ClienteDal();

        public DataTable Listar()
        {
            try
            {
                return _dal.ListarClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar clientes: {ex.Message}", ex);
            }
        }

        public void Salvar(ClienteModel cliente)
        {
            try
            {
                ValidarCliente(cliente, isNovo: true);

                var cpfLimpo = Utilitario.ApenasNumeros(cliente.Cpf);
                var cnpjLimpo = Utilitario.ApenasNumeros(cliente.Cnpj);

                cliente.Cpf = string.IsNullOrWhiteSpace(cpfLimpo) ? null : cpfLimpo;
                cliente.Cnpj = string.IsNullOrWhiteSpace(cnpjLimpo) ? null : cnpjLimpo;

                if (_dal.ClienteExiste(cliente.Nome, cliente.Cpf))
                    throw new Exception("Já existe um cliente cadastrado com este nome ou CPF.");

                if (_dal.BuscarPorCpf(cliente.Cpf) != null)
                    throw new Exception("Já existe um cliente cadastrado com este CPF.");

                if (_dal.BuscarPorCnpj(cliente.Cnpj) != null)
                    throw new Exception("Já existe um cliente cadastrado com este Cnpj.");

                cliente.DataCriacao = DateTime.Now;
                cliente.UsuarioCriacao = FrmLogin.UsuarioConectado;

                _dal.SalvarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar cliente: {ex.Message}", ex);
            }
        }

        public void Alterar(ClienteModel cliente)
        {
            try
            {
                if (cliente.ClienteID <= 0)
                    throw new Exception("Cliente inválido para alteração.");

                ValidarCliente(cliente, isNovo: false);

                var cpfLimpo = LimparCpf(cliente.Cpf);
                var existente = _dal.BuscarPorCpf(cpfLimpo);

                if (existente != null && existente.ClienteID != cliente.ClienteID)
                    throw new Exception("Outro cliente já está cadastrado com este CPF.");

                cliente.DataAtualizacao = DateTime.Now;

                _dal.Atualizar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar cliente: {ex.Message}", ex);
            }
        }

        public void Excluir(int clienteId)
        {
            try
            {
                if (clienteId <= 0) throw new Exception("ID do cliente inválido.");
                _dal.ExcluirCliente(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir cliente: {ex.Message}", ex);
            }
        }

        public void Excluir(ClienteModel cliente) => Excluir(cliente.ClienteID);

        public DataTable PesquisarPorNome(string nome)
        {
            try
            {
                return string.IsNullOrWhiteSpace(nome) ? Listar() : _dal.PesquisarPorNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa por nome: {ex.Message}", ex);
            }
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            try
            {
                return _dal.PesquisarPorCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa por código: {ex.Message}", ex);
            }
        }

        public DataTable PesquisarGeral(string texto)
        {
            try
            {
                return _dal.PesquisarGeral(texto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa geral: {ex.Message}", ex);
            }
        }

        public ClienteModel? BuscarPorCpf(string cpf)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cpf)) return null;

                cpf = LimparCpf(cpf);
                if (!Utilitario.ValidarCPF(cpf))
                    throw new Exception("CPF inválido.");

                return _dal.BuscarPorCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente por CPF: {ex.Message}", ex);
            }
        }

        public ClienteModel? BuscarPorId(int id)
        {
            try
            {
                if (id <= 0) return null;
                return _dal.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente por ID: {ex.Message}", ex);
            }
        }

        private void ValidarCliente(ClienteModel cliente, bool isNovo)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new Exception("Nome do cliente é obrigatório.");

            // Validação específica por tipo
            if (cliente.TipoCliente == "Jurídica")
            {
                // Pessoa Jurídica: valida Cnpj (apenas se preenchido)
                if (!string.IsNullOrEmpty(cliente.Cnpj))
                {
                    if (cliente.Cnpj.Length != 14)
                        throw new Exception("Cnpj deve conter 14 dígitos.");

                    if (!Utilitario.ValidarCNPJ(cliente.Cnpj))
                        throw new Exception("Cnpj inválido.");
                }

                // Para PJ, CPF deve ser NULL ou vazio
                if (!string.IsNullOrEmpty(cliente.Cpf))
                {
                    // Se tiver CPF, verifica se não é um CPF válido (pode ser digitado por engano)
                    if (cliente.Cpf.Length == 11 && Utilitario.ValidarCPF(cliente.Cpf))
                        throw new Exception("Para Pessoa Jurídica, não é permitido informar CPF.");
                }
            }
            else // Pessoa Física ou outros tipos que usam CPF
            {
                // Pessoa Física: valida CPF (apenas se preenchido)
                if (!string.IsNullOrEmpty(cliente.Cpf))
                {
                    if (cliente.Cpf.Length != 11)
                        throw new Exception("CPF deve conter 11 dígitos.");

                    if (!Utilitario.ValidarCPF(cliente.Cpf))
                        throw new Exception("CPF inválido.");
                }

                // Para PF, Cnpj deve ser NULL ou vazio
                if (!string.IsNullOrEmpty(cliente.Cnpj))
                {
                    // Se tiver Cnpj, verifica se não é um Cnpj válido (pode ser digitado por engano)
                    if (cliente.Cnpj.Length == 14 && Utilitario.ValidarCNPJ(cliente.Cnpj))
                        throw new Exception("Para Pessoa Física, não é permitido informar Cnpj.");
                }
            }

            // Validação de e-mail (se preenchido)
            if (!string.IsNullOrWhiteSpace(cliente.Email) && !IsValidEmail(cliente.Email))
                throw new Exception("E-mail inválido.");

            // Validação de telefone (se preenchido)
            if (!string.IsNullOrWhiteSpace(cliente.Telefone))
            {
                if (cliente.Telefone.Length < 10 || cliente.Telefone.Length > 11)
                    throw new Exception("Telefone deve conter 10 ou 11 dígitos.");
            }

            // Validação de CEP (se preenchido)
            if (!string.IsNullOrWhiteSpace(cliente.Cep))
            {
                if (cliente.Cep.Length != 8)
                    throw new Exception("CEP deve conter 8 dígitos.");
            }
        }

        private static string LimparCpf(string cpf) => Regex.Replace(cpf ?? "", @"\D", "");
        private static string LimparCnpj(string cnpj) => Regex.Replace(cnpj ?? "", @"\D", "");
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
