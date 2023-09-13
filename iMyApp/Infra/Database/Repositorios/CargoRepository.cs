using Database.Conexoes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public object Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StrConexaoHardCode();
            var sqlConnection = new SqlConnection(stringConexao);

            sqlConnection.Open();

            var sql = @"INSERT INTO [dbo].[Cargo]
                       ([Nome]
                       ,[Status]
                       ,[CriadoEm]
                       ,[CriadoPor]
                       ,[AlteradoEm]
                       ,[AlteradoPor])
                 VALUES
                       (@Nome, 
                       @status, 
                       @criadoEm, 
                       @criadoPor,
                       @alteradoEm,
                       @alteradoPor,)";

            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome", cargo.Nome);
            cmd.Parameters.AddWithValue("@status", cargo.Status);
            cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
            cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);

            sqlConnection.Close();
       
        }
    }
}
