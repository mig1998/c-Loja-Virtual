namespace Loja_Virtual
{
    partial class ADM
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
            this.btnSairADM = new System.Windows.Forms.Button();
            this.txtCpfADM = new System.Windows.Forms.Label();
            this.txtEmailADM = new System.Windows.Forms.Label();
            this.txtNomeADM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProdutosADM = new System.Windows.Forms.Button();
            this.btnFornecedorADM = new System.Windows.Forms.Button();
            this.imgFecharADM = new System.Windows.Forms.PictureBox();
            this.imgMinimizarADM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairADM
            // 
            this.btnSairADM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSairADM.Location = new System.Drawing.Point(12, 403);
            this.btnSairADM.Name = "btnSairADM";
            this.btnSairADM.Size = new System.Drawing.Size(93, 39);
            this.btnSairADM.TabIndex = 3;
            this.btnSairADM.Text = "Sair";
            this.btnSairADM.UseVisualStyleBackColor = false;
            this.btnSairADM.Click += new System.EventHandler(this.btnSairADM_Click);
            // 
            // txtCpfADM
            // 
            this.txtCpfADM.AutoSize = true;
            this.txtCpfADM.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCpfADM.Location = new System.Drawing.Point(70, 56);
            this.txtCpfADM.Name = "txtCpfADM";
            this.txtCpfADM.Size = new System.Drawing.Size(31, 13);
            this.txtCpfADM.TabIndex = 4;
            this.txtCpfADM.Text = "ADM";
            // 
            // txtEmailADM
            // 
            this.txtEmailADM.AutoSize = true;
            this.txtEmailADM.ForeColor = System.Drawing.Color.DarkRed;
            this.txtEmailADM.Location = new System.Drawing.Point(203, 56);
            this.txtEmailADM.Name = "txtEmailADM";
            this.txtEmailADM.Size = new System.Drawing.Size(32, 13);
            this.txtEmailADM.TabIndex = 5;
            this.txtEmailADM.Text = "Email";
            // 
            // txtNomeADM
            // 
            this.txtNomeADM.AutoSize = true;
            this.txtNomeADM.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNomeADM.Location = new System.Drawing.Point(412, 56);
            this.txtNomeADM.Name = "txtNomeADM";
            this.txtNomeADM.Size = new System.Drawing.Size(35, 13);
            this.txtNomeADM.TabIndex = 6;
            this.txtNomeADM.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cpf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Primeiro deve Cadastrar o Fornecedor, assim podera cadastrar produtos!";
            // 
            // btnProdutosADM
            // 
            this.btnProdutosADM.Enabled = false;
            this.btnProdutosADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutosADM.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnProdutosADM.Image = global::Loja_Virtual.Properties.Resources.b1da36362690140b82f2615336181d34f58abf5a5fadf78cb182f5aafb43242e;
            this.btnProdutosADM.Location = new System.Drawing.Point(365, 161);
            this.btnProdutosADM.Name = "btnProdutosADM";
            this.btnProdutosADM.Size = new System.Drawing.Size(311, 218);
            this.btnProdutosADM.TabIndex = 11;
            this.btnProdutosADM.Text = "Produtos";
            this.btnProdutosADM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutosADM.UseVisualStyleBackColor = true;
            this.btnProdutosADM.Click += new System.EventHandler(this.btnProdutosADM_Click);
            // 
            // btnFornecedorADM
            // 
            this.btnFornecedorADM.BackgroundImage = global::Loja_Virtual.Properties.Resources.depositphotos_10045289_stock_photo_supplier_figure_package;
            this.btnFornecedorADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedorADM.ForeColor = System.Drawing.Color.Orange;
            this.btnFornecedorADM.ImageKey = "(nenhum/a)";
            this.btnFornecedorADM.Location = new System.Drawing.Point(23, 161);
            this.btnFornecedorADM.Name = "btnFornecedorADM";
            this.btnFornecedorADM.Size = new System.Drawing.Size(311, 218);
            this.btnFornecedorADM.TabIndex = 10;
            this.btnFornecedorADM.Text = "Fornecedores";
            this.btnFornecedorADM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedorADM.UseVisualStyleBackColor = true;
            this.btnFornecedorADM.Click += new System.EventHandler(this.btnFornecedorADM_Click);
            // 
            // imgFecharADM
            // 
            this.imgFecharADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharADM.Image = global::Loja_Virtual.Properties.Resources.fechar;
            this.imgFecharADM.Location = new System.Drawing.Point(705, 8);
            this.imgFecharADM.Name = "imgFecharADM";
            this.imgFecharADM.Size = new System.Drawing.Size(24, 24);
            this.imgFecharADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharADM.TabIndex = 2;
            this.imgFecharADM.TabStop = false;
            this.imgFecharADM.Click += new System.EventHandler(this.imgFecharADM_Click);
            // 
            // imgMinimizarADM
            // 
            this.imgMinimizarADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarADM.Image = global::Loja_Virtual.Properties.Resources.minimizar;
            this.imgMinimizarADM.Location = new System.Drawing.Point(652, 7);
            this.imgMinimizarADM.Name = "imgMinimizarADM";
            this.imgMinimizarADM.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarADM.TabIndex = 1;
            this.imgMinimizarADM.TabStop = false;
            this.imgMinimizarADM.Click += new System.EventHandler(this.imgMinimizarADM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProdutosADM);
            this.Controls.Add(this.btnFornecedorADM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeADM);
            this.Controls.Add(this.txtEmailADM);
            this.Controls.Add(this.txtCpfADM);
            this.Controls.Add(this.btnSairADM);
            this.Controls.Add(this.imgFecharADM);
            this.Controls.Add(this.imgMinimizarADM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADM";
            this.Load += new System.EventHandler(this.ADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizarADM;
        private System.Windows.Forms.PictureBox imgFecharADM;
        private System.Windows.Forms.Button btnSairADM;
        private System.Windows.Forms.Label txtCpfADM;
        private System.Windows.Forms.Label txtEmailADM;
        private System.Windows.Forms.Label txtNomeADM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFornecedorADM;
        private System.Windows.Forms.Button btnProdutosADM;
        private System.Windows.Forms.Label label4;
    }
}