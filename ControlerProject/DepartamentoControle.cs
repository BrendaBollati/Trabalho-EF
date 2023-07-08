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
    public class DepartamentoControle
    {
        public string connectionStrings = "Data Source=HUCKLEBERRY_22;Initial Catalog=TrabalhoEFBanco;User ID=HUCKLEBERRY_22\brend,Password=senhateste;";
        public void InsertDepartamento(Departamento departamento)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "isert into Departamento (Descricao) values (@Descricao)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", departamento.Descricao);
                command.ExecuteNonQuery();
            }
        }
        public void RemoveDepartamento(int IDdepartamento)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "delete from Departamento where ID_Departamento = @ID_Departamento";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Categoria", IDdepartamento);
                command.ExecuteNonQuery();
            }
        }
        public List<Departamento> GetAllDepartamento()
        {
            List<Departamento> departamentos = new List<Departamento>();
             SqlConnection connection = new SqlConnection(connectionStrings);
            {
                string query = "select ID_Departamento, Descricao from Departamento";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Departamento departamento = new Departamento();
                        departamento.ID_Departamento = (int)reader["ID_Departamento"];
                        departamento.Descricao = (string)reader["Descricao"];
                        departamentos.Add(departamento);
                    }
                }

            }
            return departamentos;
        }
        public void UpdateDepartamento(Departamento departamento)
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                string query = "update Departamento set Descricao = @Descricao" +
                    " were ID_Departamento = @ID_Departamento";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", departamento.Descricao);
                command.Parameters.AddWithValue("@ID_Departamento", departamento.ID_Departamento);
                command.ExecuteNonQuery();
            }
        }
    }
}
