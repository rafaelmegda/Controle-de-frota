
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DPessoa
    {
        //INSERIR
        public static void Inserir(MPessoa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = 
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                "INSERT INTO TBPessoa(CPF, Nome, DataNascimento) " +
                "VALUES(@CPF, @Nome, @DataNascimento)";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Nome", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@DataNascimento", SqlDbType.Date);
            param.Value = item.DataNascimento ;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("CPF ja existente no sistema!");
            }
            finally
            {
                conexao.Close();
            }
        }

        //ATUALIZAR 
        public static void Atualizar(MPessoa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                "UPDATE TBPessoa SET Nome = @Nome, DataNascimento = @DataNascimento " +
                " WHERE CPF = @CPF";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Nome", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@DataNascimento", SqlDbType.Date);
            param.Value = item.DataNascimento;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("O comando não pode ser executado");
            }
            finally
            {
                conexao.Close();
            }
        }

        //OBTER 
        public static MPessoa Obter(MPessoa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                " SELECT CPF, Nome, DataNascimento " +
                " FROM TBPessoa " +
                " WHERE CPF = @CPF ";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            MPessoa retorno = null;

            if (reader.Read())
            {
                retorno = new MPessoa();

                retorno.CPF = reader["CPF"].ToString();
                retorno.Nome = reader["Nome"].ToString();
                retorno.DataNascimento = (DateTime)reader["DataNascimento"];
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //EXCLUIR 
        public static void Excluir(MPessoa item)
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = 
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM TBPessoa where CPF = @CPF";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        //PESQUISAR
        public static List<MPessoa> Pesquisar(MPessoa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                " SELECT CPF, Nome, DataNascimento " +
                " FROM TBPessoa " +
                " WHERE 1=1 ";             

            if(item.CPF.Trim() != "")
            {
                comando.CommandText += " AND CPF = @CPF ";

                SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
                param.Value = item.CPF;
                comando.Parameters.Add(param);
            }

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND Nome LIKE @Nome ";

                SqlParameter param = new SqlParameter("@Nome", SqlDbType.VarChar);
                param.Value = "%" + item.Nome + "%";
                comando.Parameters.Add(param);
            }


            SqlDataReader reader = comando.ExecuteReader();

            List<MPessoa> retorno = null;

            while(reader.Read())
            {
                if (retorno == null)
                    retorno = new List<MPessoa>();

                MPessoa pessoa = new MPessoa();
                pessoa.CPF = reader["CPF"].ToString();
                pessoa.Nome = reader["Nome"].ToString();
                pessoa.DataNascimento = (DateTime)reader["DataNascimento"];

                retorno.Add(pessoa);
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }
    }
}
