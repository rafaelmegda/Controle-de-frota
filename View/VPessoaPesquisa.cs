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
    public partial class VPessoaPesquisa : Form
    {
        public VPessoaPesquisa()
        {
            InitializeComponent();
        }

        //BOTÃO PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MPessoa item = new MPessoa();

            item.CPF = txtCPF.Text;
            item.Nome = txtNome.Text;

            dataGridView1.DataSource = null;

            try
            {
                dataGridView1.DataSource = CPessoa.Pesquisar(item);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        //BOTÃO LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            MPessoa item = new MPessoa();

            item.CPF = txtCPF.Text = ("");
            item.Nome = txtNome.Text = ("");
            dataGridView1.DataSource = null;
        }

        //BOTÃO EXCLUIR
        private void btnExcluirPesquisar_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        //EXCLUIR PESSOA
        private void Excluir()
        {
            if (dataGridView1.SelectedRows != null &&
                dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("Deseja excluir esta pessoa?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (r == DialogResult.Yes)
                {
                    MPessoa item = (MPessoa)dataGridView1.SelectedRows[0].
                       DataBoundItem;

                    bool sucesso = false;
                    try
                    {
                        CPessoa.Excluir(item);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Proprietário Tem Veiculo Cadastro! Gentileza Excluir o Veículo Primeiro",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Pessoa excluída com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<MPessoa> lista = (List<MPessoa>)dataGridView1.DataSource;
                        lista.Remove(item);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lista;
                    }
                }
            }
        }

        //BOTÃO EDITAR
        private void btnEditarPesquisaPessoa_Click(object sender, EventArgs e)
        {
            Editar();
        }

        //EDITAR PESSOA
        private void Editar()
        {
            if (dataGridView1.SelectedRows != null &&
               dataGridView1.SelectedRows.Count > 0)
            {
                MPessoa item = new MPessoa();
                item.CPF = dataGridView1.SelectedRows[0].
                    Cells["cPFDataGridViewTextBoxColumn"].Value.ToString();

                VPessoaEditar v = new VPessoaEditar(item);
                v.ShowDialog();

                if (v.Atualizou)
                {
                    btnPesquisar_Click(null, null);
                }
            }
        }

        //BOTÃO CANCELAR
        private void btnExcluirPesquisaPessoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FECHAR O FORUMLÁRIO
        private void fecharfomulario(object sender, FormClosingEventArgs e)
        {
            DialogResult cancelarProprietario = MessageBox.Show("Deseja finalizar a pesquisa de Proprietário?", "ATENÇÃO!",
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
