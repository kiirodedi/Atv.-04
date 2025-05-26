using MySql.Data.MySqlClient;
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

namespace Atv._04
{
    public partial class ConsultaForm : Form
    {
        private MySqlConnection objCnx;
        private MySqlDataAdapter objAdapter;
        private DataTable dtDados;
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void ConsultaForm_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx = new MySqlConnection("Server=localhost;Database=GerenciadorEstoque;User=root;Pwd=@D3b0r42008");
                objCnx.Open();

                objAdapter = new MySqlDataAdapter();
                dtDados = new DataTable();

                AtualizarDataGridView(null, EventArgs.Empty); // Chama a primeira atualização
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados no Consulta de Produtos: " + Erro.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvProdutos.Enabled = false;
            }
        }

        public void AtualizarDataGridView(object sender, EventArgs e)
        {
            try
            {
                if (objCnx.State != ConnectionState.Open)
                {
                    objCnx.Open();
                }

                dtDados.Clear();
                // dgvProdutos.Columns.Clear(); // Opcional

                string strSql = "SELECT id AS 'ID', nome AS 'Nome', descricao AS 'Descrição', preco AS 'Preço', " +
                                "quantidade AS 'Quantidade', categoria AS 'Categoria', tipo_unidade AS 'Unidade', " +
                                "ativo AS 'Ativo', data_validade AS 'Validade' FROM produtos";

                objAdapter.SelectCommand = new MySqlCommand(strSql, objCnx);

                objAdapter.Fill(dtDados);
                dgvProdutos.DataSource = dtDados;
                dgvProdutos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao carregar lista de produtos: " + Erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
