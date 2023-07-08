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
    public class CategoriaControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into Categoria (Descricao, ID_departamento) " +
                    "values (@Descricao, @ID_departamento)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
                command.Parameters.AddWithValue("@ID_departamento", categoria.ID_departamento);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveCategoria(int IDcategoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from Categoria where ID_Categoria = @ID_Categoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Categoria", IDcategoria);
                command.ExecuteNonQuery();
            }
        }
        public List<Categoria> GetAllCategoria()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_Categoria, Descricao, ID_departamento from Categoria";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.ID_Categoria = (int)reader["ID_Categoria"];
                        categoria.Descricao = (string)reader["Descricao"];
                        categoria.ID_departamento = (int)reader["ID_departamento"];
                        categorias.Add(categoria);
                    }
                }

            }
            return categorias;
        }
        public void UpdateCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update Categoria set Descricao = @Descricao, " +
                    "ID_departamento = @ID_departamento were ID_Categoria = @ID_Categoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
                command.Parameters.AddWithValue("@ID_departamento", categoria.ID_departamento);
                command.Parameters.AddWithValue("@ID_Categoria", categoria.ID_Categoria);
                command.ExecuteNonQuery();
            }
        }
    }
}
