using GVC.Model;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace GVC.Infra.Repository
{
    public class MarcaDal : RepositoryBase
    {
        public int ContarTotal()
        {
            const string sql = @" SELECT COUNT(*) FROM Marca WHERE EmpresaID = @EmpresaID";
            using var cmd = CreateCommand(sql);
            return (int)cmd.ExecuteScalar();
        }
        public void Inserir(MarcaModel marca)
        {
            const string sql = @"
                INSERT INTO Marca (NomeMarca, EmpresaID)
                VALUES (@NomeMarca, @EmpresaID)";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@NomeMarca", marca.NomeMarca);
            cmd.ExecuteNonQuery();
        }

        public void Atualizar(MarcaModel marca)
        {
            const string sql = @"
                UPDATE Marca
                   SET NomeMarca = @NomeMarca
                 WHERE MarcaID = @MarcaID
                   AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@MarcaID", marca.MarcaID);
            cmd.Parameters.AddWithValue("@NomeMarca", marca.NomeMarca);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int marcaId)
        {
            const string sql = @"
                DELETE FROM Marca
                 WHERE MarcaID = @MarcaID
                   AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@MarcaID", marcaId);
            cmd.ExecuteNonQuery();
        }

        public List<MarcaModel> Listar(string filtro = "")
        {
            var sql = @"
                SELECT MarcaID, NomeMarca
                  FROM Marca
                 WHERE EmpresaID = @EmpresaID";

            if (!string.IsNullOrWhiteSpace(filtro))
                sql += " AND NomeMarca LIKE @Filtro";

            sql += " ORDER BY NomeMarca";

            using var cmd = CreateCommand(sql);

            if (!string.IsNullOrWhiteSpace(filtro))
                cmd.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

            using var dr = cmd.ExecuteReader();
            var lista = new List<MarcaModel>();

            while (dr.Read())
            {
                lista.Add(new MarcaModel
                {
                    MarcaID = dr.GetInt32(0),
                    NomeMarca = dr.GetString(1)
                });
            }

            return lista;
        }

        public MarcaModel BuscarPorId(int marcaId)
        {
            const string sql = @"
                SELECT MarcaID, NomeMarca
                  FROM Marca
                 WHERE MarcaID = @MarcaID
                   AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@MarcaID", marcaId);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read())
                return null;

            return new MarcaModel
            {
                MarcaID = dr.GetInt32(0),
                NomeMarca = dr.GetString(1)
            };
        }
    }
}
