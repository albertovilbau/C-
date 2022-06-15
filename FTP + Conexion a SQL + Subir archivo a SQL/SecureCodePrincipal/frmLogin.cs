using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SecureCodePrincipal
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        String finalusername;
        String permisos;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            databaseconect.database db = new databaseconect.database();

            String usernamelocal = txtUsername.Text;
            String passwordlocal = richPassword.Text;

            DataSet dtslogin = db.portarDadesLogin("SELECT Login, Password FROM USERS WHERE Login = '" + usernamelocal + "' and Password = '" + passwordlocal + "'");
            DataTable dtlogin = dtslogin.Tables[0];
            if (dtlogin.Rows.Count != 0)
            {
                DataRow drlogin = dtlogin.Rows[0];

                String dbusername = drlogin[0].ToString();
                String dbpassword = drlogin[1].ToString();


                if (dbusername.Equals(usernamelocal) && dbpassword.Equals(passwordlocal))
                {
                    finalusername = txtUsername.Text;

                    DataSet idpermisos = db.portarDadesLogin("SELECT idUserRank FROM USERS WHERE Login = '" + usernamelocal + "';");
                    DataTable permisosdt = idpermisos.Tables[0];
                    DataRow permisosdr = permisosdt.Rows[0];
                    permisos = permisosdr[0].ToString();


                    Form frm = new fmrPrincipal(finalusername,permisos);
                    this.Hide();
                    frm.Show();
                }
            }
            else
            {
                lblIncorrectLogin.Visible = true;
            }
        }
        


    }
}
