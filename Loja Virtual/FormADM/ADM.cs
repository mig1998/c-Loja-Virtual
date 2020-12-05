using Loja_Virtual.FormADM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Virtual
{
    public partial class ADM : Form
    {
       

        string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";



        public ADM()
        {
            InitializeComponent();
        }

        public ADM(string Cpf,string Email, string Nome)
        {
            InitializeComponent();

            txtCpfADM.Text = Cpf;
            txtEmailADM.Text = Email;
            txtNomeADM.Text = Nome;

        }

        private void imgMinimizarADM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void imgFecharADM_Click(object sender, EventArgs e)
        {
           
            Application.Exit();

        }

        private void btnSairADM_Click(object sender, EventArgs e)
        {
            Form loginADM = new lojaVirtualADM();
            Hide();
            loginADM.ShowDialog();
            if (loginADM.IsDisposed)
            {
                Close();
            }
        }

        private void btnFornecedorADM_Click(object sender, EventArgs e)
        {
            Form fornecedorADM = new FornecedorADM();
            Hide();
            fornecedorADM.ShowDialog();

            if (fornecedorADM.IsDisposed)
            {
                Close();
            }

        }

        private void btnProdutosADM_Click(object sender, EventArgs e)
        {
            Form produtoADM = new ProdutoADM();
            Hide();
            produtoADM.ShowDialog();

            if (produtoADM.IsDisposed)
            {
                Close();
            }

        }

        private void ADM_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conexao);

            if (connection.State != ConnectionState.Open) connection.Open();

            string SQL = "select * from Fornecedor";

            SqlCommand command = new SqlCommand(SQL, connection);

            SqlDataReader reader;

            try
            {
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    btnProdutosADM.Enabled = true;

                }
                else
                {
                    btnProdutosADM.Enabled = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("erro:" + ex);

            }



        }
    }
}
