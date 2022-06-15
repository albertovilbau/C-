using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Net.Sockets;


namespace TCPClient
{
    public partial class frmClient : Form
    {

        String path = "TCPSettings.xml";

        public frmClient()
        {
            InitializeComponent();
        }

        Thread ferping;

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {

            ferping = new Thread(ferpings);
            ferping.Start();

        }

        private void ferpings()
        {
            lbx_console.Items.Clear();
            pnl_status.BackColor = Color.Yellow;
            String status;
            int correctpings = 0;

            Ping ping = new Ping();

            for (int i = 0; i < 10; i++)
            {
                PingReply reply = ping.Send("8.8.8.8");
                if (reply != null)
                {
                    status = "OK";
                    correctpings++;
                }
                else
                {
                    status = "Not responding";
                }

                int numping = i + 1;

                lbx_console.Items.Add("Ping " + numping.ToString() + ": " + status);
            }

            if (correctpings == 10)
            {
                lb_statusInfo.Text = "Conexió correcta.";
                pnl_status.BackColor = Color.Green;

                XElement settings = XElement.Load(path);

                String ip = (from a in settings.Descendants("TCP")
                             select a.Element("IP").Value).SingleOrDefault();
                String port = (from a in settings.Descendants("TCP")
                               select a.Element("Port").Value).SingleOrDefault();

                txb_ip.Text = ip;
                txb_port.Text = port;

            }
            else
            {
                lb_statusInfo.Text = "Ping no contesta o xarxa no disponible.";
                pnl_status.BackColor = Color.Red;
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_config_Click(object sender, EventArgs e)
        {

            if (txb_ip.Text == "" || txb_port.Text == "" || txb_message.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                XElement settingsMod = XElement.Load(path);
                IEnumerable<XElement> settings =

                (from a in settingsMod.Descendants("TCP")
                 select a);

                settings.First().Element("IP").Value = txb_ip.Text;
                settings.First().Element("Port").Value = txb_port.Text;

                settingsMod.Save(path);

                MessageBox.Show("Configuració guardada.");
            }

        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {

            if (txb_ip.Text == "" || txb_port.Text == "" || txb_message.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
            }
            else
            {
                String ip = txb_ip.Text;
                int port = Int32.Parse(txb_port.Text);

                TcpClient cliente = new TcpClient(ip, port);

                Byte[] buffer = Encoding.ASCII.GetBytes(txb_message.Text);
                NetworkStream networksteam = cliente.GetStream();

                networksteam.Write(buffer, 0, buffer.Length);
            }

        }
    }
}
