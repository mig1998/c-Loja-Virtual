using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Virtual
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();

           

        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            Form form = new lojaVirtualADM();
            Hide();
            form.ShowDialog();
            if (form.IsDisposed)
            {
                Close();
            }
            

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form form = new LojaVirtualCliente();
            Hide();
            form.ShowDialog();

            if (form.IsDisposed)
            {
                Close();
            }


        }

        private void imgMinimizeHome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgCloseHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
