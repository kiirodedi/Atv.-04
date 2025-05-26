using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Atv._04
{
    public partial class CadastroForm : Form
    {
        private MySqlConnection objCnx;
        private MySqlCommand objCmd;
        private MySqlDataReader objDados;
        private string strSql;
        private string imagemCaminho = "";

        public event EventHandler DadosAlterados;
        protected virtual void OnDadosAlterados(EventArgs e)
        {
            DadosAlterados?.Invoke(this, e);
        }
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxUnidade_Enter(object sender, EventArgs e)
        {

        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx = new MySqlConnection("Server=localhost;Database=gerenciadorestoque;User=root;Pwd=@D3b0r42008");
                objCnx.Open();

                cboCategoria.Items.Add("Eletrônicos");
                cboCategoria.Items.Add("Alimentos");
                cboCategoria.Items.Add("Vestuário");
                cboCategoria.Items.Add("Limpeza");
                cboCategoria.SelectedIndex = 0;
                rbtUnidade.Checked = true;
                dtpValidade.Value = DateTime.Now;

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados no Cadastro de Produtos: " + Erro.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIncluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnLimpar.Enabled = false;
                btnCarregarImagem.Enabled = false;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open) { objCnx.Open(); }

                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Nome, Preço e Quantidade são campos obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal preco;
                int quantidade;
                if (!decimal.TryParse(txtPreco.Text, out preco))
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um número válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPreco.Focus();
                    return;
                }
                if (!int.TryParse(txtQuantidade.Text, out quantidade))
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantidade.Focus();
                    return;
                }

                string tipoUnidade = "";
                if (rbtUnidade.Checked) tipoUnidade = "Unidade";
                else if (rbtCaixa.Checked) tipoUnidade = "Caixa";
                else if (rbtLitro.Checked) tipoUnidade = "Litro";
                else if (rbtMetro.Checked) tipoUnidade = "Metro";

                byte[] imagemBytes = null;
                if (!string.IsNullOrEmpty(imagemCaminho))
                {
                    imagemBytes = File.ReadAllBytes(imagemCaminho);
                }

                strSql = "INSERT INTO produtos (nome, descricao, preco, quantidade, categoria, tipo_unidade, ativo, data_validade, imagem) " +
                         "VALUES (@nome, @descricao, @preco, @quantidade, @categoria, @tipoUnidade, @ativo, @dataValidade, @imagem)";

                objCmd = new MySqlCommand(strSql, objCnx);

                objCmd.Parameters.AddWithValue("@nome", txtNome.Text);
                objCmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                objCmd.Parameters.AddWithValue("@preco", preco);
                objCmd.Parameters.AddWithValue("@quantidade", quantidade);
                objCmd.Parameters.AddWithValue("@categoria", cboCategoria.SelectedItem.ToString());
                objCmd.Parameters.AddWithValue("@tipoUnidade", tipoUnidade);
                objCmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);
                objCmd.Parameters.AddWithValue("@dataValidade", dtpValidade.Value);
                objCmd.Parameters.AddWithValue("@imagem", (object)imagemBytes ?? DBNull.Value);

                objCmd.ExecuteNonQuery();

                MessageBox.Show("Produto incluído com sucesso!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnDadosAlterados(EventArgs.Empty);
                LimparCampos();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao incluir produto: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // A conexão permanece aberta
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open) { objCnx.Open(); }

                if (string.IsNullOrWhiteSpace(txtId.Text) && string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Por favor, digite o ID ou o Nome do produto para consultar.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                strSql = "SELECT id, nome, descricao, preco, quantidade, categoria, tipo_unidade, ativo, data_validade, imagem FROM produtos WHERE ";

                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    strSql += "id = @id";
                    objCmd = new MySqlCommand(strSql, objCnx);
                    objCmd.Parameters.AddWithValue("@id",txtId.Text);
                }
                else
                {
                    strSql += "nome LIKE @nome";
                    objCmd = new MySqlCommand(strSql, objCnx);
                    objCmd.Parameters.AddWithValue("@nome", "%" + txtNome.Text + "%");
                }

                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Produto não encontrado.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    objDados.Read();
                    txtId.Text = objDados["id"].ToString();
                    txtNome.Text = objDados["nome"].ToString();
                    txtDescricao.Text = objDados["descricao"].ToString();
                    txtPreco.Text = objDados["preco"].ToString();
                    txtQuantidade.Text = objDados["quantidade"].ToString();

                    cboCategoria.SelectedItem = objDados["categoria"].ToString();

                    string tipoUnidade = objDados["tipo_unidade"].ToString();
                    if (tipoUnidade == "Unidade") rbtUnidade.Checked = true;
                    else if (tipoUnidade == "Caixa") rbtCaixa.Checked = true;
                    else if (tipoUnidade == "Litro") rbtLitro.Checked = true;
                    else if (tipoUnidade == "Metro") rbtMetro.Checked = true;

                    chkAtivo.Checked = Convert.ToBoolean(objDados["ativo"]);

                    dtpValidade.Value = Convert.ToDateTime(objDados["data_validade"]);

                    if (objDados["imagem"] != DBNull.Value)
                    {
                        byte[] img = (byte[])objDados["imagem"];
                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            pbImagemProduto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbImagemProduto.Image = null;
                    }
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao consultar produto: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open) { objCnx.Open(); }

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, consulte um produto pelo ID antes de alterar.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Nome, Preço e Quantidade são campos obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal preco;
                int quantidade;
                if (!decimal.TryParse(txtPreco.Text, out preco))
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um número válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPreco.Focus();
                    return;
                }
                if (!int.TryParse(txtQuantidade.Text, out quantidade))
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantidade.Focus();
                    return;
                }

                string tipoUnidade = "";
                if (rbtUnidade.Checked) tipoUnidade = "Unidade";
                else if (rbtCaixa.Checked) tipoUnidade = "Caixa";
                else if (rbtLitro.Checked) tipoUnidade = "Litro";
                else if (rbtMetro.Checked) tipoUnidade = "Metro";

                byte[] imagemBytes = null;
                if (!string.IsNullOrEmpty(imagemCaminho))
                {
                    imagemBytes = File.ReadAllBytes(imagemCaminho);
                }
                else if (pbImagemProduto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagemProduto.Image.Save(ms, pbImagemProduto.Image.RawFormat);
                        imagemBytes = ms.ToArray();
                    }
                }

                strSql = "UPDATE produtos SET nome = @nome, descricao = @descricao, preco = @preco, quantidade = @quantidade, " +
                         "categoria = @categoria, tipo_unidade = @tipoUnidade, ativo = @ativo, data_validade = @dataValidade, imagem = @imagem " +
                         "WHERE id = @id";

                objCmd = new MySqlCommand(strSql, objCnx);
                objCmd.Parameters.AddWithValue("@id", txtId.Text);
                objCmd.Parameters.AddWithValue("@nome", txtNome.Text);
                objCmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                objCmd.Parameters.AddWithValue("@preco", preco);
                objCmd.Parameters.AddWithValue("@quantidade", quantidade);
                objCmd.Parameters.AddWithValue("@categoria", cboCategoria.SelectedItem.ToString());
                objCmd.Parameters.AddWithValue("@tipoUnidade", tipoUnidade);
                objCmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);
                objCmd.Parameters.AddWithValue("@dataValidade", dtpValidade.Value);
                objCmd.Parameters.AddWithValue("@imagem", (object)imagemBytes ?? DBNull.Value);

                int linhasAfetadas = objCmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto alterado com sucesso!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnDadosAlterados(EventArgs.Empty);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado para alteração.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao alterar produto: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            cboCategoria.SelectedIndex = 0;
            rbtUnidade.Checked = true;
            chkAtivo.Checked = false;
            dtpValidade.Value = DateTime.Now;
            pbImagemProduto.Image = null;
            imagemCaminho = "";
            txtNome.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open) { objCnx.Open(); }

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, consulte um produto pelo ID antes de alterar.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Nome, Preço e Quantidade são campos obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal preco;
                int quantidade;
                if (!decimal.TryParse(txtPreco.Text, out preco))
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um número válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPreco.Focus();
                    return;
                }
                if (!int.TryParse(txtQuantidade.Text, out quantidade))
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantidade.Focus();
                    return;
                }

                string tipoUnidade = "";
                if (rbtUnidade.Checked) tipoUnidade = "Unidade";
                else if (rbtCaixa.Checked) tipoUnidade = "Caixa";
                else if (rbtLitro.Checked) tipoUnidade = "Litro";
                else if (rbtMetro.Checked) tipoUnidade = "Metro";

                byte[] imagemBytes = null;
                if (!string.IsNullOrEmpty(imagemCaminho))
                {
                    imagemBytes = File.ReadAllBytes(imagemCaminho);
                }
                else if (pbImagemProduto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagemProduto.Image.Save(ms, pbImagemProduto.Image.RawFormat);
                        imagemBytes = ms.ToArray();
                    }
                }

                strSql = "UPDATE produtos SET nome = @nome, descricao = @descricao, preco = @preco, quantidade = @quantidade, " +
                         "categoria = @categoria, tipo_unidade = @tipoUnidade, ativo = @ativo, data_validade = @dataValidade, imagem = @imagem " +
                         "WHERE id = @id";

                objCmd = new MySqlCommand(strSql, objCnx);
                objCmd.Parameters.AddWithValue("@id", txtId.Text);
                objCmd.Parameters.AddWithValue("@nome", txtNome.Text);
                objCmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                objCmd.Parameters.AddWithValue("@preco", preco);
                objCmd.Parameters.AddWithValue("@quantidade", quantidade);
                objCmd.Parameters.AddWithValue("@categoria", cboCategoria.SelectedItem.ToString());
                objCmd.Parameters.AddWithValue("@tipoUnidade", tipoUnidade);
                objCmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);
                objCmd.Parameters.AddWithValue("@dataValidade", dtpValidade.Value);
                objCmd.Parameters.AddWithValue("@imagem", (object)imagemBytes ?? DBNull.Value);

                int linhasAfetadas = objCmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto alterado com sucesso!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnDadosAlterados(EventArgs.Empty);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado para alteração.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao alterar produto: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open) { objCnx.Open(); }

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, consulte um produto pelo ID antes de excluir.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    strSql = "DELETE FROM produtos WHERE id = @id";
                    objCmd = new MySqlCommand(strSql, objCnx);
                    objCmd.Parameters.AddWithValue("@id", txtId.Text);

                    int linhasAfetadas = objCmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnDadosAlterados(EventArgs.Empty);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado para exclusão.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao excluir produto: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagemCaminho = openFileDialog.FileName;
                pbImagemProduto.Image = Image.FromFile(imagemCaminho);
            }   
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (objCnx != null && objCnx.State == ConnectionState.Open)
            {
                objCnx.Close();
                objCnx.Dispose();
            }
            this.Close();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            ConsultaForm consultaForm = new ConsultaForm();
            this.DadosAlterados += consultaForm.AtualizarDataGridView;
            consultaForm.ShowDialog();
            this.DadosAlterados -= consultaForm.AtualizarDataGridView;
        }

        private void btnConsultarLista_Click(object sender, EventArgs e)
        {
            ConsultaForm consultaForm = new ConsultaForm(); // Cria a instância do formulário de lista
            this.DadosAlterados += consultaForm.AtualizarDataGridView; // Assina o evento para atualizar a lista
            consultaForm.ShowDialog(); // Abre o formulário de lista (modal)
            this.DadosAlterados -= consultaForm.AtualizarDataGridView; // Desassina o evento ao fechar
        }
    }
}
