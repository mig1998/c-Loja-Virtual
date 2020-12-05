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
    public partial class ProdutoADM : Form
    {

      

         string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";


        public ProdutoADM()
        {
            InitializeComponent();
        }

        private void imgFecharProdutoAdm_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void imgMinimizarProdutoADM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

    

        private void ProdutoADM_Load(object sender, EventArgs e)
        {

            load_List();

            // TODO: esta linha de código carrega dados na tabela 'lojaVirtualDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.lojaVirtualDataSet.Produtos);

        }

        private void txtIdProdutoADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
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

        private void txtPrecoUnitarioProdutoADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPrecoVendaProdutoADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdFornecedorProdutoADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }




        private void load_List()
        {

            //-< Database >
            SqlConnection cn_connection = new SqlConnection(conexao);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
            string sql_Text = "SELECT * FROM Produtos";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);


            try
            {
                adapter.Fill(tbl);
                //-</ Database >

                produtosDataGridView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao carregar dados!"+ex);
            }
            finally
            {
                if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
            }
        }

        private void btnInserirProdutoADM_Click(object sender, EventArgs e)
        {

            if (txtNomeProdutoADM.Text == "" || txtPrecoUnitarioProdutoADM.Text == "" || txtPrecoVendaProdutoADM.Text == "" || txtDescricaoProdutoADM.Text == "" || txtIdFornecedorProdutoADM.Text == "")
            {
                MessageBox.Show("Insira os Dados!");
            }

            else
            {
                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();



                string sql = "Insert into Produtos Values('" + txtNomeProdutoADM.Text + "','" + txtPrecoUnitarioProdutoADM.Text + "','" + txtPrecoVendaProdutoADM.Text + "','" + txtDescricaoProdutoADM.Text + "','" + txtIdFornecedorProdutoADM.Text + "') ";



                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Produto Inserido com Sucesso");

                        load_List();


                        txtNomeProdutoADM.Clear();
                        txtPrecoUnitarioProdutoADM.Clear();
                        txtPrecoVendaProdutoADM.Clear();
                        txtDescricaoProdutoADM.Clear();
                        txtIdFornecedorProdutoADM.Clear();
                        txtIdProdutoADM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("falha no banco!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro: talvez o Fornecedor não Exista!" + ex);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }

            }
        }


        private void btnEditarProdutoADM_Click(object sender, EventArgs e)
        {

            if (txtNomeProdutoADM.Text == "" || txtPrecoUnitarioProdutoADM.Text == "" || txtPrecoVendaProdutoADM.Text == "" || txtDescricaoProdutoADM.Text == "" || txtIdFornecedorProdutoADM.Text == "")
            {
                MessageBox.Show("Insira os Dados!");
            }
            else
            {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();



                string sql = "Update Produtos Set Nome='" + txtNomeProdutoADM.Text + "' where Id='" + txtIdProdutoADM.Text + "' ";
                sql += "Update Produtos Set precoUnitario='" + txtPrecoUnitarioProdutoADM.Text + "' where Id='" + txtIdProdutoADM.Text + "' ";
                sql += "Update Produtos Set precoVenda='" + txtPrecoVendaProdutoADM.Text + "' where Id='" + txtIdProdutoADM.Text + "' ";
                sql += "Update Produtos Set Id_Fornecedor='" + txtIdFornecedorProdutoADM.Text + "' where Id='" + txtIdProdutoADM.Text + "' ";



                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Produto Editado com Sucesso");

                        load_List();


                        txtNomeProdutoADM.Clear();
                        txtPrecoUnitarioProdutoADM.Clear();
                        txtPrecoVendaProdutoADM.Clear();
                        txtDescricaoProdutoADM.Clear();
                        txtIdFornecedorProdutoADM.Clear();
                        txtIdProdutoADM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Produto inexistente");
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



        private void btnDeletarProdutoADM_Click(object sender, EventArgs e)
        {
            if (txtIdProdutoADM.Text == "")
            {
                MessageBox.Show("Insira o idProduto!");
            }

            else
            {
                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();


                string sql = "delete from Produtos where Id='" + txtIdProdutoADM.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Produto Apagado com Sucesso");

                        load_List();


                        txtIdProdutoADM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Produto n existe");
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



        private void btnRefreshProdutoADM_Click(object sender, EventArgs e)
        {
            load_List();
        }
    }



}
