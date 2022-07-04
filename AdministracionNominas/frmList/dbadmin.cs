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
using System.IO;

namespace frmList
{
    public partial class dbadmin : Form
    {
        public dbadmin()
        {
            InitializeComponent();
        }

        DataSet dts;
        databaseconect.database dbconect;

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dbconect = new databaseconect.database();

            dts = dbconect.portarDades(cmbDB.Text);

            dataGridView1.DataSource = dts.Tables[0];

            FerBindings();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FerBindings()
        {
            int i = 1;

            foreach (InheritedControls.DBTexBox item in this.Controls.OfType<InheritedControls.DBTexBox>())
            {

                item.DataBindings.Clear();

                item.DataBindings.Add("text", dts.Tables[cmbDB.Text], item.CampoDB);
                item.Validated += new System.EventHandler(this.ValidarTextBox);

                i++;
            }

        }

        public Boolean NovaRow = false;

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!NovaRow)
            {
                ((InheritedControls.DBTexBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (NovaRow)
            {
                DataRow dr = dts.Tables[cmbDB.Text].NewRow();

                foreach (InheritedControls.DBTexBox item in this.Controls.OfType<InheritedControls.DBTexBox>())
                {
                    dr[item.CampoDB] = item.Text;
                }

                dts.Tables[cmbDB.Text].Rows.Add(dr);

            }

            int updatedrows = dbconect.Actualitzar(dts, cmbDB.Text);
            MessageBox.Show(updatedrows.ToString() + " Fila/s actualizadas.");

            dts = dbconect.portarDades(cmbDB.Text);
            dataGridView1.DataSource = dts.Tables[0];

            FerBindings();

            NovaRow = false;
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            NovaRow = true;

            foreach (InheritedControls.DBTexBox item in this.Controls.OfType<InheritedControls.DBTexBox>())
            {
                item.DataBindings.Clear();
                item.Text = "";
            }

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {

            if(cmbDB.Text == "")
            {
                MessageBox.Show("Debes de seleccionar una base de datos primeros");
            }
            else {
            OpenFileDialog file = new OpenFileDialog();


                if (file.ShowDialog() == DialogResult.OK)
                {

                    StreamReader lector = new StreamReader(file.FileName);

                    List<String> archivo = new List<string>();
                    int numlinias = 0;



                    while (lector.Peek() != -1)
                    {
                        archivo.Add(lector.ReadLine());
                        numlinias++;
                    }

                    lector.Close();

                    dbconect = new databaseconect.database();

                    DataSet dts = dbconect.portarDades(cmbDB.Text);

                    dts.Tables[0].Clear();

                    for (int i = 1; i < numlinias; i++)
                    {

                        String[] split = archivo[i].Split(',');

                        DataRow dr = dts.Tables[cmbDB.Text].NewRow();

                        dr["mail"] = split[0];
                        dr["archivo"] = split[1];

                        dts.Tables[cmbDB.Text].Rows.Add(dr);


                    }

                    dbconect.executa("DELETE FROM " + cmbDB.Text);

                    dbconect.Actualitzar(dts, cmbDB.Text);

                    dts = dbconect.portarDades(cmbDB.Text);
                    dataGridView1.DataSource = dts.Tables[0];

                    FerBindings();
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
