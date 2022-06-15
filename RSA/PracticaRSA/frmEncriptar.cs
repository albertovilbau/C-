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
using System.Xml.Linq;

namespace PracticaRSA
{
    public partial class frmEncriptar : Form
    {
        public frmEncriptar()
        {
            InitializeComponent();
        }

        RSACryptoServiceProvider publickey;
        String rutapublickey, encryptedText;

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                publickey = new RSACryptoServiceProvider();

                String xmlpublickey = File.ReadAllText(openfile.FileName);

                publickey.FromXmlString(xmlpublickey);

                rutapublickey = openfile.FileName;
            }
        }

        Byte[] dataEncrypted;

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            
            Byte[] dataToEncrypt = Encoding.ASCII.GetBytes(tbx_original.Text);
            dataEncrypted = publickey.Encrypt(dataToEncrypt, false);

            encryptedText = Encoding.UTF8.GetString(dataEncrypted);
            tbx_crypted.Text = encryptedText;

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (frmDesencriptar frm in Application.OpenForms.OfType<frmDesencriptar>())
            {
                frm.encryptedData = dataEncrypted;
                foreach (TextBox item in frm.Controls.OfType<TextBox>())
                {
                    if(item.Name == "tbx_crypted")
                    {
                        item.Text = encryptedText;
                    }
                }
            }
        }

        private void btn_showKey_Click(object sender, EventArgs e)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(rutapublickey);
            //tbx_pubkey.Text = doc.OuterXml;     

            XElement xml = XElement.Load(rutapublickey);
            IEnumerable<XElement> doc = xml.Descendants();

            foreach (var item in doc)
            {
                tbx_pubkey.AppendText(item.ToString() + Environment.NewLine);
            }

        }
    }
}
