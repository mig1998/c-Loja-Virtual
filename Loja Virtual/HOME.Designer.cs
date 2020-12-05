namespace Loja_Virtual
{
    partial class HOME
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.imgCloseHome = new System.Windows.Forms.PictureBox();
            this.imgMinimizeHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnADM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizeHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCloseHome
            // 
            this.imgCloseHome.Image = global::Loja_Virtual.Properties.Resources.fechar;
            this.imgCloseHome.Location = new System.Drawing.Point(696, 7);
            this.imgCloseHome.Name = "imgCloseHome";
            this.imgCloseHome.Size = new System.Drawing.Size(24, 24);
            this.imgCloseHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCloseHome.TabIndex = 4;
            this.imgCloseHome.TabStop = false;
            this.imgCloseHome.Click += new System.EventHandler(this.imgCloseHome_Click);
            // 
            // imgMinimizeHome
            // 
            this.imgMinimizeHome.Image = global::Loja_Virtual.Properties.Resources.minimizar;
            this.imgMinimizeHome.Location = new System.Drawing.Point(649, 7);
            this.imgMinimizeHome.Name = "imgMinimizeHome";
            this.imgMinimizeHome.Size = new System.Drawing.Size(24, 24);
            this.imgMinimizeHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMinimizeHome.TabIndex = 3;
            this.imgMinimizeHome.TabStop = false;
            this.imgMinimizeHome.Click += new System.EventHandler(this.imgMinimizeHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnCliente.Image = global::Loja_Virtual.Properties.Resources.png_transparent_computer_icons_customer_service_users_group_people_icon_miscellaneous_company_monochrome;
            this.btnCliente.Location = new System.Drawing.Point(366, 37);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(370, 413);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnADM
            // 
            this.btnADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.Image = global::Loja_Virtual.Properties.Resources.admImg___Copia;
            this.btnADM.Location = new System.Drawing.Point(-1, 37);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(370, 411);
            this.btnADM.TabIndex = 0;
            this.btnADM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.ControlBox = false;
            this.Controls.Add(this.imgCloseHome);
            this.Controls.Add(this.imgMinimizeHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnADM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizeHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgMinimizeHome;
        private System.Windows.Forms.PictureBox imgCloseHome;
    }
}