using Database.Conexoes;
using Negocio.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {
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
                using (var conncection = new SqlConnection(SqlServer.StrConexaoHardCode()))
                {
                   conncection.Open();
                    var cmd = new SqlCommand(sql, conncection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    conncection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;


            }

            

         

            

        }
        public bool Atualizar(Cargo cargo)
        {
            try
            {
                var sql = @"";

                using (var conncection = new SqlConnection(SqlServer.StrConexaoHardCode()))
                {
                    var cmd = new SqlCommand(sql, conncection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;


            }
        }
        public bool Deletar(int cargoId)
        {
            try
            {
                var sql = @"";

                using (var conncection = new SqlConnection(SqlServer.StrConexaoHardCode()))
                {
                    var cmd = new SqlCommand(sql, conncection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;


            }
        }
        public DataTable ObterTodos(int cargoId)
        {
            var sql = @"";

            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();
            try
            {
                using (var conncection = new SqlConnection(SqlServer.StrConexaoHardCode()))
                {
                    var cmd = conncection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, conncection);
                    dataAdapter.Fill(dataTable);
                    return dataTable;


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           


        }
    }  
}
