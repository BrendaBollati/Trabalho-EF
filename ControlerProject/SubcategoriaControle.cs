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
    public class SubcategoriaControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertCategoria(Subcategoria subcategoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into Subcategoria (Descricao, ID_categoria) " +
                    "values (@Descricao, @ID_categoria)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", subcategoria.Descricao);
                command.Parameters.AddWithValue("@ID_categoria", subcategoria.ID_categoria);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveSubcategoria(int IDsubcategoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from Subcategoria where ID_Subcategoria = @ID_Subcategoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Subcategoria", IDsubcategoria);
                command.ExecuteNonQuery();
            }
        }
        public List<Subcategoria> GetAllSubcategoria()
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_Subcategoria, Descricao, ID_categoria from Subcategoria";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Subcategoria subcategoria = new Subcategoria();
                        subcategoria.ID_Subcategoria = (int)reader["ID_Subcategoria"];
                        subcategoria.Descricao = (string)reader["Descricao"];
                        subcategoria.ID_categoria = (int)reader["ID_categoria"];
                        subcategorias.Add(subcategoria);
                    }
                }
            }
            return subcategorias;
        }
        public void UpdateSubcategoria(Subcategoria subcategoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update Subcategoria set Descricao = @Descricao, " +
                    "ID_categoria = @ID_categoria were ID_Subcategoria = @ID_Subcategoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", subcategoria.Descricao);
                command.Parameters.AddWithValue("@ID_categoria", subcategoria.ID_categoria);
                command.Parameters.AddWithValue("@ID_Subcategoria", subcategoria.ID_Subcategoria);
                command.ExecuteNonQuery();
            }
        }
    }
}
