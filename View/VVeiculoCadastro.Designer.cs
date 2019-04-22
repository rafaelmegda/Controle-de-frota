namespace View
{
    partial class VVeiculoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVeiculoCadastro));
            this.lRenavam = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.mtxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbAnoFabricacao = new System.Windows.Forms.Label();
            this.lbAnoModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRenavam = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNomeProprietarioCadastro = new System.Windows.Forms.ComboBox();
            this.mPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAnoModelo = new View.PreencherAnoCB();
            this.cbAnoFabricacao = new View.PreencherAnoCB();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnFecharFormulario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lRenavam
            // 
            this.lRenavam.AutoSize = true;
            this.lRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRenavam.Location = new System.Drawing.Point(14, 132);
            this.lRenavam.Name = "lRenavam";
            this.lRenavam.Size = new System.Drawing.Size(75, 17);
            this.lRenavam.TabIndex = 1;
            this.lRenavam.Text = "Renavam";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(14, 170);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 17);
            this.lbPlaca.TabIndex = 3;
            this.lbPlaca.Text = "Placa";
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(160, 167);
            this.mtxtPlaca.Mask = "???-0000";
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(56, 20);
            this.mtxtPlaca.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtxtPlaca, "Inserir Placa Veículo");
            this.mtxtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPlaca_MaskInputRejected);
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(338, 99);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(60, 17);
            this.lbModelo.TabIndex = 5;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(404, 98);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(184, 20);
            this.txtModelo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtModelo, "Descreva o modelo Veículo");
            // 
            // lbAnoFabricacao
            // 
            this.lbAnoFabricacao.AutoSize = true;
            this.lbAnoFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoFabricacao.Location = new System.Drawing.Point(338, 135);
            this.lbAnoFabricacao.Name = "lbAnoFabricacao";
            this.lbAnoFabricacao.Size = new System.Drawing.Size(144, 17);
            this.lbAnoFabricacao.TabIndex = 7;
            this.lbAnoFabricacao.Text = "Ano de Fabricação";
            // 
            // lbAnoModelo
            // 
            this.lbAnoModelo.AutoSize = true;
            this.lbAnoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoModelo.Location = new System.Drawing.Point(338, 174);
            this.lbAnoModelo.Name = "lbAnoModelo";
            this.lbAnoModelo.Size = new System.Drawing.Size(116, 17);
            this.lbAnoModelo.TabIndex = 9;
            this.lbAnoModelo.Text = "Ano de Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPF Pessoa";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Location = new System.Drawing.Point(160, 98);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtxtCPF, "CPF do Proprietário");
            // 
            // mtxtRenavam
            // 
            this.mtxtRenavam.Location = new System.Drawing.Point(160, 132);
            this.mtxtRenavam.Mask = "00000000000";
            this.mtxtRenavam.Name = "mtxtRenavam";
            this.mtxtRenavam.Size = new System.Drawing.Size(100, 20);
            this.mtxtRenavam.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtxtRenavam, "Inserir Renavam Veículo");
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::View.Properties.Resources.save32;
            this.btnSalvar.Location = new System.Drawing.Point(450, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 46);
            this.btnSalvar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Cadastro do Veículo");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome Proprietário";
            // 
            // cbNomeProprietarioCadastro
            // 
            this.cbNomeProprietarioCadastro.DataSource = this.mPessoaBindingSource;
            this.cbNomeProprietarioCadastro.DisplayMember = "Nome";
            this.cbNomeProprietarioCadastro.FormattingEnabled = true;
            this.cbNomeProprietarioCadastro.Location = new System.Drawing.Point(160, 61);
            this.cbNomeProprietarioCadastro.Name = "cbNomeProprietarioCadastro";
            this.cbNomeProprietarioCadastro.Size = new System.Drawing.Size(428, 21);
            this.cbNomeProprietarioCadastro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbNomeProprietarioCadastro, "Selecione o Nome do Proprietário");
            this.cbNomeProprietarioCadastro.ValueMember = "CPF";
            this.cbNomeProprietarioCadastro.SelectedIndexChanged += new System.EventHandler(this.cbNomeProprietarioCadastro_SelectedIndexChanged);
            // 
            // mPessoaBindingSource
            // 
            this.mPessoaBindingSource.DataSource = typeof(Model.MPessoa);
            // 
            // cbAnoModelo
            // 
            this.cbAnoModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoModelo.FormattingEnabled = true;
            this.cbAnoModelo.Location = new System.Drawing.Point(488, 170);
            this.cbAnoModelo.Name = "cbAnoModelo";
            this.cbAnoModelo.Size = new System.Drawing.Size(100, 21);
            this.cbAnoModelo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cbAnoModelo, "Selecione o Ano de Modelo");
            // 
            // cbAnoFabricacao
            // 
            this.cbAnoFabricacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoFabricacao.FormattingEnabled = true;
            this.cbAnoFabricacao.Location = new System.Drawing.Point(488, 132);
            this.cbAnoFabricacao.Name = "cbAnoFabricacao";
            this.cbAnoFabricacao.Size = new System.Drawing.Size(100, 21);
            this.cbAnoFabricacao.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbAnoFabricacao, "Selecione o Ano de Fabricação");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "CADASTRO DE VEÍCULO";
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.Image = global::View.Properties.Resources.cancel32;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(498, 226);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(42, 46);
            this.btnCancelarCadastro.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCancelarCadastro, "Cancelar Cadastro do Veículo");
            this.btnCancelarCadastro.UseVisualStyleBackColor = true;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // btnFecharFormulario
            // 
            this.btnFecharFormulario.Image = global::View.Properties.Resources.exit32;
            this.btnFecharFormulario.Location = new System.Drawing.Point(546, 226);
            this.btnFecharFormulario.Name = "btnFecharFormulario";
            this.btnFecharFormulario.Size = new System.Drawing.Size(42, 46);
            this.btnFecharFormulario.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFecharFormulario, "Fechar Cadastro de Veículo");
            this.btnFecharFormulario.UseVisualStyleBackColor = true;
            this.btnFecharFormulario.Click += new System.EventHandler(this.btnFecharFormulario_Click);
            // 
            // VVeiculoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(617, 284);
            this.Controls.Add(this.btnFecharFormulario);
            this.Controls.Add(this.btnCancelarCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNomeProprietarioCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAnoModelo);
            this.Controls.Add(this.cbAnoFabricacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtxtRenavam);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAnoModelo);
            this.Controls.Add(this.lbAnoFabricacao);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.mtxtPlaca);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lRenavam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VVeiculoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículo";
            this.toolTip1.SetToolTip(this, "Cadastrar Veículo");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharformulario);
            this.Load += new System.EventHandler(this.VVeiculoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lRenavam;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.MaskedTextBox mtxtPlaca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbAnoFabricacao;
        private System.Windows.Forms.Label lbAnoModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtRenavam;
        private System.Windows.Forms.Button btnSalvar;
        private PreencherAnoCB cbAnoFabricacao;
        private PreencherAnoCB cbAnoModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNomeProprietarioCadastro;
        private System.Windows.Forms.BindingSource mPessoaBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnFecharFormulario;
    }
}