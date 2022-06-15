using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PCB_Criptografia
{
    public partial class frmCriptoServer : Form
    {
        public frmCriptoServer()
        {
            InitializeComponent();
        }

        Thread listen6700,listen6800;

        private void frmCriptoServer_Load(object sender, EventArgs e)
        {

            listen6700 = new Thread(() => server(6700));
            listen6800 = new Thread(() => server(6800));

            listen6700.Start();
            listen6800.Start();

        }

        private void server(int port)
        {

            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();
           
            if (lblStatus.InvokeRequired)
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lstMessage.Items.Add("Escuchando desde el puerto: " + port.ToString());
                });
            
            Socket mensajero = server.AcceptSocket();

            while (true)
            {
                try
                {

                
                if (server.Pending())
                {

                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buffer = new byte[16];

                    stream.Read(buffer, 0, buffer.Length);

                    String mensaje = Encoding.ASCII.GetString(buffer);

                    if (lstMessage.InvokeRequired)
                        lstMessage.Invoke((MethodInvoker)delegate
                        {
                            lstMessage.Items.Add("Port: " + port.ToString() + " - " + "Message: " + mensaje);
                        });

                    stream.Close();


                }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

    }
}
