using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmComanda : Form
    {

        List<Detall> Cistella = new List<Detall>();
        Comanda comanda = new Comanda();
        DadesComanda dadescomanda = new DadesComanda();
        string numComanda;
        int contador = 0;
        public string representant;
        public string zona;
        bool novaComanda = false;


        public frmComanda()
        {
            InitializeComponent();
        }


        private void btnDetall_Click(object sender, EventArgs e)
        {

            Detall compra = new Detall();
            compra.Producte = cmbProductes.Text;
            compra.preu = double.Parse(txtPreu.Text);
            compra.quantitat = int.Parse(txtQuantitat.Text);
            Cistella.Add(compra);

            dtgProductes.DataSource = null;
            dtgProductes.DataSource = Cistella;

            txtPreu.Text = "";
            txtQuantitat.Text = "";
        }

       

        private void btnBrut_Click(object sender, EventArgs e)
        {
            double importBrut = comanda.CalcularImportBrut(Cistella);
            importBrut = Math.Round(importBrut, 2, MidpointRounding.AwayFromZero);
            lblBrut.Text = importBrut.ToString();
            dadescomanda.ImportBrut = importBrut.ToString();
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            double iva = comanda.Iva(Cistella);
            iva = Math.Round(iva, 2, MidpointRounding.AwayFromZero);
            lblIva.Text = iva.ToString();
            dadescomanda.IVA = iva.ToString();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            double despesa = comanda.Despesa(Cistella, cmbClients.Text);
            despesa = Math.Round(despesa, 2, MidpointRounding.AwayFromZero);
            lblDespesa.Text = despesa.ToString();
            dadescomanda.Despesa = despesa.ToString();
        }


        private void btnDescompte_Click(object sender, EventArgs e)
        {           
            double descompte  = comanda.Descompte(Cistella, cmbClients.Text);
            descompte = Math.Round(descompte, 2, MidpointRounding.AwayFromZero);
            lbldescompte.Text = descompte.ToString();
            dadescomanda.Descompte = descompte.ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double importNet = comanda.Total(Cistella,cmbClients.Text);
            importNet = Math.Round(importNet, 2, MidpointRounding.AwayFromZero);
            lblTotal.Text = importNet.ToString();
            grpResum.Visible = true;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            novaComanda = true;
            contador++;
            int dia = DateTime.Today.DayOfYear;
            numComanda = dia.ToString() + "-" + contador.ToString();
            lblComanda.Text = numComanda;
            dadescomanda.NumComanda = numComanda;
            dadescomanda.Client = cmbClients.Text;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(novaComanda)
                dadescomanda.Client = cmbClients.Text;
        }

        private void cmbEstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstat.Items[cmbEstat.SelectedIndex].ToString() == "En espera")
                dadescomanda.Estat = "En espera";
            if (cmbEstat.Items[cmbEstat.SelectedIndex].ToString() == "Retinguda")
                dadescomanda.Estat = "Retinguda";
            if (cmbEstat.Items[cmbEstat.SelectedIndex].ToString() == "Condicionada")
                dadescomanda.Estat = "Condicionada";
            if (cmbEstat.Items[cmbEstat.SelectedIndex].ToString() == "Confirmada")
                dadescomanda.Estat = "Confirmada";
        }

        private void btnResum_Click(object sender, EventArgs e)
        {
            frmResum frm = new frmResum();
            frm.zona = zona;
            frm.detall = Cistella;
            frm.dades = dadescomanda;
            frm.client = cmbClients.Text;
            frm.Show();

        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }
    }
}
