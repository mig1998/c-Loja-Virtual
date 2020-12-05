using Loja_Virtual.FormClient;
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
    public partial class LojaVirtualCliente : Form
    {
      

       string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";



        public LojaVirtualCliente()
        {
            InitializeComponent();
        }

        private void imgMinimizarLoginCliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFecharLoginCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnLoginCliente_Click(object sender, EventArgs e)
        {

            if (txtLoginCliente.Text == "" || txtSenhaCliente.Text == "")
            {
                MessageBox.Show("Voce deixou algum campo vazio!");
            }
            else
            {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();

                string sql = "select * from Cliente where Email='" + txtLoginCliente.Text + "' and Senha='" + txtSenhaCliente.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader;
                try
                {
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string cpf =reader[0].ToString();
                        string nome = reader[1].ToString();
                        string email = reader[7].ToString();


                        Form cliente = new Cliente(cpf,nome,email);
                        Hide();
                        cliente.ShowDialog();

                        if (cliente.IsDisposed)
                        {
                            Close();
                        }


                    }
                    else
                    {
                        MessageBox.Show("usuario não existe");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro:" + ex);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }








            }









          



        }



        private void btnCadastrarLoginCliente_Click(object sender, EventArgs e)
        {

            Form cadastrarCliente = new CadastrarCliente();
            Hide();
            cadastrarCliente.ShowDialog();
            if (cadastrarCliente.IsDisposed)
            {
                Close();
            }



        }



        private void btnVoltarHome2_Click(object sender, EventArgs e)
        {
            Form home = new HOME();
            Hide();
            home.ShowDialog();
            if (home.IsDisposed)
            {
                Close();
            }
        }

        private void cBoxSenhaLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (!cBoxSenhaLogin.Checked)
            {
                txtSenhaCliente.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenhaCliente.UseSystemPasswordChar = false;
            }
        }
    }
}
