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
    public class ProdutoControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into PrecoVenda (Codigo, Descricao, Id_subcategoria, ID_marca, " +
                    "Id_unidade_medida, EspecificacaoTecnica, Statous, PesoBruto, PesoLiquido, Qtd_Mult, " +
                    "Qtd_Min, Cod_Barras) values (@Codigo, @Descricao, @Id_subcategoria, @ID_marca, " +
                    "@Id_unidade_medida, ,@EspecificacaoTecnica, @Statous, @PesoBruto, @PesoLiquido, " +
                    "@Qtd_Mult, @Qtd_Min, @Cod_Barras)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", produto.Codigo);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.Parameters.AddWithValue("@Id_subcategoria", produto.Id_subcategoria);
                command.Parameters.AddWithValue("@Id_unidade_medida", produto.Id_unidade_medida);
                command.Parameters.AddWithValue("@EspecificacaoTecnica", produto.EspecificacaoTecnica);
                command.Parameters.AddWithValue("@Statous", produto.Statous);
                command.Parameters.AddWithValue("@PesoBruto", produto.PesoBruto);
                command.Parameters.AddWithValue("@PesoLiquido", produto.PesoLiquido);
                command.Parameters.AddWithValue("@Qtd_Mult", produto.Qtd_Mult);
                command.Parameters.AddWithValue("@Qtd_Min", produto.Qtd_Min);
                command.Parameters.AddWithValue("@Cod_Barras", produto.Cod_Barras);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveProduto(int IDProduto)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from Produto where ID_Produto = @ID_Produto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Produto", IDProduto);
                command.ExecuteNonQuery();
            }
        }
        public List<Produto> GetAllProduto()
        {
            List<Produto> produtos = new List<Produto>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_Produto, Codigo, Descricao, Id_subcategoria, from Produto";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.ID_Produto = (int)reader["ID_Produto"];
                        produto.Codigo = (int)reader["Codigo"];
                        produto.Descricao = (string)reader["Descricao"];
                        produto.Id_subcategoria = (int)reader["Id_subcategoria"];
                        produto.Id_unidade_medida = (int)reader["Id_unidade_medida"];
                        produto.EspecificacaoTecnica = (string)reader["EspecificacaoTecnica"];
                        produto.Statous = (string)reader["Statous"];
                        produto.PesoBruto = (float)reader["PesoBruto"];
                        produto.PesoLiquido = (float)reader["PesoLiquido"];
                        produto.Qtd_Mult = (int)reader["Qtd_Mult"];
                        produto.Qtd_Min = (int)reader["Qtd_Min"];
                        produto.Cod_Barras = (int)reader["Cod_Barras"];
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }
        public void UpdateProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update Produto set Codigo = @Codigo, Descricao = @Descricao, " +
                    "Id_subcategoria = @Id_subcategoria, Id_unidade_medida = @Id_unidade_medida, " +
                    "EspecificacaoTecnica = @EspecificacaoTecnica, Statous = @Statous, PesoBruto = @PesoBruto, " +
                    "PesoLiquido = @PesoLiquido, Qtd_Mult = @Qtd_Mult, Qtd_Min = @Qtd_Min, " +
                    "Cod_Barras = @Cod_Barras were ID_Produto = @ID_Produto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", produto.Codigo);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.Parameters.AddWithValue("@Id_subcategoria", produto.Id_subcategoria);
                command.Parameters.AddWithValue("@Id_unidade_medida", produto.Id_unidade_medida);
                command.Parameters.AddWithValue("@EspecificacaoTecnica", produto.EspecificacaoTecnica);
                command.Parameters.AddWithValue("@Statous", produto.Statous);
                command.Parameters.AddWithValue("@PesoBruto", produto.PesoBruto);
                command.Parameters.AddWithValue("@PesoLiquido", produto.PesoLiquido);
                command.Parameters.AddWithValue("@Qtd_Mult", produto.Qtd_Mult);
                command.Parameters.AddWithValue("@Qtd_Min", produto.Qtd_Min);
                command.Parameters.AddWithValue("@Cod_Barras", produto.Cod_Barras);
                command.Parameters.AddWithValue("@ID_Produto", produto.ID_Produto);
                command.ExecuteNonQuery();
            }
        }
    }
}
