using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        public frmDesencriptar()
        {
            InitializeComponent();
        }
        public Byte[] encryptedData;
        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                tbx_routeXML.Text = openfile.FileName;
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            CspParameters cspp = new CspParameters();
            String keycontainer = tbx_container.Text;

            cspp.KeyContainerName = keycontainer;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

            String publickey = rsa.ToXmlString(false);
            File.WriteAllText(tbx_routeXML.Text, publickey);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            CspParameters csp = new CspParameters();

            csp.KeyContainerName = tbx_container.Text;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
            Byte[] decrypteddata = rsa.Decrypt(encryptedData, false);

            String decryptedText = Encoding.UTF8.GetString(decrypteddata);
            tbx_decrypted.Text = decryptedText;

        }
    }
}
