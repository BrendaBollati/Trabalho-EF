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
    public class ProdutoSimilarControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertProdutoSimilar(ProdutoSimilar produtoSimilar)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into ProdutoSimilar (ID_Produto, ID_produto_similar) values (@ID_Produto, @ID_produto_similar)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Produto", produtoSimilar.ID_Produto);
                command.Parameters.AddWithValue("@ID_produto_similar", produtoSimilar.ID_produto_similar);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveProdutoSimilar(int IDprodutoSimilar)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from ProdutoSimilar where ID_Produto = @ID_Produto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Produto", IDprodutoSimilar);
                command.ExecuteNonQuery();
            }
        }
        public List<ProdutoSimilar> GetAllProdutoSimilar()
        {
            List<ProdutoSimilar> produtoSimilares = new List<ProdutoSimilar>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_Produto, ID_produto_similar from ProdutoSimilar";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {

                    while (reader.Read())
                    {
                        ProdutoSimilar produtoSimilar = new ProdutoSimilar();
                        produtoSimilar.ID_Produto = (int)reader["ID_Produto"];
                        produtoSimilar.ID_produto_similar = (int)reader["ID_produto_similar"];
                        produtoSimilares.Add(produtoSimilar);
                    }
                }
            }
            return produtoSimilares;
        }
        public void UpdateProdutoSimilar(ProdutoSimilar produtoSimilar)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update ProdutoSimilar set ID_produto_similar = @ID_produto_similar" +
                    " were ID_Produto = @ID_Produto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_produto_similar", produtoSimilar.ID_produto_similar);
                command.Parameters.AddWithValue("@ID_Produto", produtoSimilar.ID_Produto);
                command.ExecuteNonQuery();
            }
        }
    }
}
