using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        Thread mainserver;

        private void escuchar()
        {
            int port = Int32.Parse(txb_port.Text);
            TcpListener server = new TcpListener(IPAddress.Any, port);

            server.Start();
            lbx_Missatges.Items.Add("Servidor encendido, escuchando desde el puerto :" + port.ToString());
            Socket mensajero = server.AcceptSocket();

            while(1+1 == 2)
            {

                if (server.Pending())
                {

                    lbx_Missatges.Items.Add("Mensaje desde la IP: " + mensajero.RemoteEndPoint);
                    TcpClient cliente = server.AcceptTcpClient();

                    NetworkStream networkstream = cliente.GetStream();

                    byte[] buffer = new byte[1024];

                    networkstream.Read(buffer, 0, buffer.Length);

                    String mensaje = Encoding.ASCII.GetString(buffer);
                    lbx_Missatges.Items.Add(mensaje);
                    lbx_Missatges.Items.Add("------------------------------");
                    networkstream.Close();
                }
            }

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (txb_port.Text == "")
            {
                MessageBox.Show("El campo Port no puede estar vacio.");
            }
            else
            {
                mainserver = new Thread(escuchar);
                mainserver.Start();
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {

            mainserver.Abort();
            MessageBox.Show("Servidor desconectado.");

        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_borrarhistorial_Click(object sender, EventArgs e)
        {
            lbx_Missatges.Items.Clear();
        }
    }
}
