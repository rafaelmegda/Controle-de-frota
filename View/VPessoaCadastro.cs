using Controller;
using Model;
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
    public partial class VPessoaCadastro : Form
    {
        public VPessoaCadastro()
        {
            InitializeComponent();
        }

        //BOTÃO SALVAR
        private void button1_Click(object sender, EventArgs e)
        {
            MPessoa item = new MPessoa();

            item.CPF = txtCPF.Text;
            item.Nome = txtNome.Text;
            item.DataNascimento = txtDataNascimento.Value;

            try
            {
                CPessoa.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");
                
                //LIMPA OS CAMPOS PARA NOVOS CADASTROS E PERMITE REALIZAR DIVERSOS CADASTRO NA MESMA TELA
                item.CPF = txtCPF.Text = ("");
                item.Nome = txtNome.Text = ("");
                item.DataNascimento = txtDataNascimento.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BOTÃO FECHAR
        private void btnFecharCadastroUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fecharformulario(object sender, FormClosingEventArgs e)
        {

            DialogResult cancelarProprietario = MessageBox.Show("Deseja fechar o cadastro de Proprietário?",
                "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
