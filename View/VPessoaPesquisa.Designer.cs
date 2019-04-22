namespace View
{
    partial class VPessoaPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPessoaPesquisa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirPesquisaPessoa = new System.Windows.Forms.Button();
            this.btnEditarPesquisaPessoa = new System.Windows.Forms.Button();
            this.btnExcluirPesquisar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(49, 62);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCPF, "Digite o CPF");
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(205, 62);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Digite o Nome ");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mPessoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 274);
            this.dataGridView1.TabIndex = 6;
            // 
            // mPessoaBindingSource
            // 
            this.mPessoaBindingSource.DataSource = typeof(Model.MPessoa);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "PESQUISA DE PROPRIETÁRIO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::View.Properties.Resources.limpa32;
            this.btnLimpar.Location = new System.Drawing.Point(577, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(42, 46);
            this.btnLimpar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpar Pesquisa");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::View.Properties.Resources.exit32;
            this.btnSair.Location = new System.Drawing.Point(669, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 46);
            this.btnSair.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluirPesquisaPessoa
            // 
            this.btnExcluirPesquisaPessoa.Image = global::View.Properties.Resources.cancel32;
            this.btnExcluirPesquisaPessoa.Location = new System.Drawing.Point(621, 380);
            this.btnExcluirPesquisaPessoa.Name = "btnExcluirPesquisaPessoa";
            this.btnExcluirPesquisaPessoa.Size = new System.Drawing.Size(42, 46);
            this.btnExcluirPesquisaPessoa.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnExcluirPesquisaPessoa, "Cancelar Pesquisa");
            this.btnExcluirPesquisaPessoa.UseVisualStyleBackColor = true;
            this.btnExcluirPesquisaPessoa.Click += new System.EventHandler(this.btnExcluirPesquisaPessoa_Click);
            // 
            // btnEditarPesquisaPessoa
            // 
            this.btnEditarPesquisaPessoa.Image = global::View.Properties.Resources.editarPreto;
            this.btnEditarPesquisaPessoa.Location = new System.Drawing.Point(625, 48);
            this.btnEditarPesquisaPessoa.Name = "btnEditarPesquisaPessoa";
            this.btnEditarPesquisaPessoa.Size = new System.Drawing.Size(42, 46);
            this.btnEditarPesquisaPessoa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEditarPesquisaPessoa, "Editar Proprietário");
            this.btnEditarPesquisaPessoa.UseVisualStyleBackColor = true;
            this.btnEditarPesquisaPessoa.Click += new System.EventHandler(this.btnEditarPesquisaPessoa_Click);
            // 
            // btnExcluirPesquisar
            // 
            this.btnExcluirPesquisar.Image = global::View.Properties.Resources.Excluir_Pequeno;
            this.btnExcluirPesquisar.Location = new System.Drawing.Point(671, 48);
            this.btnExcluirPesquisar.Name = "btnExcluirPesquisar";
            this.btnExcluirPesquisar.Size = new System.Drawing.Size(41, 46);
            this.btnExcluirPesquisar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnExcluirPesquisar, "Excluir Proprietário");
            this.btnExcluirPesquisar.UseVisualStyleBackColor = true;
            this.btnExcluirPesquisar.Click += new System.EventHandler(this.btnExcluirPesquisar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::View.Properties.Resources.PesquisarPequeno;
            this.btnPesquisar.Location = new System.Drawing.Point(529, 48);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(42, 46);
            this.btnPesquisar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnPesquisar, "Pesquisa Proprietário");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.FillWeight = 20F;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 55F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Proprietário";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.FillWeight = 25F;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VPessoaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(723, 430);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirPesquisaPessoa);
            this.Controls.Add(this.btnEditarPesquisaPessoa);
            this.Controls.Add(this.btnExcluirPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPessoaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Proprietário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharfomulario);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mPessoaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluirPesquisar;
        private System.Windows.Forms.Button btnEditarPesquisaPessoa;
        private System.Windows.Forms.Button btnExcluirPesquisaPessoa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
    }
}