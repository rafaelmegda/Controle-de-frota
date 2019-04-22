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
    public partial class VVeiculoEditar : Form
    {
        MVeiculo atual = null;
        internal bool Atualizou = false;
        public VVeiculoEditar(Model.MVeiculo item)
        {
            InitializeComponent();
            atual = item;
        }

        //BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            atual.Placa = mtxtPlacaEditar.Text;
            atual.Modelo = txtModeloEditar.Text;

            try
            {
                atual.AnoFabricacao = int.Parse(cbAnoFabricacaoEditar.Text);
                atual.AnoModelo = int.Parse(cbAnoModeloEditar.Text);
            }
            catch
            {
                MessageBox.Show("Ano de Fabricacao/Modelo esta em formato inválido");
                return;
            }
                       
            bool sucesso = false;

            try
            {
                CVeiculo.Atualizar(atual);
                sucesso = true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            if (sucesso)
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                Atualizou = true;
                Close();
            }
        }

        //FUNÇÃO EDITAR
        private void VVeiculoEditar_Load(object sender, EventArgs e)
        {
            atual = CVeiculo.Obter(atual);

            if (atual != null)
            {
                mtxtCPFEditar.Text = atual.PessoaCPF;
                mtxtRenavamEditar.Text = atual.RENAVAM;
                mtxtPlacaEditar.Text = atual.Placa;
                txtModeloEditar.Text = atual.Modelo.Trim();
                cbAnoModeloEditar.Text = atual.AnoModelo.ToString();
                cbAnoFabricacaoEditar.Text = atual.AnoFabricacao.ToString();
            }
            else
            {
                Close();
            }
        }
    }
}
