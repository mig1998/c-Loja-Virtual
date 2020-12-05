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
    public partial class CadastrarADM : Form
    {
   
         string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";






        public CadastrarADM()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPFCadastrarADM.Clear();
            txtLoginCadastrarAdm.Clear();
            txtSenhaCadastrarAdm.Clear();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {




            if (txtCPFCadastrarADM.Text == "" || txtNomeCadastroADM.Text == "" || txtLoginCadastrarAdm.Text == "" || txtSenhaCadastrarAdm.Text == "")
            {
                MessageBox.Show("algum campo esta vazio! insira os dados");
            }


            else {

                SqlConnection sqlConnection = new SqlConnection(conexao);

                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string Sql = "Insert into ADM values('" + txtCPFCadastrarADM.Text + "','"+txtNomeCadastroADM.Text+"','" + txtLoginCadastrarAdm.Text + "','" + txtSenhaCadastrarAdm.Text + "')";

                SqlCommand command = new SqlCommand(Sql, sqlConnection);


                try
                {


                    command.ExecuteNonQuery();


                    MessageBox.Show("cadastrado ADM com sucesso!");

                    txtCPFCadastrarADM.Clear();
                    txtLoginCadastrarAdm.Clear();
                    txtSenhaCadastrarAdm.Clear();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro: " + ex);

                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
                }




            }




        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form lojaLogin = new lojaVirtualADM();
            Hide();
            lojaLogin.ShowDialog();
            if (lojaLogin.IsDisposed)
            {
                Close();
            }


        }

        private void cBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!cBoxSenha.Checked)
            {
                txtSenhaCadastrarAdm.UseSystemPasswordChar = true;

            }
            else
            {
                txtSenhaCadastrarAdm.UseSystemPasswordChar = false;
            }
        }

        private void imgMinimizarCadastrarADM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFecharCadastrarADM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCPFCadastrarADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
