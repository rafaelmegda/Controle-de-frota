namespace View
{
    partial class VPessoaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPessoaCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTipCadastroPessoa = new System.Windows.Forms.ToolTip(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFecharCadastroUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(119, 61);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.toolTipCadastroPessoa.SetToolTip(this.txtCPF, "Inserir CPF ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(119, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 20);
            this.txtNome.TabIndex = 2;
            this.toolTipCadastroPessoa.SetToolTip(this.txtNome, "Digite o Nome");
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(119, 113);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 3;
            this.toolTipCadastroPessoa.SetToolTip(this.txtDataNascimento, "Informe a Data de Nascimento");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nascimento";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::View.Properties.Resources.exit32;
            this.btnSair.Location = new System.Drawing.Point(457, 153);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 46);
            this.btnSair.TabIndex = 6;
            this.toolTipCadastroPessoa.SetToolTip(this.btnSair, "Sair ");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFecharCadastroUsuario
            // 
            this.btnFecharCadastroUsuario.Image = global::View.Properties.Resources.cancel32;
            this.btnFecharCadastroUsuario.Location = new System.Drawing.Point(409, 153);
            this.btnFecharCadastroUsuario.Name = "btnFecharCadastroUsuario";
            this.btnFecharCadastroUsuario.Size = new System.Drawing.Size(42, 46);
            this.btnFecharCadastroUsuario.TabIndex = 5;
            this.toolTipCadastroPessoa.SetToolTip(this.btnFecharCadastroUsuario, "Cancelar Cadastro");
            this.btnFecharCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnFecharCadastroUsuario.Click += new System.EventHandler(this.btnFecharCadastroUsuario_Click);
            // 
            // button1
            // 
            this.button1.Image = global::View.Properties.Resources.save32;
            this.button1.Location = new System.Drawing.Point(361, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 46);
            this.button1.TabIndex = 4;
            this.toolTipCadastroPessoa.SetToolTip(this.button1, "Salvar Proprietário");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "CADASTRO DE PROPRIETÁRIO";
            // 
            // VPessoaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(511, 213);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFecharCadastroUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPessoaCadastro";
            this.Text = "Cadastro de Proprietário";
            this.toolTipCadastroPessoa.SetToolTip(this, "Opção para Cadastro de Novo Proprietário");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharformulario);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipCadastroPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFecharCadastroUsuario;
        private System.Windows.Forms.Button btnSair;
    }
}