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
    public partial class VPessoaEditar : Form
    {
        MPessoa atual = null;
        internal bool Atualizou = false;

        public VPessoaEditar(MPessoa item)
        {
            InitializeComponent();
            atual = item;
        }

        //FUNÇÃO EDITAR
        private void VPessoaEditar_Load(object sender, EventArgs e)
        {
            atual = CPessoa.Obter(atual);

            if(atual != null)
            {
                txtCPF.Text = atual.CPF;
                txtNome.Text = atual.Nome;
                txtDataNascimento.Value = atual.DataNascimento;
            }
            else
            {
                Close();
            }
        }

        //BOTÃO SALVAR
        private void button1_Click(object sender, EventArgs e)
        {
            atual.DataNascimento = txtDataNascimento.Value;
            atual.Nome = txtNome.Text;

            bool sucesso = false;

            try
            {
                CPessoa.Atualizar(atual);
                sucesso = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            if(sucesso)
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                Atualizou = true;
                Close();
            }
        }
    }
}
