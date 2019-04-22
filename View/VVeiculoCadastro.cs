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
    public partial class VVeiculoCadastro : Form
    {

        public VVeiculoCadastro()
        {
            InitializeComponent();
        }

        //CARREGAR AS PESSOAS AO INICIAR O FORMULARIO
        private void VVeiculoCadastro_Load(object sender, EventArgs e)
        {
                carregarPessoa();          
        }

        //FUNÇÃO PARA CARREGAR AS PESSOAS NO COMBOBOX
        private void carregarPessoa()
        {
            MPessoa item = new MPessoa();

            item.Nome = "";
            item.CPF = "";

            cbNomeProprietarioCadastro.DataSource = CPessoa.Pesquisar(item);
        }

        //PRENCHER CPF COM ESCOLHA DO COMBOBOX
        private void cbNomeProprietarioCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtCPF.Text = cbNomeProprietarioCadastro.SelectedValue.ToString();
        }

        //CONVERTER PLACA PARA TOUPPER
        private void mtxtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtPlaca.Mask.ToUpper();
        }

        //BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MVeiculo item = new MVeiculo();

            item.RENAVAM = mtxtRenavam.Text;
            item.Placa = mtxtPlaca.Text;
            item.Modelo = txtModelo.Text;

            try
            {
                item.AnoFabricacao = int.Parse(cbAnoFabricacao.Text);
                item.AnoModelo = int.Parse(cbAnoModelo.Text);
            }
            catch
            {
                MessageBox.Show("Ano de Fabricacao/Modelo esta em formato inválido");
                return;
            }

            item.PessoaCPF = mtxtCPF.Text;

            try
            {
                CVeiculo.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");

                //LIMPA OS CAMPOS PARA NOVOS CADASTROS
                item.RENAVAM = mtxtRenavam.Text = ("");
                item.Placa = mtxtPlaca.Text = ("");
                item.Modelo = txtModelo.Text = ("");
                cbAnoFabricacao.Text = ("");
                cbAnoModelo.Text = ("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BOTÃO CANCELAR
        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÃO FECHAR
        private void btnFecharFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNÇÃO FECHAR FORMULARIO
        private void fecharformulario(object sender, FormClosingEventArgs e)
        {

            DialogResult cancelarProprietario = MessageBox.Show("Deseja fechar o cadastro de Veículo?",
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
