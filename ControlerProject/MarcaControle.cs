using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Data.SqlClient;
using System.Data;

namespace ControlerProject
{
    public class MarcaControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertMarca(Marca marca)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into Marca (Descricao) values (@Descricao)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", marca.Descricao);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveMarca(int IDmarca)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from Marca where ID_Marca = @ID_Marca";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Marca", IDmarca);
                command.ExecuteNonQuery();
            }
        }
        public List<Marca> GetAllMarca()
        {
            List<Marca> marcas = new List<Marca>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_Marca, Descricao from Marca";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Marca marca = new Marca();
                        marca.ID_Marca = (int)reader["ID_Marca"];
                        marca.Descricao = (string)reader["Descricao"];
                        marcas.Add(marca);
                    }
                }
            }
            return marcas;
        }
        public void UpdateMarca(Marca marca)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update Marca set Descricao = @Descricao were ID_Marca = @ID_Marca";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", marca.Descricao);
                command.Parameters.AddWithValue("@ID_Marca", marca.ID_Marca);
                command.ExecuteNonQuery();
            }
        }
    }
}
