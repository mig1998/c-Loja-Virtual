namespace Loja_Virtual.FormClient
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgMinimizarCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgFecharCliente = new System.Windows.Forms.PictureBox();
            this.btnSairCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.Label();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaVirtualDataSet = new Loja_Virtual.LojaVirtualDataSet();
            this.txtIdProdutoCliente = new System.Windows.Forms.Label();
            this.txtNomeProdutoCliente = new System.Windows.Forms.Label();
            this.txtValorProdutoCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoverCarrinho = new System.Windows.Forms.Button();
            this.btnComprarTudo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotalCarrinho = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdProdutoCarrinho = new System.Windows.Forms.Label();
            this.carrinhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Loja_Virtual.LojaVirtualDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager();
            this.carrinhoTableAdapter = new Loja_Virtual.LojaVirtualDataSetTableAdapters.CarrinhoTableAdapter();
            this.carrinhoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMinimizarCliente
            // 
            this.imgMinimizarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarCliente.Image = global::Loja_Virtual.Properties.Resources.minimizar;
            this.imgMinimizarCliente.Location = new System.Drawing.Point(596, 5);
            this.imgMinimizarCliente.Name = "imgMinimizarCliente";
            this.imgMinimizarCliente.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarCliente.TabIndex = 1;
            this.imgMinimizarCliente.TabStop = false;
            this.imgMinimizarCliente.Click += new System.EventHandler(this.imgMinimizarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgFecharCliente
            // 
            this.imgFecharCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharCliente.Image = global::Loja_Virtual.Properties.Resources.fechar;
            this.imgFecharCliente.Location = new System.Drawing.Point(636, 5);
            this.imgFecharCliente.Name = "imgFecharCliente";
            this.imgFecharCliente.Size = new System.Drawing.Size(24, 24);
            this.imgFecharCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharCliente.TabIndex = 2;
            this.imgFecharCliente.TabStop = false;
            this.imgFecharCliente.Click += new System.EventHandler(this.imgFecharCliente_Click);
            // 
            // btnSairCliente
            // 
            this.btnSairCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSairCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCliente.Location = new System.Drawing.Point(583, 782);
            this.btnSairCliente.Name = "btnSairCliente";
            this.btnSairCliente.Size = new System.Drawing.Size(81, 37);
            this.btnSairCliente.TabIndex = 3;
            this.btnSairCliente.Text = "Sair";
            this.btnSairCliente.UseVisualStyleBackColor = false;
            this.btnSairCliente.Click += new System.EventHandler(this.btnSairCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.AutoSize = true;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNomeCliente.Location = new System.Drawing.Point(258, 52);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.txtNomeCliente.TabIndex = 9;
            this.txtNomeCliente.Text = "Nome:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.AutoSize = true;
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtEmailCliente.Location = new System.Drawing.Point(460, 52);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(35, 13);
            this.txtEmailCliente.TabIndex = 8;
            this.txtEmailCliente.Text = "Email:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.AutoSize = true;
            this.txtCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCpfCliente.Location = new System.Drawing.Point(99, 52);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(30, 13);
            this.txtCpfCliente.TabIndex = 7;
            this.txtCpfCliente.Text = "CPF:";
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Location = new System.Drawing.Point(145, 243);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(545, 220);
            this.produtosDataGridView.TabIndex = 10;
            this.produtosDataGridView.SelectionChanged += new System.EventHandler(this.produtosDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precoVenda";
            this.dataGridViewTextBoxColumn4.HeaderText = "precoVenda";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Fornecedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_Fornecedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.lojaVirtualDataSet;
            // 
            // lojaVirtualDataSet
            // 
            this.lojaVirtualDataSet.DataSetName = "LojaVirtualDataSet";
            this.lojaVirtualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdProdutoCliente
            // 
            this.txtIdProdutoCliente.AutoSize = true;
            this.txtIdProdutoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdutoCliente.Location = new System.Drawing.Point(258, 131);
            this.txtIdProdutoCliente.Name = "txtIdProdutoCliente";
            this.txtIdProdutoCliente.Size = new System.Drawing.Size(54, 13);
            this.txtIdProdutoCliente.TabIndex = 11;
            this.txtIdProdutoCliente.Text = "id produto";
            // 
            // txtNomeProdutoCliente
            // 
            this.txtNomeProdutoCliente.AutoSize = true;
            this.txtNomeProdutoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProdutoCliente.Location = new System.Drawing.Point(404, 131);
            this.txtNomeProdutoCliente.Name = "txtNomeProdutoCliente";
            this.txtNomeProdutoCliente.Size = new System.Drawing.Size(35, 13);
            this.txtNomeProdutoCliente.TabIndex = 12;
            this.txtNomeProdutoCliente.Text = "Nome";
            // 
            // txtValorProdutoCliente
            // 
            this.txtValorProdutoCliente.AutoSize = true;
            this.txtValorProdutoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProdutoCliente.Location = new System.Drawing.Point(581, 131);
            this.txtValorProdutoCliente.Name = "txtValorProdutoCliente";
            this.txtValorProdutoCliente.Size = new System.Drawing.Size(34, 13);
            this.txtValorProdutoCliente.TabIndex = 13;
            this.txtValorProdutoCliente.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "R$:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "IdProduto:";
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdicionarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(137, 169);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(159, 50);
            this.btnAdicionarCarrinho.TabIndex = 22;
            this.btnAdicionarCarrinho.Text = "Adicionar ao Carrinho";
            this.btnAdicionarCarrinho.UseVisualStyleBackColor = false;
            this.btnAdicionarCarrinho.Click += new System.EventHandler(this.btnAdicionarCarrinho_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "PRODUTOS";
            // 
            // btnRemoverCarrinho
            // 
            this.btnRemoverCarrinho.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoverCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCarrinho.Location = new System.Drawing.Point(19, 559);
            this.btnRemoverCarrinho.Name = "btnRemoverCarrinho";
            this.btnRemoverCarrinho.Size = new System.Drawing.Size(159, 50);
            this.btnRemoverCarrinho.TabIndex = 24;
            this.btnRemoverCarrinho.Text = "Remover do Carrinho";
            this.btnRemoverCarrinho.UseVisualStyleBackColor = false;
            this.btnRemoverCarrinho.Click += new System.EventHandler(this.btnRemoverCarrinho_Click);
            // 
            // btnComprarTudo
            // 
            this.btnComprarTudo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnComprarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarTudo.Location = new System.Drawing.Point(23, 690);
            this.btnComprarTudo.Name = "btnComprarTudo";
            this.btnComprarTudo.Size = new System.Drawing.Size(159, 50);
            this.btnComprarTudo.TabIndex = 25;
            this.btnComprarTudo.Text = "Comprar";
            this.btnComprarTudo.UseVisualStyleBackColor = false;
            this.btnComprarTudo.Click += new System.EventHandler(this.btnComprarTudo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "CARRINHO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "TOTAL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 674);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "R$:";
            // 
            // txtValorTotalCarrinho
            // 
            this.txtValorTotalCarrinho.AutoSize = true;
            this.txtValorTotalCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalCarrinho.ForeColor = System.Drawing.Color.DarkRed;
            this.txtValorTotalCarrinho.Location = new System.Drawing.Point(106, 674);
            this.txtValorTotalCarrinho.Name = "txtValorTotalCarrinho";
            this.txtValorTotalCarrinho.Size = new System.Drawing.Size(35, 13);
            this.txtValorTotalCarrinho.TabIndex = 29;
            this.txtValorTotalCarrinho.Text = "valor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "IdProduto:";
            // 
            // txtIdProdutoCarrinho
            // 
            this.txtIdProdutoCarrinho.AutoSize = true;
            this.txtIdProdutoCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdutoCarrinho.ForeColor = System.Drawing.Color.DarkRed;
            this.txtIdProdutoCarrinho.Location = new System.Drawing.Point(89, 542);
            this.txtIdProdutoCarrinho.Name = "txtIdProdutoCarrinho";
            this.txtIdProdutoCarrinho.Size = new System.Drawing.Size(10, 13);
            this.txtIdProdutoCarrinho.TabIndex = 30;
            this.txtIdProdutoCarrinho.Text = ".";
            // 
            // carrinhoBindingSource
            // 
            this.carrinhoBindingSource.DataMember = "Carrinho";
            this.carrinhoBindingSource.DataSource = this.lojaVirtualDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrinhoTableAdapter = this.carrinhoTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carrinhoTableAdapter
            // 
            this.carrinhoTableAdapter.ClearBeforeFill = true;
            // 
            // carrinhoDataGridView
            // 
            this.carrinhoDataGridView.AutoGenerateColumns = false;
            this.carrinhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carrinhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.carrinhoDataGridView.DataSource = this.carrinhoBindingSource;
            this.carrinhoDataGridView.Location = new System.Drawing.Point(261, 536);
            this.carrinhoDataGridView.Name = "carrinhoDataGridView";
            this.carrinhoDataGridView.Size = new System.Drawing.Size(437, 220);
            this.carrinhoDataGridView.TabIndex = 31;
            this.carrinhoDataGridView.SelectionChanged += new System.EventHandler(this.carrinhoDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_Cliente";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "*clicar no item da tabela de produtos e clicar em adicionar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-5, 520);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "*clicar no item na tabela do carrinho e clicar em remover";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 848);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.carrinhoDataGridView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdProdutoCarrinho);
            this.Controls.Add(this.txtValorTotalCarrinho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnComprarTudo);
            this.Controls.Add(this.btnRemoverCarrinho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdicionarCarrinho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorProdutoCliente);
            this.Controls.Add(this.txtNomeProdutoCliente);
            this.Controls.Add(this.txtIdProdutoCliente);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSairCliente);
            this.Controls.Add(this.imgFecharCliente);
            this.Controls.Add(this.imgMinimizarCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizarCliente;
        private System.Windows.Forms.PictureBox imgFecharCliente;
        private System.Windows.Forms.Button btnSairCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNomeCliente;
        private System.Windows.Forms.Label txtEmailCliente;
        private System.Windows.Forms.Label txtCpfCliente;
        private LojaVirtualDataSet lojaVirtualDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private LojaVirtualDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private LojaVirtualDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.Label txtIdProdutoCliente;
        private System.Windows.Forms.Label txtNomeProdutoCliente;
        private System.Windows.Forms.Label txtValorProdutoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private LojaVirtualDataSetTableAdapters.CarrinhoTableAdapter carrinhoTableAdapter;
        private System.Windows.Forms.Button btnAdicionarCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource carrinhoBindingSource;
        private System.Windows.Forms.Button btnRemoverCarrinho;
        private System.Windows.Forms.Button btnComprarTudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtValorTotalCarrinho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtIdProdutoCarrinho;
        private System.Windows.Forms.DataGridView carrinhoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}