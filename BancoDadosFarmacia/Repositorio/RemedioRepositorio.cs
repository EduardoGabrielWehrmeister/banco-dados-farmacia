using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RemedioRepositorio
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\Documents\Exemplo01.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();

            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Solido = Convert.ToBoolean(linha["solido"]);
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.Receita = Convert.ToBoolean(linha["receita"]);
                remedio.ContraIndicacao = linha["contra_indicacao"].ToString();
                remedio.Categoria = linha["categoria"].ToString();
                remedios.Add(remedio);
            }
            conexao.Close();
            return remedios;
        }

        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();

            if(dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Nome = linha["nome"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["solido"]);
                remedio.Receita = Convert.ToBoolean(linha["receita"]);
                remedio.ContraIndicacao = linha["contra_indicacao"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Bula = linha["bula"].ToString();
                return remedio;
            }
            return null;
        }

        public void Inserir(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = @"INSERT INTO remedios (nome, generico, categoria, solido, contra_indicacao, bula, faixa, receita) VALUES (@NOME, @GENERICO, @CATEGORIA, @SOLIDO, @CONTRA_INDICACAO, @BULA, @FAIXA, @RECEITA)";
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACAO", remedio.ContraIndicacao);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE remedios SET nome = @NOME, generico = @GENERICO, categoria = @CATEGORIA, solido = @SOLIDO, contra_indicacao = @CONTRA_INDICACAO, bula = @BULA, faixa = @FAIXA,
receita = @RECEITA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACAO", remedio.ContraIndicacao);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);
            comando.Parameters.AddWithValue("@ID", remedio.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }


    }
}
