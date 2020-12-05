namespace Loja_Virtual
{
    partial class lojaVirtualADM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginADM = new System.Windows.Forms.TextBox();
            this.txtSenhaLoginAdm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltarHome = new System.Windows.Forms.Button();
            this.cBoxSenhaAdm = new System.Windows.Forms.CheckBox();
            this.imgFecharLogin = new System.Windows.Forms.PictureBox();
            this.imgMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(384, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginADM
            // 
            this.txtLoginADM.Location = new System.Drawing.Point(254, 123);
            this.txtLoginADM.Name = "txtLoginADM";
            this.txtLoginADM.Size = new System.Drawing.Size(219, 20);
            this.txtLoginADM.TabIndex = 1;
            // 
            // txtSenhaLoginAdm
            // 
            this.txtSenhaLoginAdm.Location = new System.Drawing.Point(254, 180);
            this.txtSenhaLoginAdm.Name = "txtSenhaLoginAdm";
            this.txtSenhaLoginAdm.Size = new System.Drawing.Size(219, 20);
            this.txtSenhaLoginAdm.TabIndex = 2;
            this.txtSenhaLoginAdm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(384, 318);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 36);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 35);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(214, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login ADM";
            // 
            // btnVoltarHome
            // 
            this.btnVoltarHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltarHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarHome.Location = new System.Drawing.Point(254, 318);
            this.btnVoltarHome.Name = "btnVoltarHome";
            this.btnVoltarHome.Size = new System.Drawing.Size(98, 36);
            this.btnVoltarHome.TabIndex = 8;
            this.btnVoltarHome.Text = "Voltar";
            this.btnVoltarHome.UseVisualStyleBackColor = false;
            this.btnVoltarHome.Click += new System.EventHandler(this.btnVoltarHome_Click);
            // 
            // cBoxSenhaAdm
            // 
            this.cBoxSenhaAdm.AutoSize = true;
            this.cBoxSenhaAdm.Location = new System.Drawing.Point(254, 207);
            this.cBoxSenhaAdm.Name = "cBoxSenhaAdm";
            this.cBoxSenhaAdm.Size = new System.Drawing.Size(95, 17);
            this.cBoxSenhaAdm.TabIndex = 13;
            this.cBoxSenhaAdm.Text = "Mostrar Senha";
            this.cBoxSenhaAdm.UseVisualStyleBackColor = true;
            this.cBoxSenhaAdm.CheckedChanged += new System.EventHandler(this.cBoxSenhaAdm_CheckedChanged);
            // 
            // imgFecharLogin
            // 
            this.imgFecharLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgFecharLogin.Image = global::Loja_Virtual.Properties.Resources.fechar;
            this.imgFecharLogin.Location = new System.Drawing.Point(479, 5);
            this.imgFecharLogin.Name = "imgFecharLogin";
            this.imgFecharLogin.Size = new System.Drawing.Size(24, 24);
            this.imgFecharLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFecharLogin.TabIndex = 12;
            this.imgFecharLogin.TabStop = false;
            this.imgFecharLogin.Click += new System.EventHandler(this.imgFecharLogin_Click);
            // 
            // imgMinimizarLogin
            // 
            this.imgMinimizarLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMinimizarLogin.Image = global::Loja_Virtual.Properties.Resources.minimizar;
            this.imgMinimizarLogin.Location = new System.Drawing.Point(431, 5);
            this.imgMinimizarLogin.Name = "imgMinimizarLogin";
            this.imgMinimizarLogin.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizarLogin.TabIndex = 11;
            this.imgMinimizarLogin.TabStop = false;
            this.imgMinimizarLogin.Click += new System.EventHandler(this.imgMinimizarLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::Loja_Virtual.Properties.Resources.admImg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lojaVirtualADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 366);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxSenhaAdm);
            this.Controls.Add(this.imgFecharLogin);
            this.Controls.Add(this.imgMinimizarLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltarHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaLoginAdm);
            this.Controls.Add(this.txtLoginADM);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "lojaVirtualADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja Virtual";
            ((System.ComponentModel.ISupportInitialize)(this.imgFecharLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginADM;
        private System.Windows.Forms.TextBox txtSenhaLoginAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltarHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgMinimizarLogin;
        private System.Windows.Forms.PictureBox imgFecharLogin;
        private System.Windows.Forms.CheckBox cBoxSenhaAdm;
    }
}

