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

namespace Loja_Virtual.FormClient
{
    
    public partial class CadastrarCliente : Form
    {

    
      string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";


        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void imgMinimizarCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFecharCadastrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cBoxSenhaClienteCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (!cBoxSenhaClienteCadastro.Checked)
            {
                txtSenhaCadastroCliente.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenhaCadastroCliente.UseSystemPasswordChar = false;
            }

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

            if (txtCPFCadastroCliente.Text=="" || txtNomeCadastroCliente.Text=="" || txtEnderecoCadastroCliente.Text==""||txtBairroCadastroCliente.Text==""||txtEstadoCadastroCliente.Text==""||txtCidadeCadastroCliente.Text==""||txtCepCadastroCliente.Text==""||txtEmailCadastroCliente.Text==""||txtSenhaCadastroCliente.Text==""||txtTelefoneCadastroCliente.Text==""||txtNascimentoCadastroCliente.Text==""||txtCartaoCadastroCliente.Text=="")
            {
                MessageBox.Show("Não deixe nenhum Campo Vazio");

            }
            else {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();

                string Sql = "Insert into Cliente Values('" + txtCPFCadastroCliente.Text + "','" + txtNomeCadastroCliente.Text + "','" + txtEnderecoCadastroCliente.Text + "','" + txtBairroCadastroCliente.Text + "','" + txtEstadoCadastroCliente.Text + "','" + txtCidadeCadastroCliente.Text + "','" + txtCepCadastroCliente.Text + "','" + txtEmailCadastroCliente.Text + "','" + txtSenhaCadastroCliente.Text + "','" + txtTelefoneCadastroCliente.Text + "','" + txtNascimentoCadastroCliente.Text + "','" + txtCartaoCadastroCliente.Text + "')";

                SqlCommand command = new SqlCommand(Sql, connection);

                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO!");

                    //limpando caixas
                    txtCPFCadastroCliente.Clear();
                    txtCartaoCadastroCliente.Clear();
                    txtNascimentoCadastroCliente.Clear();

                    txtNomeCadastroCliente.Clear();


                    txtEnderecoCadastroCliente.Clear();
                    txtCidadeCadastroCliente.Clear();

                    txtBairroCadastroCliente.Clear();
                    txtCepCadastroCliente.Clear();

                    txtTelefoneCadastroCliente.Clear();

                    txtEmailCadastroCliente.Clear();
                    txtSenhaCadastroCliente.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro: " + ex);
                }

                finally
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }

            }


        }

        private void btnVoltarCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form loginCliente = new LojaVirtualCliente();
            Hide();
            loginCliente.ShowDialog();
            if (loginCliente.IsDisposed)
            {
                Close();
            }

        }

        private void btnLimparCadastrarCliente_Click(object sender, EventArgs e)
        {
            txtCPFCadastroCliente.Clear();
            txtCartaoCadastroCliente.Clear();
            txtNascimentoCadastroCliente.Clear();

            txtNomeCadastroCliente.Clear();


            txtEnderecoCadastroCliente.Clear();
            txtCidadeCadastroCliente.Clear();
        
            txtBairroCadastroCliente.Clear();
            txtCepCadastroCliente.Clear();

            txtTelefoneCadastroCliente.Clear();
            
            txtEmailCadastroCliente.Clear();
            txtSenhaCadastroCliente.Clear();
         
        }

        private void txtEstadoCadastroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCartaoCadastroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
