namespace Atv._04
{
    partial class MainForm
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
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnConsultaProdutos = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(229, 18);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(307, 31);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "Gerenciador de Estoque";
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Location = new System.Drawing.Point(113, 122);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(102, 52);
            this.btnCadastroProdutos.TabIndex = 1;
            this.btnCadastroProdutos.Text = "Cadastro\r\nde Produtos";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnConsultaProdutos
            // 
            this.btnConsultaProdutos.Location = new System.Drawing.Point(254, 122);
            this.btnConsultaProdutos.Name = "btnConsultaProdutos";
            this.btnConsultaProdutos.Size = new System.Drawing.Size(102, 52);
            this.btnConsultaProdutos.TabIndex = 2;
            this.btnConsultaProdutos.Text = "Consultar Produtos";
            this.btnConsultaProdutos.UseVisualStyleBackColor = true;
            this.btnConsultaProdutos.Click += new System.EventHandler(this.btnConsultaProdutos_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(394, 122);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(102, 52);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "Sobre o\r\nSistema";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(533, 122);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 52);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnConsultaProdutos);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "MainForm";
            this.Text = "Gerenciador de Estoque";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnConsultaProdutos;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
    }
}

