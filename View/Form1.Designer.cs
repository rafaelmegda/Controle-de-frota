namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastroVeiculos = new System.Windows.Forms.Button();
            this.btnPesquisaVeiculos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::View.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.button1.Location = new System.Drawing.Point(28, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 135);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Adicionar Usuário");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.AccessibleName = "";
            this.button2.Image = global::View.Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            this.button2.Location = new System.Drawing.Point(269, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 135);
            this.button2.TabIndex = 1;
            this.button2.Tag = "";
            this.toolTip1.SetToolTip(this.button2, "Pesquisar Usuário");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastroVeiculos
            // 
            this.btnCadastroVeiculos.Image = global::View.Properties.Resources.AdicionarCarro;
            this.btnCadastroVeiculos.Location = new System.Drawing.Point(28, 260);
            this.btnCadastroVeiculos.Name = "btnCadastroVeiculos";
            this.btnCadastroVeiculos.Size = new System.Drawing.Size(217, 135);
            this.btnCadastroVeiculos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCadastroVeiculos, "Adicionar Veículo");
            this.btnCadastroVeiculos.UseVisualStyleBackColor = true;
            this.btnCadastroVeiculos.Click += new System.EventHandler(this.btnCadastroVeiculos_Click);
            // 
            // btnPesquisaVeiculos
            // 
            this.btnPesquisaVeiculos.Image = global::View.Properties.Resources.pesquisaCarro;
            this.btnPesquisaVeiculos.Location = new System.Drawing.Point(269, 260);
            this.btnPesquisaVeiculos.Name = "btnPesquisaVeiculos";
            this.btnPesquisaVeiculos.Size = new System.Drawing.Size(217, 135);
            this.btnPesquisaVeiculos.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPesquisaVeiculos, "Pesquisar Veículo");
            this.btnPesquisaVeiculos.UseVisualStyleBackColor = true;
            this.btnPesquisaVeiculos.Click += new System.EventHandler(this.btnPesquisaVeiculos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::View.Properties.Resources.exit32;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(434, 430);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 56);
            this.btnSair.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar Sistema");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(511, 513);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisaVeiculos);
            this.Controls.Add(this.btnCadastroVeiculos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharFomulario);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastroVeiculos;
        private System.Windows.Forms.Button btnPesquisaVeiculos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

