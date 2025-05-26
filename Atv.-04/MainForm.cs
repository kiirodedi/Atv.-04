using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv._04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.ShowDialog();
        }

        private void btnConsultaProdutos_Click(object sender, EventArgs e)
        {
            ConsultaForm consultaForm = new ConsultaForm();
            consultaForm.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            SobreForm sobreForm = new SobreForm();
            sobreForm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
