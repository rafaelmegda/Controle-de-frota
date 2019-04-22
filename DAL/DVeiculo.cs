using System;
using Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DVeiculo
    {
        //INSERIR
        public static void Inserir(MVeiculo item)
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
                "INSERT INTO TBVeiculo(Renavam, Placa, Modelo, AnoFabricacao, AnoModelo, PessoaCPF) " +
                "VALUES(@Renavam, @Placa, @Modelo, @AnoFabricacao, @AnoModelo, @PessoaCPF)";

            SqlParameter param = new SqlParameter("@Renavam", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Placa", SqlDbType.Char);
            param.Value = item.Placa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Modelo", SqlDbType.Char);
            param.Value = item.Modelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoFabricacao", SqlDbType.Int);
            param.Value = item.AnoFabricacao;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoModelo", SqlDbType.Int);
            param.Value = item.AnoModelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@PessoaCPF", SqlDbType.Char);
            param.Value = item.PessoaCPF;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Renavam Já Cadastro para outro Veículo!");
            }
            finally
            {
                conexao.Close();
            }
        }

        //ATUALIZAR
        public static void Atualizar(MVeiculo item)
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
                "UPDATE TBVeiculo SET RENAVAM = @RENAVAM, Placa = @Placa, Modelo = @Modelo, " +
                " AnoFabricacao = @AnoFabricacao, AnoModelo = @AnoModelo, PessoaCPF = @PessoaCPF " +
                " WHERE RENAVAM = @RENAVAM ";

            SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Placa", SqlDbType.Char);
            param.Value = item.Placa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Modelo", SqlDbType.VarChar);
            param.Value = item.Modelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoFabricacao", SqlDbType.Int);
            param.Value = item.AnoFabricacao;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoModelo", SqlDbType.Int);
            param.Value = item.AnoModelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@PessoaCPF", SqlDbType.Char);
            param.Value = item.PessoaCPF;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("O comando atualizar não pode ser executado");
            }
            finally
            {
                conexao.Close();
            }
        }

        //OBTER
        public static MVeiculo Obter(MVeiculo item)
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
                " SELECT Renavam, Placa, Modelo, AnoFabricacao, " +
                " AnoModelo, PessoaCPF " +
                " FROM TBVeiculo " +
                " WHERE Renavam = @Renavam";

            SqlParameter param = new SqlParameter("@Renavam", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            MVeiculo retorno = null;

            if (reader.Read())
            {
                retorno = new MVeiculo();

                retorno.PessoaCPF = reader["PessoaCPF"].ToString();
                retorno.RENAVAM = reader["RENAVAM"].ToString();
                retorno.Modelo = reader["Modelo"].ToString();
                retorno.Placa = reader["Placa"].ToString();
                retorno.AnoFabricacao = (int)reader["AnoFabricacao"];
                retorno.AnoModelo = (int)reader["AnoModelo"];
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //PESQUISAR
        public static List<MVeiculo> Pesquisar(MVeiculo item)
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
                " SELECT veic.RENAVAM, veic.Placa, veic.Modelo, veic.AnoFabricacao, " +
                " veic.AnoModelo, veic.PessoaCPF, pessoa.Nome " +
                " FROM TBVeiculo veic join TBPessoa pessoa on (veic.PessoaCPF = pessoa.CPF) " +
                " WHERE 1 = 1";

            if (item.PessoaCPF.Trim() != "")
            {
                comando.CommandText += " AND PessoaCPF = @PessoaCPF ";

                SqlParameter param = new SqlParameter("@PessoaCPF", SqlDbType.Char);
                param.Value = item.PessoaCPF;
                comando.Parameters.Add(param);
            }

            if (item.RENAVAM.Trim() != "")
            {
                comando.CommandText += " AND RENAVAM = @RENAVAM ";

                SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
                param.Value = item.RENAVAM;
                comando.Parameters.Add(param);
            }

            if (item.Placa.Trim() != "")
            {
                comando.CommandText += " AND Placa LIKE @Placa ";

                SqlParameter param = new SqlParameter("@Placa", SqlDbType.Char);
                param.Value = "%" + item.Placa + "%";
                comando.Parameters.Add(param);
            }

            if (item.Modelo.Trim() != "")
            {
                comando.CommandText += " AND Modelo LIKE @Modelo ";

                SqlParameter param = new SqlParameter("@Modelo", SqlDbType.VarChar);
                param.Value = "%" + item.Modelo + "%";
                comando.Parameters.Add(param);
            }

            if (item.AnoFabricacao != 0)
            {
                comando.CommandText += " AND AnoFabricacao = @AnoFabricacao ";

                SqlParameter param = new SqlParameter("@AnoFabricacao", SqlDbType.Int);
                param.Value = item.AnoFabricacao;
                comando.Parameters.Add(param);
            }

            if (item.AnoModelo != 0)
            {
                comando.CommandText += " AND AnoModelo = @AnoModelo ";

                SqlParameter param = new SqlParameter("@AnoModelo", SqlDbType.Int);
                param.Value = item.AnoModelo;
                comando.Parameters.Add(param);
            }

            SqlDataReader reader = comando.ExecuteReader();

            List<MVeiculo> retorno = null;

            while (reader.Read())
            {
                if (retorno == null)
                    retorno = new List<MVeiculo>();

                MVeiculo veiculo = new MVeiculo();
                veiculo.PessoaCPF = reader["PessoaCPF"].ToString();
                veiculo.RENAVAM = reader["RENAVAM"].ToString();
                veiculo.Modelo = reader["Modelo"].ToString();
                veiculo.Placa = reader["Placa"].ToString();
                veiculo.AnoModelo = (int)reader["AnoModelo"];
                veiculo.AnoFabricacao = (int)reader["AnoFabricacao"];
                veiculo.PessoaNome = reader["Nome"].ToString();

                retorno.Add(veiculo);
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //EXCLUIR
        public static void Excluir(MVeiculo item)
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

            comando.CommandText = "DELETE FROM TBVeiculo where RENAVAM = @RENAVAM";

            SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            param.Value = item.RENAVAM;
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
    }
}

