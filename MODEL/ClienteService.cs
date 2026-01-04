using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ClienteService
    {
        private readonly string _connectionString;

        public ClienteService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método SIMPLES para buscar clientes
        public async Task<List<ClienteDisplayDTO>> BuscarClientesAsync(string busca)
        {
            var lista = new List<ClienteDisplayDTO>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    string sql = @"
                        SELECT TOP 20 
                            ClienteID, 
                            Nome,
                            ISNULL(CPF, '') as CPF,
                            ISNULL(Cnpj, '') as Cnpj
                        FROM Clientes 
                        WHERE Ativo = 1 
                          AND (Nome LIKE @Busca OR 
                               CPF LIKE @Busca OR 
                               Cnpj LIKE @Busca)
                        ORDER BY Nome";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Busca", $"%{busca}%");

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                string cpf = reader.GetString(2);
                                string cnpj = reader.GetString(3);

                                // Decide qual documento mostrar
                                string documento = !string.IsNullOrEmpty(cpf) ?
                                    FormatCPF(cpf) :
                                    !string.IsNullOrEmpty(cnpj) ?
                                    FormatCNPJ(cnpj) : "";

                                lista.Add(new ClienteDisplayDTO(id, nome, documento));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Em produção, logaria o erro
                Console.WriteLine($"Erro ao buscar clientes: {ex.Message}");
            }

            return lista;
        }

        private string FormatCPF(string cpf)
        {
            if (cpf.Length == 11)
                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            return cpf;
        }

        private string FormatCNPJ(string cnpj)
        {
            if (cnpj.Length == 14)
                return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
            return cnpj;
        }

        // Método para obter cliente por ID
        public async Task<ClienteDisplayDTO> ObterClientePorIdAsync(int clienteId)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    string sql = "SELECT ClienteID, Nome, CPF, Cnpj FROM Clientes WHERE ClienteID = @Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", clienteId);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string nome = reader.GetString(1);
                                string cpf = reader.GetString(2);
                                string cnpj = reader.GetString(3);

                                string documento = !string.IsNullOrEmpty(cpf) ?
                                    FormatCPF(cpf) :
                                    !string.IsNullOrEmpty(cnpj) ?
                                    FormatCNPJ(cnpj) : "";

                                return new ClienteDisplayDTO(clienteId, nome, documento);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter cliente: {ex.Message}");
            }

            return null;
        }
    }
}
