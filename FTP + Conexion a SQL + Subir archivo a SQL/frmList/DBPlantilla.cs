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


namespace frmList
{
    public partial class DBPlantilla : Form
    {
        public DBPlantilla()
        {
            InitializeComponent();
        }

        public String tabla;
        public DataSet dts;

        private void DataBaseAdmin_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            databaseconect.database db = new databaseconect.database();
    
            dts = db.portarDades(tabla);

            dtgDB.DataSource = dts.Tables[0];

            FerBindings();

        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            databaseconect.database db = new databaseconect.database();

            if (NovaRow)
            {
                DataRow dr = dts.Tables[tabla].NewRow();

                foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
                {
                    if (item.CampoDB != "idUser")
                    {
                        dr[item.CampoDB] = item.Text;
                    }
                }

                dts.Tables[tabla].Rows.Add(dr);
            }

            int updtatedrows = db.Actualitzar(dts, tabla);
            MessageBox.Show(updtatedrows.ToString() + " Rows actualizadas");

            dts = db.portarDades(tabla);
            dtgDB.DataSource = dts.Tables[0];

            FerBindings();

            NovaRow = false;
        }

        private void FerBindings()
        {
            int i = 1;

            foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
            {

                item.DataBindings.Clear();

                item.DataBindings.Add("text", dts.Tables[0], item.CampoDB);
                item.Validated += new System.EventHandler(this.ValidarTextBox);

                i++;
            }

        }

        public Boolean NovaRow = false;
        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!NovaRow)
            {
                ((Custom_Inherited_Controls.SWTextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            NovaRow = true;

            foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
            {
                item.DataBindings.Clear();
                item.Text = "";
            }

        }
    }
}
