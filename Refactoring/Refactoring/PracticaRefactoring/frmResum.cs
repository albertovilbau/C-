using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmResum : Form
    {
        public frmResum()
        {
            InitializeComponent();
        }

        public DadesComanda dades = new DadesComanda();
        public List<Detall> detall;
        public string zona, client;
        Comanda comanda = new Comanda();


        private void frmResum_Load(object sender, EventArgs e)
        {
            if (zona=="Insular")
            {
                lblObservacions.Text = "Observacions: Pendent de confiormació des de la central";
            }

            lblBrut.Text = dades.ImportBrut;
            lblIva.Text = dades.IVA;
            lblDespesa.Text = dades.Despesa;
            lbldescompte.Text = dades.Descompte;

            lblComanda.Text = dades.NumComanda;
            lblClient.Text = dades.Client;
            lblestat.Text = dades.Estat;

            lblTotal.Text = comanda.Total(detall, client).ToString(); 

            dtgProductes.DataSource = detall;
        }
    }
}
