using Dapper;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ContasRepository
    {
        public List<ContasDto> ListarContas(ContasDto dto)
        {
            string connectionString = "Server=NOTE_MONSTER;Database=projeto86;User Id=dev;Password=dev;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"SELECT nome, email FROM contas ";
                IEnumerable<ContasDto> objetos = connection.Query<ContasDto>(sql);
                return objetos.ToList();
                // Faça algo com os objetos retornados...
            }
        }
    }
}
