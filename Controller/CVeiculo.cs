using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CVeiculo
    {
        //PESQUISAR 
        public static List<MVeiculo> Pesquisar(MVeiculo item)
        {
            List<MVeiculo> retorno = null;

            if (item != null && item.PessoaCPF != null && item.RENAVAM != null)
            {
                string cpf = item.PessoaCPF.Replace(".", "");
                cpf = cpf.Replace("-", "");
                cpf = cpf.Trim();

                if (cpf == "")
                {
                    item.PessoaCPF = "";
                }


                item.Placa = item.Placa.Trim();

                if (item.Placa == "-")
                {
                    item.Placa = item.Placa.Replace("-", "");
                }

                retorno = DVeiculo.Pesquisar(item);

                //RETORNO SE NÃO HOUVER NENHUM CADASTRO
                if (retorno == null)
                {
                    throw new Exception("A Pesquisa não retornou nenhum cadastro!");
                }
            }
            return retorno;
        }

        //INSERIR 
        public static void Inserir(MVeiculo item)
        {
            if (item == null)
            {
                throw new Exception("Objeto VEICULO inválido");
            }

            if (item.PessoaCPF.Trim() == "" || item.PessoaCPF.Length != 14)
            {
                throw new Exception("Objeto CPF em branco, ou com numeros incompletos");
            }
            for (int i = 0; i < 14; i++)
            {
                if (i != 3 && i != 7 && i != 11)
                {
                    if (!Char.IsDigit(item.PessoaCPF[i]))
                    {
                        throw new Exception("CPF inválido");
                    }
                }
            }

            //RENAVAM - Pesquisar se o RENAVAM Ja exsite no banco
            if (item.RENAVAM.Trim() == "" || item.RENAVAM.Length != 11)
            {
                throw new Exception("Objeto RENAVAM com numeros incompletos");
            }
            for (int i = 0; i < 11; i++)
            {
                {
                    if (!Char.IsDigit(item.RENAVAM[i]))
                    {
                        throw new Exception("Objeto RENAVAM com caracteres inválidos");
                    }
                }
            }

            //PLACA 
            if (item.Placa.Trim() == "" || item.Placa.Length != 8)
            {
                throw new Exception("Objeto Placa com preenchimento inválido");
            }
            //VALIDACAO CONSIDERANDO MODELO SULAMERICANO
            for (int cont = 0; cont < 3; cont++)
            {
                if (Char.IsDigit(item.Placa[cont]))
                {
                    throw new Exception("Objeto PLACA digitado com numero em local de letras");
                }
            }

            //MODELO
            if (item.Modelo.Trim() == "" || item.Modelo.Length > 100)
            {
                throw new Exception("Objeto MODELO em branco, ou excedeu a quantidade de caracteres");
            }

            //ANO MODELO < ANO FABRICACAO
            if (item.AnoModelo > item.AnoFabricacao)
            {
                throw new Exception("Ano Modelo não pode ser maior do que o Ano de Fabricação!");
            }

            if (item.AnoModelo + 1 < item.AnoFabricacao)
            {
                throw new Exception("Ano Modelo com diferença maior que 1 ano ao ano de fabricação!");
            }

            //Inserir no banco
            try
            {
                DVeiculo.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //ATUALIZAR
        public static void Atualizar(MVeiculo item)
        {
            if (item == null)
            {
                throw new Exception("Objeto VEICULO inválido");
            }

            if (item.PessoaCPF.Trim() == "" || item.PessoaCPF.Length != 14)
            {
                throw new Exception("Objeto CPF em branco, ou com numeros incompletos");
            }
            for (int i = 0; i < 14; i++)
            {
                if (i != 3 && i != 7 && i != 11)
                {
                    if (!Char.IsDigit(item.PessoaCPF[i]))
                    {
                        throw new Exception("CPF inválido");
                    }
                }
            }

            //RENAVAM
            if (item.RENAVAM.Trim() == "" || item.RENAVAM.Length != 11)
            {
                throw new Exception("Objeto RENAVAM com numeros incompletos");
            }
            for (int i = 0; i < 11; i++)
            {
                {
                    if (!Char.IsDigit(item.RENAVAM[i]))
                    {
                        throw new Exception("Objeto RENAVAM com caracteres inválidos");
                    }
                }
            }

            //PLACA 
            if (item.Placa.Trim() == "" || item.Placa.Length != 8)
            {
                throw new Exception("Objeto Placa com preenchimento inválido");
            }
            //VALIDACAO CONSIDERANDO MODELO SULAMERICANO
            for (int cont = 0; cont < 2; cont++)
            {
                if (Char.IsDigit(item.Placa[cont]))
                {
                    throw new Exception("Objeto PLACA digitado com numero em local de letras");
                }
            }

            //MODELO
            if (item.Modelo.Trim() == "" || item.Modelo.Length > 100)
            {
                throw new Exception("Objeto MODELO em branco, ou excedeu a quantidade de caracteres");
            }

            //ANO MODELO < ANO FABRICACAO
            if (item.AnoModelo > item.AnoFabricacao)
            {
                throw new Exception("Ano Modelo não pode ser maior do que o Ano de Fabricação!");
            }

            if (item.AnoModelo + 1 < item.AnoFabricacao)
            {
                throw new Exception("Ano Modelo com diferença maior que 1 ano ao ano de fabricação!");
            }

            try
            {
                DVeiculo.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }

        //OBTER
        public static MVeiculo Obter(MVeiculo item)
        {
            MVeiculo retorno = null;

            if (item != null)
            {
                retorno = DVeiculo.Obter(item);
            }
            return retorno;
        }

        //EXLUIR
        public static void Excluir(MVeiculo item)
        {
            if (item.RENAVAM.Trim() == "")
                throw new Exception("RENAVAM inválido");

            try
            {
                DVeiculo.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
