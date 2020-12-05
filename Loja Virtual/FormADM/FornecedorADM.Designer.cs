
namespace Loja_Virtual.FormADM
{
    partial class FornecedorADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorADM));
            this.imgFecharFornecedorADM = new System.Windows.Forms.PictureBox();
            this.imgMinimizarFornecedorADM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeFornecedorADM = new System.Windows.Forms.TextBox();
            this.txtEnderecoFornecedorADM = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedorADM = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInserirFornecedorADM = new System.Windows.Forms.Button();
            this.btnEditarFornecedorADM = new System.Windows.Forms.Button();
            this.btnDeletarFornecedorADM = new System.Windows.Forms.Button();
            this.btnRefreshFornecedorADM = new System.Windows.Forms.Button();
            this.txtCnpjFornecedorADM = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltarFornecedorADM = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdFornecedorADM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lojaVirtualDataSet1 = new Loja_Virtual.LojaVirtualDataSet();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter1 = new Loja_Virtual.LojaVirtualDataSetTableAdapters.FornecedorTableAdapter();
            this.tableAdapterManager1 = new Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager();
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharFornecedorADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarFornecedorADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFecharFornecedorADM
            // 
            this.imgFecharFornecedorADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharFornecedorADM.Image = ((System.Drawing.Image)(resources.GetObject("imgFecharFornecedorADM.Image")));
            this.imgFecharFornecedorADM.Location = new System.Drawing.Point(738, 6);
            this.imgFecharFornecedorADM.Name = "imgFecharFornecedorADM";
            this.imgFecharFornecedorADM.Size = new System.Drawing.Size(24, 24);
            this.imgFecharFornecedorADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharFornecedorADM.TabIndex = 2;
            this.imgFecharFornecedorADM.TabStop = false;
            this.imgFecharFornecedorADM.Click += new System.EventHandler(this.imgFecharFornecedorADM_Click);
            // 
            // imgMinimizarFornecedorADM
            // 
            this.imgMinimizarFornecedorADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarFornecedorADM.Image = ((System.Drawing.Image)(resources.GetObject("imgMinimizarFornecedorADM.Image")));
            this.imgMinimizarFornecedorADM.Location = new System.Drawing.Point(686, 6);
            this.imgMinimizarFornecedorADM.Name = "imgMinimizarFornecedorADM";
            this.imgMinimizarFornecedorADM.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarFornecedorADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarFornecedorADM.TabIndex = 1;
            this.imgMinimizarFornecedorADM.TabStop = false;
            this.imgMinimizarFornecedorADM.Click += new System.EventHandler(this.imgMinimizarFornecedorADM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomeFornecedorADM
            // 
            this.txtNomeFornecedorADM.Location = new System.Drawing.Point(12, 61);
            this.txtNomeFornecedorADM.MaxLength = 15;
            this.txtNomeFornecedorADM.Name = "txtNomeFornecedorADM";
            this.txtNomeFornecedorADM.Size = new System.Drawing.Size(224, 20);
            this.txtNomeFornecedorADM.TabIndex = 3;
            // 
            // txtEnderecoFornecedorADM
            // 
            this.txtEnderecoFornecedorADM.Location = new System.Drawing.Point(12, 216);
            this.txtEnderecoFornecedorADM.MaxLength = 25;
            this.txtEnderecoFornecedorADM.Name = "txtEnderecoFornecedorADM";
            this.txtEnderecoFornecedorADM.Size = new System.Drawing.Size(224, 20);
            this.txtEnderecoFornecedorADM.TabIndex = 4;
            // 
            // txtTelefoneFornecedorADM
            // 
            this.txtTelefoneFornecedorADM.Location = new System.Drawing.Point(12, 167);
            this.txtTelefoneFornecedorADM.Mask = "(99) 00000-0000";
            this.txtTelefoneFornecedorADM.Name = "txtTelefoneFornecedorADM";
            this.txtTelefoneFornecedorADM.Size = new System.Drawing.Size(224, 20);
            this.txtTelefoneFornecedorADM.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço:";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            // 
            // btnInserirFornecedorADM
            // 
            this.btnInserirFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInserirFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirFornecedorADM.Location = new System.Drawing.Point(11, 288);
            this.btnInserirFornecedorADM.Name = "btnInserirFornecedorADM";
            this.btnInserirFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnInserirFornecedorADM.TabIndex = 12;
            this.btnInserirFornecedorADM.Text = "Inserir";
            this.btnInserirFornecedorADM.UseVisualStyleBackColor = false;
            this.btnInserirFornecedorADM.Click += new System.EventHandler(this.btnInserirFornecedorADM_Click);
            // 
            // btnEditarFornecedorADM
            // 
            this.btnEditarFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFornecedorADM.Location = new System.Drawing.Point(11, 350);
            this.btnEditarFornecedorADM.Name = "btnEditarFornecedorADM";
            this.btnEditarFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnEditarFornecedorADM.TabIndex = 13;
            this.btnEditarFornecedorADM.Text = "Editar";
            this.btnEditarFornecedorADM.UseVisualStyleBackColor = false;
            this.btnEditarFornecedorADM.Click += new System.EventHandler(this.btnEditarFornecedorADM_Click);
            // 
            // btnDeletarFornecedorADM
            // 
            this.btnDeletarFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletarFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFornecedorADM.Location = new System.Drawing.Point(126, 350);
            this.btnDeletarFornecedorADM.Name = "btnDeletarFornecedorADM";
            this.btnDeletarFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnDeletarFornecedorADM.TabIndex = 14;
            this.btnDeletarFornecedorADM.Text = "Deletar";
            this.btnDeletarFornecedorADM.UseVisualStyleBackColor = false;
            this.btnDeletarFornecedorADM.Click += new System.EventHandler(this.btnDeletarFornecedorADM_Click);
            // 
            // btnRefreshFornecedorADM
            // 
            this.btnRefreshFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefreshFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshFornecedorADM.Location = new System.Drawing.Point(126, 288);
            this.btnRefreshFornecedorADM.Name = "btnRefreshFornecedorADM";
            this.btnRefreshFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnRefreshFornecedorADM.TabIndex = 15;
            this.btnRefreshFornecedorADM.Text = "Atualizar";
            this.btnRefreshFornecedorADM.UseVisualStyleBackColor = false;
            this.btnRefreshFornecedorADM.Click += new System.EventHandler(this.btnRefreshFornecedorADM_Click);
            // 
            // txtCnpjFornecedorADM
            // 
            this.txtCnpjFornecedorADM.Location = new System.Drawing.Point(12, 111);
            this.txtCnpjFornecedorADM.Mask = "00.000.000/0000-00";
            this.txtCnpjFornecedorADM.Name = "txtCnpjFornecedorADM";
            this.txtCnpjFornecedorADM.Size = new System.Drawing.Size(226, 20);
            this.txtCnpjFornecedorADM.TabIndex = 16;
            // 
            // btnVoltarFornecedorADM
            // 
            this.btnVoltarFornecedorADM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltarFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarFornecedorADM.Location = new System.Drawing.Point(12, 525);
            this.btnVoltarFornecedorADM.Name = "btnVoltarFornecedorADM";
            this.btnVoltarFornecedorADM.Size = new System.Drawing.Size(109, 46);
            this.btnVoltarFornecedorADM.TabIndex = 17;
            this.btnVoltarFornecedorADM.Text = "Voltar";
            this.btnVoltarFornecedorADM.UseVisualStyleBackColor = false;
            this.btnVoltarFornecedorADM.Click += new System.EventHandler(this.btnVoltarFornecedorADM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "*Para editar precisa preencher todos os dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-6, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "*Para deletar so precisar preencher o campo idFornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = " se deseja que algum dado se mantenha,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = " apenas digite da mesma maneira que esta registrado.";
            // 
            // txtIdFornecedorADM
            // 
            this.txtIdFornecedorADM.Location = new System.Drawing.Point(12, 262);
            this.txtIdFornecedorADM.MaxLength = 10;
            this.txtIdFornecedorADM.Name = "txtIdFornecedorADM";
            this.txtIdFornecedorADM.Size = new System.Drawing.Size(71, 20);
            this.txtIdFornecedorADM.TabIndex = 23;
            this.txtIdFornecedorADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdFornecedorADM_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "idFornecedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "idFornecedor necessario apenas em editar e deletar.";
            // 
            // lojaVirtualDataSet1
            // 
            this.lojaVirtualDataSet1.DataSetName = "LojaVirtualDataSet";
            this.lojaVirtualDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "Fornecedor";
            this.fornecedorBindingSource1.DataSource = this.lojaVirtualDataSet1;
            // 
            // fornecedorTableAdapter1
            // 
            this.fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ADMTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarrinhoTableAdapter = null;
            this.tableAdapterManager1.ClienteTableAdapter = null;
            this.tableAdapterManager1.FornecedorTableAdapter = this.fornecedorTableAdapter1;
            this.tableAdapterManager1.ProdutosTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Loja_Virtual.LojaVirtualDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource1;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(274, 39);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.Size = new System.Drawing.Size(546, 422);
            this.fornecedorDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdFornecedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdFornecedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn8.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn10.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FornecedorADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 591);
            this.Controls.Add(this.fornecedorDataGridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdFornecedorADM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltarFornecedorADM);
            this.Controls.Add(this.txtCnpjFornecedorADM);
            this.Controls.Add(this.btnRefreshFornecedorADM);
            this.Controls.Add(this.btnDeletarFornecedorADM);
            this.Controls.Add(this.btnEditarFornecedorADM);
            this.Controls.Add(this.btnInserirFornecedorADM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoneFornecedorADM);
            this.Controls.Add(this.txtEnderecoFornecedorADM);
            this.Controls.Add(this.txtNomeFornecedorADM);
            this.Controls.Add(this.imgFecharFornecedorADM);
            this.Controls.Add(this.imgMinimizarFornecedorADM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FornecedorADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FornecedorADM";
            this.Load += new System.EventHandler(this.FornecedorADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharFornecedorADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarFornecedorADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaVirtualDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizarFornecedorADM;
        private System.Windows.Forms.PictureBox imgFecharFornecedorADM;
        private System.Windows.Forms.TextBox txtNomeFornecedorADM;
        private System.Windows.Forms.TextBox txtEnderecoFornecedorADM;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFornecedorADM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LojaVirtualDataSet lojaVirtualDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private LojaVirtualDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Button btnInserirFornecedorADM;
        private System.Windows.Forms.Button btnEditarFornecedorADM;
        private System.Windows.Forms.Button btnDeletarFornecedorADM;
        private System.Windows.Forms.Button btnRefreshFornecedorADM;
        private System.Windows.Forms.MaskedTextBox txtCnpjFornecedorADM;
        private System.Windows.Forms.Button btnVoltarFornecedorADM;
        private LojaVirtualDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdFornecedorADM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private LojaVirtualDataSet lojaVirtualDataSet1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private LojaVirtualDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter1;
        private LojaVirtualDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}