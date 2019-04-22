using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CPessoa
    {
        //PESQUISAR
        public static List<MPessoa> Pesquisar(MPessoa item)
        {
            List<MPessoa> retorno = null;

            if (item != null && item.Nome != null && item.Nome.Length <= 200)
            {
                string cpf = item.CPF.Replace(".", "");
                cpf = cpf.Replace("-", "");
                cpf = cpf.Trim();

                if (cpf == "")
                {
                    item.CPF = "";
                }

                retorno = DPessoa.Pesquisar(item);

                //RETORNO SE NÃO HOUVER NENHUM CADASTRO
                if (retorno == null)
                {
                    throw new Exception("A Pesquisa não retornou nenhum cadastro!");
                }                
            }
            return retorno;
        }

        //OBTER
        public static MPessoa Obter(MPessoa item)
        {
            MPessoa retorno = null;

            if (item != null)
            {
                string cpf = item.CPF.Replace(".", "");
                cpf = cpf.Replace("-", "");
                cpf = cpf.Trim();

                if (cpf == "")
                {
                    item.CPF = "";
                }

                retorno = DPessoa.Obter(item);
            }

            return retorno;
        }

        //ATUALIZAR
        public static void Atualizar(MPessoa item)
        {
            if (item == null)
            {
                throw new Exception("Objeto PESSOA inválido");
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 200)
            {
                throw new Exception("Nome digitado inválido");
            }

            if (item.DataNascimento >= DateTime.Now)
            {
                throw new Exception("Ano de Nascimento não pode ser maior que a data atual!");
            }

            try
            {
                DPessoa.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }

        //INSERIR
        public static void Inserir(MPessoa item)
        {
            if (item == null)
            {
                throw new Exception("Objeto PESSOA inválido");
            }

            //NOME
            if (item.Nome.Trim() == "" || item.Nome.Length > 200)
            {
                throw new Exception("O Nome digitado esta inválido");
            }

            //CPF
            if (item.CPF.Trim() == "" || item.CPF.Length != 14)
            {
                throw new Exception("Objeto CPF em branco, ou com numeros incompletos");
            }

            for (int i = 0; i < 14; i++)
            {
                if (i != 3 && i != 7 && i != 11)
                {
                    if (!Char.IsDigit(item.CPF[i]))
                    {
                        throw new Exception("CPF inválido");
                    }
                }
            }
            
            //DATA DE NASCIMENTO
            if (item.DataNascimento > DateTime.Now)
            {
                throw new Exception("Ano de Nascimento não pode ser maior que a data atual!");
            }

            try
            {
                DPessoa.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MPessoa item)
        {
            if (item.CPF.Trim() == "")
                throw new Exception("CPF inválido");

            try
            {
                DPessoa.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
