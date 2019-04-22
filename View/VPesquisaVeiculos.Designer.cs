namespace View
{
    partial class VPesquisaVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPesquisaVeiculos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisarVeiculo = new System.Windows.Forms.Button();
            this.mtxtRenavamPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.Label();
            this.mtxtPlacaPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.Modelo = new System.Windows.Forms.Label();
            this.txtModeloPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCPFPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluirPesquisa = new System.Windows.Forms.Button();
            this.btnEditarPesquisaVeiculo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.cbAnoFabricacaoPesquisa = new View.PreencherAnoCB();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pessoaCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENAVAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFabricacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessoaCPFDataGridViewTextBoxColumn,
            this.PessoaNome,
            this.rENAVAMDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoFabricacaoDataGridViewTextBoxColumn,
            this.AnoModelo});
            this.dataGridView1.DataSource = this.mVeiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 231);
            this.dataGridView1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dataGridView1, "Veículos Cadastrados");
            // 
            // mVeiculoBindingSource
            // 
            this.mVeiculoBindingSource.DataSource = typeof(Model.MVeiculo);
            // 
            // mPessoaBindingSource
            // 
            this.mPessoaBindingSource.DataSource = typeof(Model.MPessoa);
            // 
            // btnPesquisarVeiculo
            // 
            this.btnPesquisarVeiculo.Image = global::View.Properties.Resources.PesquisarPequeno;
            this.btnPesquisarVeiculo.Location = new System.Drawing.Point(472, 85);
            this.btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
            this.btnPesquisarVeiculo.Size = new System.Drawing.Size(42, 46);
            this.btnPesquisarVeiculo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnPesquisarVeiculo, "Pesquisar Veículo");
            this.btnPesquisarVeiculo.UseVisualStyleBackColor = true;
            this.btnPesquisarVeiculo.Click += new System.EventHandler(this.btnPesquisarVeiculo_Click);
            // 
            // mtxtRenavamPesquisa
            // 
            this.mtxtRenavamPesquisa.Location = new System.Drawing.Point(382, 55);
            this.mtxtRenavamPesquisa.Mask = "00000000000";
            this.mtxtRenavamPesquisa.Name = "mtxtRenavamPesquisa";
            this.mtxtRenavamPesquisa.Size = new System.Drawing.Size(73, 20);
            this.mtxtRenavamPesquisa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtxtRenavamPesquisa, "Digite o Renavam");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "RENAVAM";
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placa.Location = new System.Drawing.Point(20, 85);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(48, 17);
            this.Placa.TabIndex = 4;
            this.Placa.Text = "Placa";
            // 
            // mtxtPlacaPesquisa
            // 
            this.mtxtPlacaPesquisa.Location = new System.Drawing.Point(74, 82);
            this.mtxtPlacaPesquisa.Mask = "???-0000";
            this.mtxtPlacaPesquisa.Name = "mtxtPlacaPesquisa";
            this.mtxtPlacaPesquisa.Size = new System.Drawing.Size(54, 20);
            this.mtxtPlacaPesquisa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtxtPlacaPesquisa, "Digite a Placa");
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.Location = new System.Drawing.Point(8, 111);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(60, 17);
            this.Modelo.TabIndex = 6;
            this.Modelo.Text = "Modelo";
            // 
            // txtModeloPesquisa
            // 
            this.txtModeloPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModeloPesquisa.Location = new System.Drawing.Point(73, 111);
            this.txtModeloPesquisa.Name = "txtModeloPesquisa";
            this.txtModeloPesquisa.Size = new System.Drawing.Size(382, 20);
            this.txtModeloPesquisa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtModeloPesquisa, "Digite o Modelo");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ano de Fabricação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF";
            // 
            // mtxtCPFPesquisa
            // 
            this.mtxtCPFPesquisa.Location = new System.Drawing.Point(73, 56);
            this.mtxtCPFPesquisa.Mask = "000,000,000-00";
            this.mtxtCPFPesquisa.Name = "mtxtCPFPesquisa";
            this.mtxtCPFPesquisa.Size = new System.Drawing.Size(82, 20);
            this.mtxtCPFPesquisa.TabIndex = 0;
            this.toolTip1.SetToolTip(this.mtxtCPFPesquisa, "Digite o CPF");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "PESQUISA DE VEICULOS";
            // 
            // btnExcluirPesquisa
            // 
            this.btnExcluirPesquisa.Image = global::View.Properties.Resources.Excluir_Pequeno;
            this.btnExcluirPesquisa.Location = new System.Drawing.Point(651, 85);
            this.btnExcluirPesquisa.Name = "btnExcluirPesquisa";
            this.btnExcluirPesquisa.Size = new System.Drawing.Size(42, 46);
            this.btnExcluirPesquisa.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnExcluirPesquisa, "Excluir Veículo");
            this.btnExcluirPesquisa.UseVisualStyleBackColor = true;
            this.btnExcluirPesquisa.Click += new System.EventHandler(this.btnExcluirPesquisa_Click);
            // 
            // btnEditarPesquisaVeiculo
            // 
            this.btnEditarPesquisaVeiculo.Image = global::View.Properties.Resources.editarPreto;
            this.btnEditarPesquisaVeiculo.Location = new System.Drawing.Point(532, 85);
            this.btnEditarPesquisaVeiculo.Name = "btnEditarPesquisaVeiculo";
            this.btnEditarPesquisaVeiculo.Size = new System.Drawing.Size(42, 46);
            this.btnEditarPesquisaVeiculo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEditarPesquisaVeiculo, "Editar Veículo");
            this.btnEditarPesquisaVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarPesquisaVeiculo.Click += new System.EventHandler(this.btnEditarPesquisaVeiculo_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Image = global::View.Properties.Resources.limpa32;
            this.btnLimparPesquisa.Location = new System.Drawing.Point(592, 85);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(42, 46);
            this.btnLimparPesquisa.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLimparPesquisa, "Limpar Pesquisa");
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // cbAnoFabricacaoPesquisa
            // 
            this.cbAnoFabricacaoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoFabricacaoPesquisa.FormattingEnabled = true;
            this.cbAnoFabricacaoPesquisa.Items.AddRange(new object[] {
            "",
            2019,
            2018,
            2017,
            2016,
            2015,
            2014,
            2013,
            2012,
            2011,
            2010,
            2009,
            2008,
            2007,
            2006,
            2005,
            2004,
            2003,
            2002,
            2001,
            2000,
            1999,
            1998,
            1997,
            1996,
            1995,
            1994,
            1993,
            1992,
            1991,
            1990,
            1989,
            1988,
            1987,
            1986,
            1985,
            1984,
            1983,
            1982,
            1981,
            1980,
            1979,
            1978,
            1977,
            1976,
            1975,
            1974,
            1973,
            1972,
            1971,
            1970,
            1969,
            1968,
            1967,
            1966,
            1965,
            1964,
            1963,
            1962,
            1961,
            1960,
            1959,
            1958,
            1957,
            1956,
            1955,
            1954,
            1953,
            1952,
            1951,
            1950,
            1949,
            1948,
            1947,
            1946,
            1945,
            1944,
            1943,
            1942,
            1941,
            1940,
            1939,
            1938,
            1937,
            1936,
            1935,
            1934,
            1933,
            1932,
            1931,
            1930,
            1929,
            1928,
            1927,
            1926,
            1925,
            "",
            2019,
            2018,
            2017,
            2016,
            2015,
            2014,
            2013,
            2012,
            2011,
            2010,
            2009,
            2008,
            2007,
            2006,
            2005,
            2004,
            2003,
            2002,
            2001,
            2000,
            1999,
            1998,
            1997,
            1996,
            1995,
            1994,
            1993,
            1992,
            1991,
            1990,
            1989,
            1988,
            1987,
            1986,
            1985,
            1984,
            1983,
            1982,
            1981,
            1980,
            1979,
            1978,
            1977,
            1976,
            1975,
            1974,
            1973,
            1972,
            1971,
            1970,
            1969,
            1968,
            1967,
            1966,
            1965,
            1964,
            1963,
            1962,
            1961,
            1960,
            1959,
            1958,
            1957,
            1956,
            1955,
            1954,
            1953,
            1952,
            1951,
            1950,
            1949,
            1948,
            1947,
            1946,
            1945,
            1944,
            1943,
            1942,
            1941,
            1940,
            1939,
            1938,
            1937,
            1936,
            1935,
            1934,
            1933,
            1932,
            1931,
            1930,
            1929,
            1928,
            1927,
            1926,
            1925});
            this.cbAnoFabricacaoPesquisa.Location = new System.Drawing.Point(383, 81);
            this.cbAnoFabricacaoPesquisa.Name = "cbAnoFabricacaoPesquisa";
            this.cbAnoFabricacaoPesquisa.Size = new System.Drawing.Size(72, 21);
            this.cbAnoFabricacaoPesquisa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cbAnoFabricacaoPesquisa, "Selecione o Ano");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::View.Properties.Resources.cancel32;
            this.btnCancelar.Location = new System.Drawing.Point(592, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(42, 46);
            this.btnCancelar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Pesquisa");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::View.Properties.Resources.exit32;
            this.btnFechar.Location = new System.Drawing.Point(651, 374);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(42, 46);
            this.btnFechar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnFechar, "Fechar Pesquisa");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pessoaCPFDataGridViewTextBoxColumn
            // 
            this.pessoaCPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pessoaCPFDataGridViewTextBoxColumn.DataPropertyName = "PessoaCPF";
            this.pessoaCPFDataGridViewTextBoxColumn.FillWeight = 7F;
            this.pessoaCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.pessoaCPFDataGridViewTextBoxColumn.Name = "pessoaCPFDataGridViewTextBoxColumn";
            this.pessoaCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PessoaNome
            // 
            this.PessoaNome.DataPropertyName = "PessoaNome";
            this.PessoaNome.FillWeight = 70F;
            this.PessoaNome.HeaderText = "Proprietário";
            this.PessoaNome.Name = "PessoaNome";
            this.PessoaNome.ReadOnly = true;
            // 
            // rENAVAMDataGridViewTextBoxColumn
            // 
            this.rENAVAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENAVAMDataGridViewTextBoxColumn.DataPropertyName = "RENAVAM";
            this.rENAVAMDataGridViewTextBoxColumn.FillWeight = 6F;
            this.rENAVAMDataGridViewTextBoxColumn.HeaderText = "RENAVAM";
            this.rENAVAMDataGridViewTextBoxColumn.Name = "rENAVAMDataGridViewTextBoxColumn";
            this.rENAVAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.FillWeight = 6F;
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.FillWeight = 13F;
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoFabricacaoDataGridViewTextBoxColumn
            // 
            this.anoFabricacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoFabricacaoDataGridViewTextBoxColumn.DataPropertyName = "AnoFabricacao";
            this.anoFabricacaoDataGridViewTextBoxColumn.FillWeight = 6F;
            this.anoFabricacaoDataGridViewTextBoxColumn.HeaderText = "AnoFabricacao";
            this.anoFabricacaoDataGridViewTextBoxColumn.Name = "anoFabricacaoDataGridViewTextBoxColumn";
            this.anoFabricacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AnoModelo
            // 
            this.AnoModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnoModelo.DataPropertyName = "AnoModelo";
            this.AnoModelo.FillWeight = 5F;
            this.AnoModelo.HeaderText = "AnoModelo";
            this.AnoModelo.Name = "AnoModelo";
            this.AnoModelo.ReadOnly = true;
            // 
            // VPesquisaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(705, 429);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.cbAnoFabricacaoPesquisa);
            this.Controls.Add(this.btnEditarPesquisaVeiculo);
            this.Controls.Add(this.btnExcluirPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtCPFPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModeloPesquisa);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.mtxtPlacaPesquisa);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtRenavamPesquisa);
            this.Controls.Add(this.btnPesquisarVeiculo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPesquisaVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Veículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharformulario);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mVeiculoBindingSource;
        private System.Windows.Forms.BindingSource mPessoaBindingSource;
        private System.Windows.Forms.Button btnPesquisarVeiculo;
        private System.Windows.Forms.MaskedTextBox mtxtRenavamPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.MaskedTextBox mtxtPlacaPesquisa;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.TextBox txtModeloPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCPFPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluirPesquisa;
        private System.Windows.Forms.Button btnEditarPesquisaVeiculo;
        private PreencherAnoCB cbAnoFabricacaoPesquisa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENAVAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoFabricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoModelo;
    }
}