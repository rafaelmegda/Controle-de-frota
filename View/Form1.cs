using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOTÃO CADASTRO VEICULO
        private void button1_Click(object sender, EventArgs e)
        {
            new VPessoaCadastro().ShowDialog();
        }

        //BOTÃO PESQUISA PESSOA
        private void button2_Click(object sender, EventArgs e)
        {
            new VPessoaPesquisa().ShowDialog();
        }

        //BOTÃO CADASTRO VEICULO
        private void btnCadastroVeiculos_Click(object sender, EventArgs e)
        {
            new VVeiculoCadastro().ShowDialog();
        }
        
        //BOTÃO PESQUISA VEICULO
        private void btnPesquisaVeiculos_Click(object sender, EventArgs e)
        {
            new VPesquisaVeiculos().ShowDialog();
        }

        //BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //FUNÇÃO FECHAR FORMULARIO
        private void fecharFomulario(object sender, FormClosingEventArgs e)
        {
            DialogResult cancelarProprietario = MessageBox.Show("Deseja Encerrar o Sistema?", "ATENÇÃO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cancelarProprietario.ToString().ToUpper() == "YES")
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}