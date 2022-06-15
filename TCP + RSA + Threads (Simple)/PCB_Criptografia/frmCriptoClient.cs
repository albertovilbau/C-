using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PCB_Criptografia
{
    public partial class frmCriptografia : Form
    {
        String localkeycontainer = "PCB";
        CspParameters localcsp, externalcsp;
        RSACryptoServiceProvider localrsa, externalrsa;
        Byte[] LocalEncryptedData, ExternalEncryptedData;
        Boolean haskeybeenreaded = false;

        public frmCriptografia()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {

            localcsp = new CspParameters();
            localcsp.KeyContainerName = localkeycontainer;

            localrsa = new RSACryptoServiceProvider(localcsp);

            Byte[] dataToEncrypt = Encoding.ASCII.GetBytes(txtOriginal.Text);
            LocalEncryptedData = localrsa.Encrypt(dataToEncrypt, false);
            
            txtEncriptat.Text = Encoding.UTF8.GetString(LocalEncryptedData);

            XElement xml = XElement.Load("publickey.xml");
            IEnumerable<XElement> doc = xml.Descendants();

            txtKey.Text = "";

            foreach (var item in doc)
            {
                txtKey.AppendText(item.ToString() + Environment.NewLine);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            BorrarLLavesAnteriores(localkeycontainer);

            localcsp = new CspParameters();
            localcsp.KeyContainerName = localkeycontainer;

            localrsa = new RSACryptoServiceProvider(localcsp);
            String publickey = localrsa.ToXmlString(false);

            File.WriteAllText("publickey.xml", publickey);

            XElement xml = XElement.Load("publickey.xml");
            IEnumerable<XElement> doc = xml.Descendants();

            txtKey.Text = "";

            foreach (var item in doc)
            {
                txtKey.AppendText(item.ToString() + Environment.NewLine);
            }

        }

        private void BorrarLLavesAnteriores(String keycontainername)
        {

            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = keycontainername;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = false;
            rsa.Clear();

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            Byte[] decrypteddata = localrsa.Decrypt(LocalEncryptedData, false);
            
            txtDescrypted.Text = Encoding.UTF8.GetString(decrypteddata);
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            externalcsp = new CspParameters();
            externalrsa = new RSACryptoServiceProvider(externalcsp);

            String externalkey = File.ReadAllText("privateKey.xml");
            externalrsa.FromXmlString(externalkey);

            haskeybeenreaded = true;

            XElement xml = XElement.Load("privateKey.xml");
            IEnumerable<XElement> doc = xml.Descendants();

            txtKey2.Text = "";

            foreach (var item in doc)
            {
                txtKey2.AppendText(item.ToString() + Environment.NewLine);
            }

        }

        private void btnEncriptar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (haskeybeenreaded)
                {

                    Byte[] dataToEncrypt = Encoding.ASCII.GetBytes(txtOriginal2.Text);
                    ExternalEncryptedData = externalrsa.Encrypt(dataToEncrypt, false);

                    txtEncriptat2.Text = Encoding.UTF8.GetString(ExternalEncryptedData);

                }
                else
                {
                    MessageBox.Show("Cal llegir la clau primer");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesencriptar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (haskeybeenreaded)
                {

                    Byte[] decrypteddata = externalrsa.Decrypt(ExternalEncryptedData, false);

                    txtDescrypted2.Text = Encoding.UTF8.GetString(decrypteddata);

                }
                else
                {
                    MessageBox.Show("Cal llegir la clau primer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void frmCriptografia_Load(object sender, EventArgs e)
        {
            frmCriptoServer frm = new frmCriptoServer();
            frm.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            String ip = "127.0.0.1";
            int port = Int32.Parse(cmbPorts.Text);

            TcpClient cliente = new TcpClient(ip, port);

            Byte[] buffer = Encoding.ASCII.GetBytes(txtMissatge.Text);
            NetworkStream networksteam = cliente.GetStream();

            networksteam.Write(buffer, 0, buffer.Length);

        }
    }
}
