using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace PCB_Fils
{
    public partial class frmFils : Form
    {
        public frmFils()
        {
            InitializeComponent();
        }

        Thread parametra, esperaA, esperaB, fildeconfiguracio;
        List<Thread> threadsabiertos = new List<Thread>();

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            Calculs.Despesa calc = new Calculs.Despesa();

            double despesa = calc.CalculaDespesa(int.Parse(txtImport.Text));

            txtDespesa.Text = despesa.ToString();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {

            cerrarhilos();
            txtResultat.Text = "";            

            parametra = new Thread(() => mostrarlletra1000(txtLletra.Text));
            parametra.Start();

            threadsabiertos.Add(parametra);

        }

        private void mostrarlletra1000 (String lletra)
        { 

            for (int i = 0; i < 1000; i++)
            {
                if (txtResultat.InvokeRequired)
                    txtResultat.Invoke((MethodInvoker)delegate
                    {

                        txtResultat.Text = txtResultat.Text + lletra;

                    });
            }

        }        

        private void btnEspera_Click(object sender, EventArgs e)
        {

            cerrarhilos();
            txtResultat.Text = "";
            esperaA = new Thread(mostrarA100);
            esperaB = new Thread(mostrarB20);

            esperaA.Start();
            esperaB.Start();

            threadsabiertos.Add(esperaA);
            threadsabiertos.Add(esperaB);

        }

        private void mostrarA100()
        {
            
            StreamWriter escritor = new StreamWriter("fitxerCompartit.txt");

            for (int i = 0; i < 100; i++)
            {
                if (txtResultat.InvokeRequired)
                    txtResultat.Invoke((MethodInvoker)delegate
                    {

                        txtResultat.Text = txtResultat.Text + "A";
                        escritor.Write("A");

                    });
            }

            escritor.Close();

        }

        private void mostrarB20()
        {

            esperaA.Join();

            StreamWriter escritor = new StreamWriter("fitxerCompartit.txt", true);

            for (int i = 0; i < 20; i++)
            {
                if (txtResultat.InvokeRequired)
                    txtResultat.Invoke((MethodInvoker)delegate
                    {

                        txtResultat.Text = txtResultat.Text + "B";
                        escritor.Write("B");

                    });
            }

            escritor.Close();
        }

        private void btnConfigura_Click(object sender, EventArgs e)
        {

            cerrarhilos();
            txtResultat.Text = "";

            fildeconfiguracio = new Thread(mostrarA100);

            fildeconfiguracio.Priority = ThreadPriority.Highest;
            fildeconfiguracio.IsBackground = true;
            fildeconfiguracio.Name = "Fil de configuracio";

            fildeconfiguracio.Start();

            MessageBox.Show(fildeconfiguracio.Name);

            threadsabiertos.Add(fildeconfiguracio);

        }

        private void frmFils_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarhilos();
        }

        private void cerrarhilos()
        {
            foreach (var item in threadsabiertos)
            {
                try
                {
                    if (item.IsAlive)
                    {
                        item.Abort();
                    }
                }
                catch (ThreadAbortException)
                {
                }
            }
        }

    }
}
