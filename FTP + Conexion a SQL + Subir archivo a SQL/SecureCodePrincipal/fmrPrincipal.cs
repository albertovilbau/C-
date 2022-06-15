using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCodePrincipal
{
    public partial class fmrPrincipal : Form
    {

        String username;
        String permisos;
        public fmrPrincipal(String username, String permisos)
        {
            InitializeComponent();
            this.username = username;
            this.permisos = permisos;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            lbluser.Text = username;
            if (permisos == "2" || permisos == "3")
            {
                frmLauncher1.Visible = false;
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FTP-Admin.exe");
        }

        private void panelIzquierda_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
