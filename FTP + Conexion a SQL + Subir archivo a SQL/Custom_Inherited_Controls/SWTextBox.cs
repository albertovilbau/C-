using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Custom_Inherited_Controls
{
    public class SWTextBox : TextBox
    {
        public SWTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.Enter += new System.EventHandler(this.SWTextBox_Enter);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextBox_Validating);
            this.ResumeLayout(false);

        }

        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
        }

        private bool _Forana;

        public bool Forana
        {
            get { return _Forana; }
            set { _Forana = value; }
        }

        private bool _CampoVacio;

        public bool CampoVacio
        {
            get { return _CampoVacio; }
            set { _CampoVacio = value; }
        }

        public enum TipoDato
        {
            Numero,
            Texto,
            Codigo
        }
        private TipoDato _DatoPermitido;
        public TipoDato DatoPermitido
        {
            get { return _DatoPermitido; }
            set
            {
                _DatoPermitido = value;
            }

        }

        private String _CampoDB;

        public String CampoDB
        {
            get { return _CampoDB; }
            set { _CampoDB = value; }
        }


        private void SWTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z]{4}-\d{3}/[13579]{1}[AEIOU]{1}$");
            string valors = this.Text;

            String DadaPermesa = _DatoPermitido.ToString();
            if (DadaPermesa.Equals("Codi"))
            {
                if (rgx.IsMatch(valors))

                {
                    MessageBox.Show("Codi Correcte");
                }
                else
                {
                    this.Text = "";
                    MessageBox.Show("Codi Incorrecte");
                }
            }
            else
            {

            }


            if (this.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

            Form frm = (Form)this.Parent;
            foreach (Control item in frm.Controls)
            {
                if (item.Name == this.NombreControl)
                {
                    item.Text = this.Text;
                }
            }
        }

        private string _NombreControl;

        public string NombreControl
        {
            get { return _NombreControl; }
            set { _NombreControl = value; }
        }



    }
}
