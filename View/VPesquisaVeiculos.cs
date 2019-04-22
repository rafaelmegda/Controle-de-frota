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
    public partial class VPesquisaVeiculos : Form
    {
        public VPesquisaVeiculos()
        {
            InitializeComponent();
        }

        //LIMPA OS CAMPOS PARA NOVOS CADASTROS
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            MVeiculo item = new MVeiculo();

            item.PessoaCPF = mtxtCPFPesquisa.Text = ("");
            item.RENAVAM = mtxtRenavamPesquisa.Text = ("");
            item.Placa = mtxtPlacaPesquisa.Text = ("");
            item.Modelo = txtModeloPesquisa.Text = ("");
            cbAnoFabricacaoPesquisa.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        //BOTÃO PESQUISAR
        private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            MVeiculo item = new MVeiculo();

            item.RENAVAM = mtxtRenavamPesquisa.Text;
            item.Placa = mtxtPlacaPesquisa.Text;
            item.Modelo = txtModeloPesquisa.Text;
            item.PessoaCPF = mtxtCPFPesquisa.Text;

            //TRATA A SELEÇÃO DO COMBOBOX EM BRANCO
            if (cbAnoFabricacaoPesquisa.SelectedIndex != -1 && cbAnoFabricacaoPesquisa.SelectedIndex != 0)
            {
                item.AnoFabricacao = int.Parse(cbAnoFabricacaoPesquisa.Text);
            }

            //LIMPA O DATAGRID SE A PESQUISA NÃO OBTER DADOS
            dataGridView1.DataSource = null;

            try
            {
                dataGridView1.DataSource = CVeiculo.Pesquisar(item);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        //BOTÃO EXCLUIR
        private void btnExcluirPesquisa_Click(object sender, EventArgs e)
        {
            Exluir();
        }

        //FUNÇÃO EXCLUIR
        private void Exluir()
        {
            if (dataGridView1.SelectedRows != null &&
               dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("Deseja excluir este veiculo?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (r == DialogResult.Yes)
                {
                    MVeiculo item = (MVeiculo)dataGridView1.SelectedRows[0].
                       DataBoundItem;

                    bool sucesso = false;
                    try
                    {
                        CVeiculo.Excluir(item);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao excluir o veiculo selecionado",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Veiculo excluído com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<MVeiculo> lista = (List<MVeiculo>)dataGridView1.DataSource;
                        lista.Remove(item);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lista;
                    }
                }
            }
        }

        //BOTÃO EDITAR
        private void btnEditarPesquisaVeiculo_Click(object sender, EventArgs e)
        {
            Editar();
        }

        //FUNÇÃO EDITAR
        private void Editar()
        {
            if (dataGridView1.SelectedRows != null &&
              dataGridView1.SelectedRows.Count > 0)
            {
                MVeiculo item = new MVeiculo();
                item.RENAVAM = dataGridView1.SelectedRows[0].
                    Cells["rENAVAMDataGridViewTextBoxColumn"].Value.ToString();

                VVeiculoEditar v = new VVeiculoEditar(item);
                v.ShowDialog();

                if (v.Atualizou)
                {
                    btnPesquisarVeiculo_Click(null, null);
                }
            }
        }

        //FUNÇÃO FECHAR FORMULÁRIO
        private void fecharformulario(object sender, FormClosingEventArgs e)
        {
            DialogResult cancelarProprietario = MessageBox.Show("Deseja finalizar a pesquisa de Veículos?", "ATENÇÃO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cancelarProprietario.ToString().ToUpper() == "YES")
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        //BOTÃO CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÃO FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
