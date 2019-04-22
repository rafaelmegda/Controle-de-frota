namespace View
{
    partial class VVeiculoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVeiculoEditar));
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.mtxtRenavamEditar = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFEditar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnoModelo = new System.Windows.Forms.Label();
            this.lbAnoFabricacao = new System.Windows.Forms.Label();
            this.txtModeloEditar = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.mtxtPlacaEditar = new System.Windows.Forms.MaskedTextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lRenavam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAnoModeloEditar = new View.PreencherAnoCB();
            this.cbAnoFabricacaoEditar = new View.PreencherAnoCB();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.Image = global::View.Properties.Resources.save32;
            this.btnSalvarEditar.Location = new System.Drawing.Point(470, 186);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(42, 46);
            this.btnSalvarEditar.TabIndex = 25;
            this.btnSalvarEditar.UseVisualStyleBackColor = true;
            this.btnSalvarEditar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mtxtRenavamEditar
            // 
            this.mtxtRenavamEditar.Enabled = false;
            this.mtxtRenavamEditar.Location = new System.Drawing.Point(113, 99);
            this.mtxtRenavamEditar.Mask = "00000000000";
            this.mtxtRenavamEditar.Name = "mtxtRenavamEditar";
            this.mtxtRenavamEditar.Size = new System.Drawing.Size(85, 20);
            this.mtxtRenavamEditar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtxtRenavamEditar, "RENAVAM Cadastrado");
            // 
            // mtxtCPFEditar
            // 
            this.mtxtCPFEditar.Enabled = false;
            this.mtxtCPFEditar.Location = new System.Drawing.Point(113, 65);
            this.mtxtCPFEditar.Mask = "000,000,000-00";
            this.mtxtCPFEditar.Name = "mtxtCPFEditar";
            this.mtxtCPFEditar.Size = new System.Drawing.Size(85, 20);
            this.mtxtCPFEditar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.mtxtCPFEditar, "CPF Cadastrado");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "CPF Pessoa";
            // 
            // lbAnoModelo
            // 
            this.lbAnoModelo.AutoSize = true;
            this.lbAnoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoModelo.Location = new System.Drawing.Point(262, 134);
            this.lbAnoModelo.Name = "lbAnoModelo";
            this.lbAnoModelo.Size = new System.Drawing.Size(116, 17);
            this.lbAnoModelo.TabIndex = 23;
            this.lbAnoModelo.Text = "Ano de Modelo";
            // 
            // lbAnoFabricacao
            // 
            this.lbAnoFabricacao.AutoSize = true;
            this.lbAnoFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoFabricacao.Location = new System.Drawing.Point(262, 100);
            this.lbAnoFabricacao.Name = "lbAnoFabricacao";
            this.lbAnoFabricacao.Size = new System.Drawing.Size(144, 17);
            this.lbAnoFabricacao.TabIndex = 22;
            this.lbAnoFabricacao.Text = "Ano de Fabricação";
            // 
            // txtModeloEditar
            // 
            this.txtModeloEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModeloEditar.Location = new System.Drawing.Point(328, 65);
            this.txtModeloEditar.MaxLength = 100;
            this.txtModeloEditar.Name = "txtModeloEditar";
            this.txtModeloEditar.Size = new System.Drawing.Size(184, 20);
            this.txtModeloEditar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtModeloEditar, "Alterar o Modelo do Veículo");
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(262, 68);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(60, 17);
            this.lbModelo.TabIndex = 21;
            this.lbModelo.Text = "Modelo";
            // 
            // mtxtPlacaEditar
            // 
            this.mtxtPlacaEditar.Location = new System.Drawing.Point(113, 135);
            this.mtxtPlacaEditar.Mask = "???-0000";
            this.mtxtPlacaEditar.Name = "mtxtPlacaEditar";
            this.mtxtPlacaEditar.Size = new System.Drawing.Size(56, 20);
            this.mtxtPlacaEditar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtxtPlacaEditar, "Alterar a Placa");
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(59, 134);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 17);
            this.lbPlaca.TabIndex = 18;
            this.lbPlaca.Text = "Placa";
            // 
            // lRenavam
            // 
            this.lRenavam.AutoSize = true;
            this.lRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRenavam.Location = new System.Drawing.Point(32, 99);
            this.lRenavam.Name = "lRenavam";
            this.lRenavam.Size = new System.Drawing.Size(75, 17);
            this.lRenavam.TabIndex = 15;
            this.lRenavam.Text = "Renavam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "EDITAR VEÍCULO";
            // 
            // cbAnoModeloEditar
            // 
            this.cbAnoModeloEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoModeloEditar.FormattingEnabled = true;
            this.cbAnoModeloEditar.Items.AddRange(new object[] {
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
            this.cbAnoModeloEditar.Location = new System.Drawing.Point(412, 134);
            this.cbAnoModeloEditar.Name = "cbAnoModeloEditar";
            this.cbAnoModeloEditar.Size = new System.Drawing.Size(100, 21);
            this.cbAnoModeloEditar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbAnoModeloEditar, "Alterar o Ano de Modelo");
            // 
            // cbAnoFabricacaoEditar
            // 
            this.cbAnoFabricacaoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoFabricacaoEditar.FormattingEnabled = true;
            this.cbAnoFabricacaoEditar.Items.AddRange(new object[] {
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
            this.cbAnoFabricacaoEditar.Location = new System.Drawing.Point(412, 99);
            this.cbAnoFabricacaoEditar.Name = "cbAnoFabricacaoEditar";
            this.cbAnoFabricacaoEditar.Size = new System.Drawing.Size(100, 21);
            this.cbAnoFabricacaoEditar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbAnoFabricacaoEditar, "Alterar o Ano de Fabricação");
            
            // 
            // VVeiculoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(533, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAnoModeloEditar);
            this.Controls.Add(this.cbAnoFabricacaoEditar);
            this.Controls.Add(this.btnSalvarEditar);
            this.Controls.Add(this.mtxtRenavamEditar);
            this.Controls.Add(this.mtxtCPFEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAnoModelo);
            this.Controls.Add(this.lbAnoFabricacao);
            this.Controls.Add(this.txtModeloEditar);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.mtxtPlacaEditar);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lRenavam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VVeiculoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Veículo";
            this.Load += new System.EventHandler(this.VVeiculoEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.MaskedTextBox mtxtRenavamEditar;
        private System.Windows.Forms.MaskedTextBox mtxtCPFEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAnoModelo;
        private System.Windows.Forms.Label lbAnoFabricacao;
        private System.Windows.Forms.TextBox txtModeloEditar;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.MaskedTextBox mtxtPlacaEditar;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lRenavam;
        private PreencherAnoCB cbAnoFabricacaoEditar;
        private PreencherAnoCB cbAnoModeloEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}