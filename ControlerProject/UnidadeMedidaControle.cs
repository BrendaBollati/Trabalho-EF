using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Classes;
using System.Data;

namespace ControlerProject
{
    public class UnidadeMedidaControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into UnidadeMedida (Descricao, ID_produto)" +
                    " values (@Descricao, @ID_produto)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", unidadeMedida.Descricao);
                command.Parameters.AddWithValue("@ID_produto", unidadeMedida.ID_produto);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveUnidadeMedida(int IDunidadeMedida)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from UnidadeMedida where ID_UnidadeMedida = @ID_UnidadeMedida";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_UnidadeMedida", IDunidadeMedida);
                command.ExecuteNonQuery();
            }
        }
        public List<UnidadeMedida> GetAllUnidadeMedida()
        {
            List<UnidadeMedida> unidadeMedidas = new List<UnidadeMedida>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_UnidadeMedida, Descricao, ID_produto from UnidadeMedida";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        UnidadeMedida unidadeMedida = new UnidadeMedida();
                        unidadeMedida.ID_UnidadeMedida = (int)reader["ID_UnidadeMedida"];
                        unidadeMedida.Descricao = (string)reader["Descricao"];
                        unidadeMedida.ID_produto = (int)reader["ID_produto"];
                        unidadeMedidas.Add(unidadeMedida);
                    }
                }
            }
            return unidadeMedidas;
        }
        public void UpdateUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update UnidadeMedida set Descricao = @Descricao, " +
                    "ID_produto = @ID_produto were ID_UnidadeMedida = @ID_UnidadeMedida";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", unidadeMedida.Descricao);
                command.Parameters.AddWithValue("@ID_produto", unidadeMedida.ID_produto);
                command.Parameters.AddWithValue("@ID_UnidadeMedida", unidadeMedida.ID_UnidadeMedida);
                command.ExecuteNonQuery();
            }
        }
    }
}
