using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBoteco.Classes
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string cargo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\TDS\\2° Periodo\\PA - Prof.Emerson\\AppBoteco\\AppBoteco\\DbBoteco.mdf\";Integrated Security=True");

        public List<Funcionario> listacliente()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = (int)dr["Id"];
                f.nome = dr["nome"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.celular = dr["celular"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.bairro = dr["bairro"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.cep = dr["cep"].ToString();
                f.cargo = dr["cargo"].ToString();
                li.Add(f);
                
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string cpf, string endereco, string bairro, string cidade,string celular,string cep,string cargo)
        {
            string sql = "INSERT INTO Funcionario(nome,cpf,endereço,bairro,cidade,celular,cep,cargo) VALUES ('" + nome + "', '" + cpf + "', '" + endereco + "','"+bairro+"','"+cidade+"','"+celular+"','"+cep+"','"+cargo+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string cpf, string endereco, string bairro, string cidade, string celular, string cep, string cargo)
        {
            string sql = "UPDATE Funcionario SET nome='" + nome + "',cpf'" + cpf + "',endereco='"+endereco+"',bairo='"+bairro+"',cidade='"+cidade+"',celular='" + celular + "',cep='"+cep+"',cargo='"+cargo+"' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                celular = dr["celular"].ToString();
                endereco = dr["endereco"].ToString();
                bairro = dr["bairro"].ToString();
                cidade = dr["cidade"].ToString();
                cep = dr["cep"].ToString();
                cargo = dr["cargo"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public bool RegistroRepetido(string cpf)
        {
            string sql = "SELECT * FROM Funcionario WHERE cpf='" + cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
