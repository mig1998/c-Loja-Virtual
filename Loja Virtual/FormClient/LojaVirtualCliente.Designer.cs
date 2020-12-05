namespace Loja_Virtual
{
    partial class LojaVirtualCliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgMinimizarLoginCliente = new System.Windows.Forms.PictureBox();
            this.imgFecharLoginCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginCliente = new System.Windows.Forms.TextBox();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.btnLoginCliente = new System.Windows.Forms.Button();
            this.btnCadastrarLoginCliente = new System.Windows.Forms.Button();
            this.btnVoltarHome2 = new System.Windows.Forms.Button();
            this.cBoxSenhaLogin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarLoginCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharLoginCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgMinimizarLoginCliente
            // 
            this.imgMinimizarLoginCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarLoginCliente.Image = global::Loja_Virtual.Properties.Resources.minimizar;
            this.imgMinimizarLoginCliente.Location = new System.Drawing.Point(472, 5);
            this.imgMinimizarLoginCliente.Name = "imgMinimizarLoginCliente";
            this.imgMinimizarLoginCliente.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarLoginCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarLoginCliente.TabIndex = 1;
            this.imgMinimizarLoginCliente.TabStop = false;
            this.imgMinimizarLoginCliente.Click += new System.EventHandler(this.imgMinimizarLoginCliente_Click);
            // 
            // imgFecharLoginCliente
            // 
            this.imgFecharLoginCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharLoginCliente.Image = global::Loja_Virtual.Properties.Resources.fechar;
            this.imgFecharLoginCliente.Location = new System.Drawing.Point(522, 5);
            this.imgFecharLoginCliente.Name = "imgFecharLoginCliente";
            this.imgFecharLoginCliente.Size = new System.Drawing.Size(24, 24);
            this.imgFecharLoginCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharLoginCliente.TabIndex = 2;
            this.imgFecharLoginCliente.TabStop = false;
            this.imgFecharLoginCliente.Click += new System.EventHandler(this.imgFecharLoginCliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::Loja_Virtual.Properties.Resources.png_transparent_computer_icons_customer_service_users_group_people_icon_miscellaneous_company_monochrome;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 410);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // txtLoginCliente
            // 
            this.txtLoginCliente.Location = new System.Drawing.Point(331, 155);
            this.txtLoginCliente.Name = "txtLoginCliente";
            this.txtLoginCliente.Size = new System.Drawing.Size(215, 20);
            this.txtLoginCliente.TabIndex = 7;
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Location = new System.Drawing.Point(331, 224);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(215, 20);
            this.txtSenhaCliente.TabIndex = 8;
            this.txtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoginCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCliente.Location = new System.Drawing.Point(441, 277);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(95, 37);
            this.btnLoginCliente.TabIndex = 9;
            this.btnLoginCliente.Text = "Login";
            this.btnLoginCliente.UseVisualStyleBackColor = false;
            this.btnLoginCliente.Click += new System.EventHandler(this.btnLoginCliente_Click);
            // 
            // btnCadastrarLoginCliente
            // 
            this.btnCadastrarLoginCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastrarLoginCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLoginCliente.Location = new System.Drawing.Point(441, 388);
            this.btnCadastrarLoginCliente.Name = "btnCadastrarLoginCliente";
            this.btnCadastrarLoginCliente.Size = new System.Drawing.Size(95, 37);
            this.btnCadastrarLoginCliente.TabIndex = 10;
            this.btnCadastrarLoginCliente.Text = "Cadastrar";
            this.btnCadastrarLoginCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarLoginCliente.Click += new System.EventHandler(this.btnCadastrarLoginCliente_Click);
            // 
            // btnVoltarHome2
            // 
            this.btnVoltarHome2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltarHome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarHome2.Location = new System.Drawing.Point(298, 388);
            this.btnVoltarHome2.Name = "btnVoltarHome2";
            this.btnVoltarHome2.Size = new System.Drawing.Size(80, 37);
            this.btnVoltarHome2.TabIndex = 11;
            this.btnVoltarHome2.Text = "Voltar";
            this.btnVoltarHome2.UseVisualStyleBackColor = false;
            this.btnVoltarHome2.Click += new System.EventHandler(this.btnVoltarHome2_Click);
            // 
            // cBoxSenhaLogin
            // 
            this.cBoxSenhaLogin.AutoSize = true;
            this.cBoxSenhaLogin.Location = new System.Drawing.Point(331, 251);
            this.cBoxSenhaLogin.Name = "cBoxSenhaLogin";
            this.cBoxSenhaLogin.Size = new System.Drawing.Size(95, 17);
            this.cBoxSenhaLogin.TabIndex = 12;
            this.cBoxSenhaLogin.Text = "Mostrar Senha";
            this.cBoxSenhaLogin.UseVisualStyleBackColor = true;
            this.cBoxSenhaLogin.CheckedChanged += new System.EventHandler(this.cBoxSenhaLogin_CheckedChanged);
            // 
            // LojaVirtualCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.cBoxSenhaLogin);
            this.Controls.Add(this.btnVoltarHome2);
            this.Controls.Add(this.btnCadastrarLoginCliente);
            this.Controls.Add(this.btnLoginCliente);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.txtLoginCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgFecharLoginCliente);
            this.Controls.Add(this.imgMinimizarLoginCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LojaVirtualCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja Virtual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarLoginCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharLoginCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizarLoginCliente;
        private System.Windows.Forms.PictureBox imgFecharLoginCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginCliente;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Button btnLoginCliente;
        private System.Windows.Forms.Button btnCadastrarLoginCliente;
        private System.Windows.Forms.Button btnVoltarHome2;
        private System.Windows.Forms.CheckBox cBoxSenhaLogin;
    }
}