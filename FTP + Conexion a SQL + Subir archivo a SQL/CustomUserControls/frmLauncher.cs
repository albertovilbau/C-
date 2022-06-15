using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomUserControls
{
    public partial class frmLauncher : UserControl
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private String _formulario;

        public String Formulario
        {
            get { return _formulario; }
            set { _formulario = value; }
        }

        private String dll;

        public String DLL
        {
            get { return dll; }
            set { dll = value; }
        }

        private void frmLauncher_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(DLL + ".dll");
            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(dll + "." + Formulario);

            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }
    }
}
