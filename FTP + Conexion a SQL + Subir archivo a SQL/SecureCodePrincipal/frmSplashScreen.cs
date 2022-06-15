using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SecureCodePrincipal
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            pgbSplash.Increment(10);
            lblProgress.Text = pgbSplash.Value.ToString();

            if(pgbSplash.Value == pgbSplash.Maximum)
            {
                timerSplashScreen.Stop();

                Form frm = new frmLogin();
                this.Hide();

                Thread.Sleep(1500);

                frm.Show();
            }

        }
    }
}
