
namespace Loja_Virtual.FormADM
{
    partial class ProdutoADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoADM));
            this.imgFecharProdutoAdm = new System.Windows.Forms.PictureBox();
            this.imgMinimizarProdutoADM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdFornecedorProdutoADM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltarFornecedorADM = new System.Windows.Forms.Button();
            this.btnRefreshFornecedorADM = new System.Windows.Forms.Button();
            this.btnDeletarProdutoADM = new System.Windows.Forms.Button();
            this.btnEditarProdutoADM = new System.Windows.Forms.Button();
            this.btnInserirProdutoADM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFornecedorADM = new System.Windows.Forms.TextBox();
            this.lojaVirtualDataSet = new Loja_Virtual.LojaVirtualDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Loja_Virtual.LojaVirtualDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager();
            this.txtNomeProdutoADM = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescricaoProdutoADM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecoUnitarioProdutoADM = new System.Windows.Forms.TextBox();
            this.txtPrecoVendaProdutoADM = new System.Windows.Forms.TextBox();
            this.txtIdProdutoADM = new System.Windows.Forms.TextBox();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharProdutoAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarProdutoADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFecharProdutoAdm
            // 
            this.imgFecharProdutoAdm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharProdutoAdm.Image = ((System.Drawing.Image)(resources.GetObject("imgFecharProdutoAdm.Image")));
            this.imgFecharProdutoAdm.Location = new System.Drawing.Point(850, 7);
            this.imgFecharProdutoAdm.Name = "imgFecharProdutoAdm";
            this.imgFecharProdutoAdm.Size = new System.Drawing.Size(24, 24);
            this.imgFecharProdutoAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharProdutoAdm.TabIndex = 2;
            this.imgFecharProdutoAdm.TabStop = false;
            this.imgFecharProdutoAdm.Click += new System.EventHandler(this.imgFecharProdutoAdm_Click);
            // 
            // imgMinimizarProdutoADM
            // 
            this.imgMinimizarProdutoADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarProdutoADM.Image = ((System.Drawing.Image)(resources.GetObject("imgMinimizarProdutoADM.Image")));
            this.imgMinimizarProdutoADM.Location = new System.Drawing.Point(785, 7);
            this.imgMinimizarProdutoADM.Name = "imgMinimizarProdutoADM";
            this.imgMinimizarProdutoADM.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarProdutoADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarProdutoADM.TabIndex = 1;
            this.imgMinimizarProdutoADM.TabStop = false;
            this.imgMinimizarProdutoADM.Click += new System.EventHandler(this.imgMinimizarProdutoADM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "idProduto necessario apenas em editar e deletar.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "idFornecedor:";
            // 
            // txtIdFornecedorProdutoADM
            // 
            this.txtIdFornecedorProdutoADM.Location = new System.Drawing.Point(11, 222);
            this.txtIdFornecedorProdutoADM.MaxLength = 10;
            this.txtIdFornecedorProdutoADM.Name = "txtIdFornecedorProdutoADM";
            this.txtIdFornecedorProdutoADM.Size = new System.Drawing.Size(226, 20);
            this.txtIdFornecedorProdutoADM.TabIndex = 44;
            this.txtIdFornecedorProdutoADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdFornecedorProdutoADM_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = " apenas digite da mesma maneira que esta registrado.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = " se deseja que algum dado se mantenha,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "*Para deletar so precisar preencher o campo idProduto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "*Para editar precisa preencher todos os dados";
            // 
            // btnVoltarFornecedorADM
            // 
            this.btnVoltarFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltarFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarFornecedorADM.Location = new System.Drawing.Point(0, 495);
            this.btnVoltarFornecedorADM.Name = "btnVoltarFornecedorADM";
            this.btnVoltarFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnVoltarFornecedorADM.TabIndex = 38;
            this.btnVoltarFornecedorADM.Text = "Voltar";
            this.btnVoltarFornecedorADM.UseVisualStyleBackColor = false;
            this.btnVoltarFornecedorADM.Click += new System.EventHandler(this.btnVoltarFornecedorADM_Click);
            // 
            // btnRefreshFornecedorADM
            // 
            this.btnRefreshFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefreshFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshFornecedorADM.Location = new System.Drawing.Point(125, 289);
            this.btnRefreshFornecedorADM.Name = "btnRefreshFornecedorADM";
            this.btnRefreshFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnRefreshFornecedorADM.TabIndex = 36;
            this.btnRefreshFornecedorADM.Text = "Atualizar";
            this.btnRefreshFornecedorADM.UseVisualStyleBackColor = false;
            this.btnRefreshFornecedorADM.Click += new System.EventHandler(this.btnRefreshProdutoADM_Click);
            // 
            // btnDeletarProdutoADM
            // 
            this.btnDeletarProdutoADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletarProdutoADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarProdutoADM.Location = new System.Drawing.Point(125, 341);
            this.btnDeletarProdutoADM.Name = "btnDeletarProdutoADM";
            this.btnDeletarProdutoADM.Size = new System.Drawing.Size(109, 46);
            this.btnDeletarProdutoADM.TabIndex = 35;
            this.btnDeletarProdutoADM.Text = "Deletar";
            this.btnDeletarProdutoADM.UseVisualStyleBackColor = false;
            this.btnDeletarProdutoADM.Click += new System.EventHandler(this.btnDeletarProdutoADM_Click);
            // 
            // btnEditarProdutoADM
            // 
            this.btnEditarProdutoADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarProdutoADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProdutoADM.Location = new System.Drawing.Point(11, 341);
            this.btnEditarProdutoADM.Name = "btnEditarProdutoADM";
            this.btnEditarProdutoADM.Size = new System.Drawing.Size(109, 46);
            this.btnEditarProdutoADM.TabIndex = 34;
            this.btnEditarProdutoADM.Text = "Editar";
            this.btnEditarProdutoADM.UseVisualStyleBackColor = false;
            this.btnEditarProdutoADM.Click += new System.EventHandler(this.btnEditarProdutoADM_Click);
            // 
            // btnInserirProdutoADM
            // 
            this.btnInserirProdutoADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInserirProdutoADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProdutoADM.Location = new System.Drawing.Point(10, 289);
            this.btnInserirProdutoADM.Name = "btnInserirProdutoADM";
            this.btnInserirProdutoADM.Size = new System.Drawing.Size(109, 46);
            this.btnInserirProdutoADM.TabIndex = 33;
            this.btnInserirProdutoADM.Text = "Inserir";
            this.btnInserirProdutoADM.UseVisualStyleBackColor = false;
            this.btnInserirProdutoADM.Click += new System.EventHandler(this.btnInserirProdutoADM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, -39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome:";
            // 
            // txtNomeFornecedorADM
            // 
            this.txtNomeFornecedorADM.Location = new System.Drawing.Point(12, -19);
            this.txtNomeFornecedorADM.MaxLength = 15;
            this.txtNomeFornecedorADM.Name = "txtNomeFornecedorADM";
            this.txtNomeFornecedorADM.Size = new System.Drawing.Size(224, 20);
            this.txtNomeFornecedorADM.TabIndex = 26;
            // 
            // lojaVirtualDataSet
            // 
            this.lojaVirtualDataSet.DataSetName = "LojaVirtualDataSet";
            this.lojaVirtualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.lojaVirtualDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrinhoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNomeProdutoADM
            // 
            this.txtNomeProdutoADM.Location = new System.Drawing.Point(10, 67);
            this.txtNomeProdutoADM.MaxLength = 25;
            this.txtNomeProdutoADM.Name = "txtNomeProdutoADM";
            this.txtNomeProdutoADM.Size = new System.Drawing.Size(224, 20);
            this.txtNomeProdutoADM.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Preço Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Preço Venda:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Descrição";
            // 
            // txtDescricaoProdutoADM
            // 
            this.txtDescricaoProdutoADM.Location = new System.Drawing.Point(13, 187);
            this.txtDescricaoProdutoADM.MaxLength = 25;
            this.txtDescricaoProdutoADM.Name = "txtDescricaoProdutoADM";
            this.txtDescricaoProdutoADM.Size = new System.Drawing.Size(224, 20);
            this.txtDescricaoProdutoADM.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "idProduto:";
            // 
            // txtPrecoUnitarioProdutoADM
            // 
            this.txtPrecoUnitarioProdutoADM.Location = new System.Drawing.Point(13, 109);
            this.txtPrecoUnitarioProdutoADM.MaxLength = 25;
            this.txtPrecoUnitarioProdutoADM.Name = "txtPrecoUnitarioProdutoADM";
            this.txtPrecoUnitarioProdutoADM.Size = new System.Drawing.Size(224, 20);
            this.txtPrecoUnitarioProdutoADM.TabIndex = 48;
            this.txtPrecoUnitarioProdutoADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitarioProdutoADM_KeyPress);
            // 
            // txtPrecoVendaProdutoADM
            // 
            this.txtPrecoVendaProdutoADM.Location = new System.Drawing.Point(13, 148);
            this.txtPrecoVendaProdutoADM.MaxLength = 25;
            this.txtPrecoVendaProdutoADM.Name = "txtPrecoVendaProdutoADM";
            this.txtPrecoVendaProdutoADM.Size = new System.Drawing.Size(224, 20);
            this.txtPrecoVendaProdutoADM.TabIndex = 50;
            this.txtPrecoVendaProdutoADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVendaProdutoADM_KeyPress);
            // 
            // txtIdProdutoADM
            // 
            this.txtIdProdutoADM.Location = new System.Drawing.Point(10, 263);
            this.txtIdProdutoADM.MaxLength = 10;
            this.txtIdProdutoADM.Name = "txtIdProdutoADM";
            this.txtIdProdutoADM.Size = new System.Drawing.Size(75, 20);
            this.txtIdProdutoADM.TabIndex = 54;
            this.txtIdProdutoADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProdutoADM_KeyPress);
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Location = new System.Drawing.Point(270, 51);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(642, 473);
            this.produtosDataGridView.TabIndex = 55;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precoUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "precoUnitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // ProdutoADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdProdutoADM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescricaoProdutoADM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecoVendaProdutoADM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecoUnitarioProdutoADM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdFornecedorProdutoADM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltarFornecedorADM);
            this.Controls.Add(this.btnRefreshFornecedorADM);
            this.Controls.Add(this.btnDeletarProdutoADM);
            this.Controls.Add(this.btnEditarProdutoADM);
            this.Controls.Add(this.btnInserirProdutoADM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProdutoADM);
            this.Controls.Add(this.txtNomeFornecedorADM);
            this.Controls.Add(this.imgFecharProdutoAdm);
            this.Controls.Add(this.imgMinimizarProdutoADM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutoADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoADM";
            this.Load += new System.EventHandler(this.ProdutoADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharProdutoAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarProdutoADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizarProdutoADM;
        private System.Windows.Forms.PictureBox imgFecharProdutoAdm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdFornecedorProdutoADM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltarFornecedorADM;
        private System.Windows.Forms.Button btnRefreshFornecedorADM;
        private System.Windows.Forms.Button btnDeletarProdutoADM;
        private System.Windows.Forms.Button btnEditarProdutoADM;
        private System.Windows.Forms.Button btnInserirProdutoADM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFornecedorADM;
        private LojaVirtualDataSet lojaVirtualDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private LojaVirtualDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private LojaVirtualDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNomeProdutoADM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescricaoProdutoADM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecoUnitarioProdutoADM;
        private System.Windows.Forms.TextBox txtPrecoVendaProdutoADM;
        private System.Windows.Forms.TextBox txtIdProdutoADM;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}