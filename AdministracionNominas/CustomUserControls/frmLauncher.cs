using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomUserControls
{
    public partial class frmLauncher: UserControl
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private String _DLL;

        public String DLL
        {
            get { return _DLL; }
            set { _DLL = value; }
        }

        private String _form;

        public String Formulario
        {
            get { return _form; }
            set { _form = value; }
        }

        private void frmLauncher_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(DLL + ".dll");
            object databaseadmin;
            Type tipus;

            tipus = ensamblat.GetType(DLL + "." + Formulario);
            databaseadmin = Activator.CreateInstance(tipus);

            ((Form)databaseadmin).Show();
        }
    }
}
