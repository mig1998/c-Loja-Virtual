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
    public partial class Cliente : Form
    {
       
         string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\LojaVirtual.mdf;Integrated Security=True";


        public Cliente()
        {
            InitializeComponent();
        }

        public Cliente(string Cpf, string Nome, string Email)
        {
            InitializeComponent();
            txtCpfCliente.Text = Cpf;
            txtNomeCliente.Text = Nome;
            txtEmailCliente.Text = Email;
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            Form login = new LojaVirtualCliente();
            Hide();
            login.ShowDialog();
            if (login.IsDisposed)
            {
                Close();
            }

        }


        private void imgMinimizarCliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void imgFecharCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void Cliente_Load(object sender, EventArgs e)
        {

          

            load_valorTotal();
            load_List();
            load_carrinho();

            // TODO: esta linha de código carrega dados na tabela 'lojaVirtualDataSet.Carrinho'. Você pode movê-la ou removê-la conforme necessário.
            this.carrinhoTableAdapter.Fill(this.lojaVirtualDataSet.Carrinho);
           
            // TODO: esta linha de código carrega dados na tabela 'lojaVirtualDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.lojaVirtualDataSet.Produtos);

        }


   



        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (txtIdProdutoCliente.Text==""||txtNomeProdutoCliente.Text==""||txtValorProdutoCliente.Text=="")
            {
                MessageBox.Show("Selecione um produto");
            }
            else {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();


                string valor = txtValorProdutoCliente.Text.Replace(',', '.');
               

                string sql = "insert into Carrinho values('" + txtIdProdutoCliente.Text + "','" + txtNomeProdutoCliente.Text + "','" +valor+ "','" + txtCpfCliente.Text + "')";

                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    load_carrinho();
                    load_valorTotal();

                    MessageBox.Show("produto inserido no carrinho com sucesso");


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



        private void btnRemoverCarrinho_Click(object sender, EventArgs e)
        {
            if (txtIdProdutoCarrinho.Text=="")
            {
                MessageBox.Show("Selecione um produto no carrinho!");
            }
            else
            {

                SqlConnection connection = new SqlConnection(conexao);

                if (connection.State != ConnectionState.Open) connection.Open();



                string sql = "delete from Carrinho where idProduto='"+txtIdProdutoCarrinho.Text+"'";


                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    int i=command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        load_carrinho();
                        load_valorTotal();

                        MessageBox.Show("produto Removido do carrinho com sucesso");
                    
                    }
                    else
                    {
                        MessageBox.Show("o produto nem esta no carrinho");

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



        private void btnComprarTudo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja realmente Comprar todos esses produtos?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)

            {
                MessageBox.Show("operacao cancelada");

            }
            else
            {
                MessageBox.Show("Compra Efetuada com Sucesso!");

            }
        
        }


        private void carrinhoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdProdutoCarrinho.Text = carrinhoDataGridView.CurrentRow.Cells[0].Value.ToString();

            }

            catch (Exception ex)
            {
                txtIdProdutoCarrinho.Text = "";
            }

        }



        private void produtosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdProdutoCliente.Text = produtosDataGridView.CurrentRow.Cells[0].Value.ToString();
                txtNomeProdutoCliente.Text = produtosDataGridView.CurrentRow.Cells[1].Value.ToString();
                txtValorProdutoCliente.Text = produtosDataGridView.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                txtIdProdutoCliente.Text = "";
                txtNomeProdutoCliente.Text = "";
                txtValorProdutoCliente.Text = "";
            }


        }



        private void load_List()
        {

            
            SqlConnection cn_connection = new SqlConnection(conexao);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
            string sql_Text = "SELECT * FROM Produtos";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            try
            {

                adapter.Fill(tbl);

                produtosDataGridView.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha ao carregar!" + ex);
            }
            finally
            {
                if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
            }




        }

        private void load_carrinho()
        {
            SqlConnection cn_connection = new SqlConnection(conexao);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sqlCarrinho = "SELECT * FROM Carrinho where Id_Cliente='"+txtCpfCliente.Text+"'";
            DataTable tblCarrinho = new DataTable();
            SqlDataAdapter adapterCarrinho = new SqlDataAdapter(sqlCarrinho, cn_connection);

            try
            {

                adapterCarrinho.Fill(tblCarrinho);

                carrinhoDataGridView.DataSource = tblCarrinho;
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha ao carregar carrinho!"+ex);
            }
            finally
            {
                if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
            }

        }



        private void load_valorTotal()
        {
            SqlConnection connection = new SqlConnection(conexao);

            if (connection.State != ConnectionState.Open) connection.Open();

            string sql = "select Sum(Valor) as Total from carrinho where Id_Cliente='" + txtCpfCliente.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader;

            try
            {
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtValorTotalCarrinho.Text = reader[0].ToString();

                }
                else
                {
                    txtValorTotalCarrinho.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
            finally
            {

                if (connection.State != ConnectionState.Closed) connection.Close();
            }
        }

      
    }

}