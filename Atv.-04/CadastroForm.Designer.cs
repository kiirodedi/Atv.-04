namespace Atv._04
{
    partial class CadastroForm
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
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBoxAdicionais = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lblValidade = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.groupBoxUnidade = new System.Windows.Forms.GroupBox();
            this.rbtMetro = new System.Windows.Forms.RadioButton();
            this.rbtLitro = new System.Windows.Forms.RadioButton();
            this.rbtCaixa = new System.Windows.Forms.RadioButton();
            this.rbtUnidade = new System.Windows.Forms.RadioButton();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            this.groupBoxProduto.SuspendLayout();
            this.groupBoxAdicionais.SuspendLayout();
            this.groupBoxUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.txtQuantidade);
            this.groupBoxProduto.Controls.Add(this.lblQuantidade);
            this.groupBoxProduto.Controls.Add(this.txtPreco);
            this.groupBoxProduto.Controls.Add(this.lblPreco);
            this.groupBoxProduto.Controls.Add(this.txtDescricao);
            this.groupBoxProduto.Controls.Add(this.lblDescricao);
            this.groupBoxProduto.Controls.Add(this.txtNome);
            this.groupBoxProduto.Controls.Add(this.lblNome);
            this.groupBoxProduto.Controls.Add(this.txtId);
            this.groupBoxProduto.Controls.Add(this.lblId);
            this.groupBoxProduto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(475, 182);
            this.groupBoxProduto.TabIndex = 0;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Dados do Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(91, 142);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 9;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 145);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(64, 113);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(20, 116);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(84, 83);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(370, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 86);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(393, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(44, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // groupBoxAdicionais
            // 
            this.groupBoxAdicionais.Controls.Add(this.chkAtivo);
            this.groupBoxAdicionais.Controls.Add(this.lblAtivo);
            this.groupBoxAdicionais.Controls.Add(this.dtpValidade);
            this.groupBoxAdicionais.Controls.Add(this.lblValidade);
            this.groupBoxAdicionais.Controls.Add(this.cboCategoria);
            this.groupBoxAdicionais.Controls.Add(this.lblCategoria);
            this.groupBoxAdicionais.Location = new System.Drawing.Point(12, 200);
            this.groupBoxAdicionais.Name = "groupBoxAdicionais";
            this.groupBoxAdicionais.Size = new System.Drawing.Size(270, 126);
            this.groupBoxAdicionais.TabIndex = 1;
            this.groupBoxAdicionais.TabStop = false;
            this.groupBoxAdicionais.Text = "Informações Adicionais";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(57, 97);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(172, 17);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "Produto disponível para venda";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(17, 98);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 13;
            this.lblAtivo.Text = "Ativo:";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Location = new System.Drawing.Point(111, 61);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(142, 20);
            this.dtpValidade.TabIndex = 12;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(13, 67);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(92, 13);
            this.lblValidade.TabIndex = 10;
            this.lblValidade.Text = "Data de Validade:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(78, 30);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(175, 21);
            this.cboCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 33);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // groupBoxUnidade
            // 
            this.groupBoxUnidade.Controls.Add(this.rbtMetro);
            this.groupBoxUnidade.Controls.Add(this.rbtLitro);
            this.groupBoxUnidade.Controls.Add(this.rbtCaixa);
            this.groupBoxUnidade.Controls.Add(this.rbtUnidade);
            this.groupBoxUnidade.Location = new System.Drawing.Point(299, 210);
            this.groupBoxUnidade.Name = "groupBoxUnidade";
            this.groupBoxUnidade.Size = new System.Drawing.Size(188, 116);
            this.groupBoxUnidade.TabIndex = 2;
            this.groupBoxUnidade.TabStop = false;
            this.groupBoxUnidade.Text = "Tipo de Unidade";
            this.groupBoxUnidade.Enter += new System.EventHandler(this.groupBoxUnidade_Enter);
            // 
            // rbtMetro
            // 
            this.rbtMetro.AutoSize = true;
            this.rbtMetro.Location = new System.Drawing.Point(122, 79);
            this.rbtMetro.Name = "rbtMetro";
            this.rbtMetro.Size = new System.Drawing.Size(52, 17);
            this.rbtMetro.TabIndex = 3;
            this.rbtMetro.Text = "Metro";
            this.rbtMetro.UseVisualStyleBackColor = true;
            // 
            // rbtLitro
            // 
            this.rbtLitro.AutoSize = true;
            this.rbtLitro.Location = new System.Drawing.Point(122, 34);
            this.rbtLitro.Name = "rbtLitro";
            this.rbtLitro.Size = new System.Drawing.Size(45, 17);
            this.rbtLitro.TabIndex = 2;
            this.rbtLitro.Text = "Litro";
            this.rbtLitro.UseVisualStyleBackColor = true;
            // 
            // rbtCaixa
            // 
            this.rbtCaixa.AutoSize = true;
            this.rbtCaixa.Location = new System.Drawing.Point(16, 79);
            this.rbtCaixa.Name = "rbtCaixa";
            this.rbtCaixa.Size = new System.Drawing.Size(51, 17);
            this.rbtCaixa.TabIndex = 1;
            this.rbtCaixa.Text = "Caixa";
            this.rbtCaixa.UseVisualStyleBackColor = true;
            // 
            // rbtUnidade
            // 
            this.rbtUnidade.AutoSize = true;
            this.rbtUnidade.Checked = true;
            this.rbtUnidade.Location = new System.Drawing.Point(16, 34);
            this.rbtUnidade.Name = "rbtUnidade";
            this.rbtUnidade.Size = new System.Drawing.Size(65, 17);
            this.rbtUnidade.TabIndex = 0;
            this.rbtUnidade.TabStop = true;
            this.rbtUnidade.Text = "Unidade";
            this.rbtUnidade.UseVisualStyleBackColor = true;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Location = new System.Drawing.Point(549, 77);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(200, 200);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 3;
            this.pbImagemProduto.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(588, 283);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(130, 23);
            this.btnCarregarImagem.TabIndex = 4;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(143, 364);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 46);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(224, 364);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 46);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(305, 364);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 46);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(467, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 46);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(386, 364);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 46);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Location = new System.Drawing.Point(548, 364);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(117, 46);
            this.btnConsultarLista.TabIndex = 11;
            this.btnConsultarLista.Text = "Ver Lista";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.btnConsultarLista);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.groupBoxUnidade);
            this.Controls.Add(this.groupBoxAdicionais);
            this.Controls.Add(this.groupBoxProduto);
            this.Name = "CadastroForm";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            this.groupBoxAdicionais.ResumeLayout(false);
            this.groupBoxAdicionais.PerformLayout();
            this.groupBoxUnidade.ResumeLayout(false);
            this.groupBoxUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox groupBoxAdicionais;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.GroupBox groupBoxUnidade;
        private System.Windows.Forms.RadioButton rbtMetro;
        private System.Windows.Forms.RadioButton rbtLitro;
        private System.Windows.Forms.RadioButton rbtCaixa;
        private System.Windows.Forms.RadioButton rbtUnidade;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultarLista;
    }
}