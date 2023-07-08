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
    public class PrecoVendaControle
    {
        private string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=[TrabalhoEFBanco];User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertPrecoVenda(PrecoVenda precoVenda)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into PrecoVenda (ID_produto, preco_venda, data_validade_inicial, " +
                    "data_validade_final) values (@ID_produto, @preco_venda, @data_validade_inicial, " +
                    "@data_validade_final)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_produto", precoVenda.ID_produto);
                command.Parameters.AddWithValue("@preco_venda", precoVenda.preco_venda);
                command.Parameters.AddWithValue("@data_validade_inicial", precoVenda.data_validade_inicial);
                command.Parameters.AddWithValue("@data_validade_final", precoVenda.data_validade_final);
                command.ExecuteNonQuery();
            }
        }
        public void RemovePrecoVenda(int IDPrecoVenda)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from PrecoVenda where ID_PrecoVenda = @ID_PrecoVenda";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_PrecoVenda", IDPrecoVenda);
                command.ExecuteNonQuery();
            }
        }
        public List<PrecoVenda> GetAllPrecoVenda()
        {
            List<PrecoVenda> precoVendas = new List<PrecoVenda>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string query = "select ID_PrecoVenda, ID_produto, preco_venda, " +
                    "data_validade_inicial, data_validade_final  from PrecoVenda";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        PrecoVenda precoVenda = new PrecoVenda();
                        precoVenda.ID_PrecoVenda = (int)reader["ID_PrecoVenda"];
                        precoVenda.ID_produto = (int)reader["ID_produto"];
                        precoVenda.preco_venda = (float)reader["preco_venda"];
                        precoVenda.data_validade_inicial = (int)reader["data_validade_inicial"];
                        precoVenda.data_validade_final = (int)reader["data_validade_final"];
                        precoVendas.Add(precoVenda);
                    }
                }
            }
            return precoVendas;
        }
        public void UpdatePrecoVenda(PrecoVenda precoVenda)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update PrecoVenda set ID_produto = @ID_produto, preco_venda = @preco_venda," +
                    "data_validade_inicial = @data_validade_inicial," +
                    " data_validade_final = @data_validade_final were ID_PrecoVenda = @ID_PrecoVenda";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_produto", precoVenda.ID_produto);
                command.Parameters.AddWithValue("@preco_venda", precoVenda.preco_venda);
                command.Parameters.AddWithValue("@data_validade_inicial", precoVenda.data_validade_inicial);
                command.Parameters.AddWithValue("@data_validade_final", precoVenda.data_validade_final);
                command.Parameters.AddWithValue("@ID_PrecoVenda", precoVenda.ID_PrecoVenda);
                command.ExecuteNonQuery();
            }
        }
    }
}
