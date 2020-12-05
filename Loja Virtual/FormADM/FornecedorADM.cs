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

namespace Loja_Virtual.FormADM
{
    public partial class FornecedorADM : Form
    {
     

        string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";
        

        public FornecedorADM()
        {
            InitializeComponent();
        }

        private void imgFecharFornecedorADM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizarFornecedorADM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FornecedorADM_Load(object sender, EventArgs e)
        {


            load_List();
            
            
            // TODO: esta linha de código carrega dados na tabela 'lojaVirtualDataSet1.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter1.Fill(this.lojaVirtualDataSet1.Fornecedor);

        }

        private void btnRefreshFornecedorADM_Click(object sender, EventArgs e)
        {
            load_List();
        }


        private void btnVoltarFornecedorADM_Click(object sender, EventArgs e)
        {
            Form adm = new ADM();
            Hide();
            adm.ShowDialog();
            if (adm.IsDisposed)
            {
                Close();
            }

        }




        private void btnInserirFornecedorADM_Click(object sender, EventArgs e)
        {

            if (txtNomeFornecedorADM.Text == "" || txtCnpjFornecedorADM.Text==""||txtTelefoneFornecedorADM.Text==""||txtEnderecoFornecedorADM.Text=="")
            {
                MessageBox.Show("Insira os dados!");
            }
            else {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();


                string sql = "Insert into Fornecedor Values('" + txtNomeFornecedorADM.Text + "','" + txtCnpjFornecedorADM.Text + "','" + txtTelefoneFornecedorADM.Text + "','" + txtEnderecoFornecedorADM.Text + "')";

                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor Inserido com Sucesso");

                    load_List();

                    txtNomeFornecedorADM.Clear();
                    txtCnpjFornecedorADM.Clear();
                    txtTelefoneFornecedorADM.Clear();
                    txtEnderecoFornecedorADM.Clear();

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

        private void btnEditarFornecedorADM_Click(object sender, EventArgs e)
        {
            

            if (txtNomeFornecedorADM.Text == "" || txtCnpjFornecedorADM.Text == "" || txtTelefoneFornecedorADM.Text == "" || txtEnderecoFornecedorADM.Text == "")
            {
                MessageBox.Show("Insira os Dados!");
            }
            else
            {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();



                string sql = "Update Fornecedor Set Nome='" + txtNomeFornecedorADM.Text + "' where IdFornecedor='" + txtIdFornecedorADM.Text + "' ";
                sql += "Update Fornecedor Set Nome='" + txtCnpjFornecedorADM.Text + "' where IdFornecedor='" + txtIdFornecedorADM.Text + "' ";
                sql += "Update Fornecedor Set Telefone='" + txtTelefoneFornecedorADM.Text + "' where IdFornecedor='" + txtIdFornecedorADM.Text + "' ";
                sql += "Update Fornecedor Set Endereco='" + txtEnderecoFornecedorADM.Text + "' where IdFornecedor='" + txtIdFornecedorADM.Text + "' ";



                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Fornecedor Editado com Sucesso");

                        load_List();


                        txtNomeFornecedorADM.Clear();
                        txtCnpjFornecedorADM.Clear();
                        txtTelefoneFornecedorADM.Clear();
                        txtEnderecoFornecedorADM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor inexistente");
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

        private void btnDeletarFornecedorADM_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedorADM.Text == "")
            {
                MessageBox.Show("Insira o idFornecedor!");
            }
          
            else
            {
                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();


                string sql = "delete from Fornecedor where idFornecedor='"+txtIdFornecedorADM.Text+"'";

                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Fornecedor Apagado com Sucesso");

                        load_List();


                        txtCnpjFornecedorADM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("fornecedor n existe");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro: Talvez contenha dados presentes de produtos!                 ;" + ex);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }

            }
        }




        private void load_List()
        {
           
                //-< Database >
                SqlConnection cn_connection = new SqlConnection(conexao);

                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                string sql_Text = "SELECT * FROM Fornecedor";
                DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            try
            {
                
                adapter.Fill(tbl);
                //-</ Database >

                fornecedorDataGridView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao carregar os dados:  "     +ex);
            }
            finally
            {
               
                if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
            }
     
        }

        private void txtIdFornecedorADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
