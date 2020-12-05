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
    public partial class lojaVirtualADM : Form
    {
     

        string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";



        public lojaVirtualADM()
        {
            InitializeComponent();
     


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtLoginADM.Text==""||txtSenhaLoginAdm.Text=="")
            {
                MessageBox.Show("insira dados nos campos!");

            }
            else
            {
                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();

                string SQL = "select * from ADM where Login='"+txtLoginADM.Text+"' and senha='"+txtSenhaLoginAdm.Text+"'";

                SqlCommand command = new SqlCommand(SQL,connection);

                SqlDataReader reader;

                try
                {
                    reader=command.ExecuteReader();

                    if (reader.Read())
                    {
                        string Cpf =reader[1].ToString();
                        string Nome = reader[2].ToString() ;
                        string Email =reader[3].ToString();
                        Form adm = new ADM(Cpf,Nome,Email);
                        Hide();
                        adm.ShowDialog();

                        if (adm.IsDisposed)
                        {
                            Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("ADM não existe");
                    }

                

                }
                catch(Exception ex)
                {
                    MessageBox.Show("erro:"+ex);

                }

                finally
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }


            }

         

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form cadastrar = new CadastrarADM();
            Hide();
            cadastrar.ShowDialog();

            if (cadastrar.IsDisposed)
            {
                Close();
            }
        }



        private void btnVoltarHome_Click(object sender, EventArgs e)
        {
            Form home = new HOME();
            Hide();
            home.ShowDialog();

            if (home.IsDisposed)
            {
                Close();
            }
        
        }




        private void imgMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void imgFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void cBoxSenhaAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (!cBoxSenhaAdm.Checked)
            {
                txtSenhaLoginAdm.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenhaLoginAdm.UseSystemPasswordChar = false;
            }
        }
    }
}
