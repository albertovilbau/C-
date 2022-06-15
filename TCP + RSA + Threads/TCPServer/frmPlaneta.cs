using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections;
using System.IO.Compression;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private const int BufferSize = 128;
        public string Status = string.Empty;

        public void desconectar()
        {            
                Application.Exit();
        }

        Thread RecibirTextoThread, RecibirArchivoThread;

        public void StartReceivingFiles()
        {
            RecibirTextoThread.Suspend();
            RecibirArchivoThread = new Thread(ReciveFiles);
            RecibirArchivoThread.Start();
        }

        public void ReciveFiles()
        {
            recibirArchivo(8455);
        }

        public void StartReceiving()
        {
            recibirArchivo(Convert.ToInt32(txb_port.Text));
        }

        Boolean vk = false;
        TcpClient client = null;
        NetworkStream netstream = null;
        byte[] RecData;
        String server;


        public void recibirArchivo(int Port)
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, Port);

                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            RecData = new byte[BufferSize];
            int RecBytes;

            while (true)
            {                
                Status = string.Empty;
                try
                {
                    string message = "Accept the Incoming File ";
                    string caption = "Incoming Connection";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();

                        if (((IPEndPoint)client.Client.LocalEndPoint).Port == 8455)
                        {
                            if (lbx_Missatges.InvokeRequired)
                                lbx_Missatges.Invoke((MethodInvoker)delegate
                                {
                                    lbx_Missatges.Items.Add("Se ha recibido un archivo");
                                });
                            result = MessageBox.Show(message, caption, buttons);

                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                int totalrecbytes = 0;
                                FileStream Fs = new FileStream(@"arxius\PACSSOL.txt", FileMode.OpenOrCreate, FileAccess.Write);
                                while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                                {
                                    Fs.Write(RecData, 0, RecBytes);
                                    totalrecbytes += RecBytes;
                                }

                                Fs.Close();
                                if (lbx_Missatges.InvokeRequired)
                                    lbx_Missatges.Invoke((MethodInvoker)delegate
                                    {
                                        lbx_Missatges.Items.Add("Se ha guardado el archivo");
                                        pictureBox1.Image = PlanetaPACS.Properties.Resources.conectadonave;
                                        btn_desconnect.Enabled = true;


                                    });
                                if (File.Exists(@"arxius\PACSSOL.txt"))
                                {
                                    String pacssol = File.ReadAllText(@"arxius\PACSSOL.txt");

                                    if (lbx_Missatges.InvokeRequired)
                                        lbx_Missatges.Invoke((MethodInvoker)delegate
                                        {
                                            if (pacssol.Equals(lletres))
                                            {
                                                lbx_Missatges.Items.Add("Los archivos coinciden.");
                                            }
                                            else
                                            {
                                                lbx_Missatges.Items.Add("Los archivos no coinciden.");
                                            }
                                        });

                                }

                                netstream.Close();
                                client.Close();
                            }
                        }
                        else
                        {
                            netstream.Read(RecData, 0, RecData.Length);
                            if (lbx_Missatges.InvokeRequired)
                                lbx_Missatges.Invoke((MethodInvoker)delegate
                                {                                    
                                    string _Message = Encoding.ASCII.GetString(RecData);
                                    String tipusdemissatge = _Message.Substring(0, 2);
                                                         
                                    server = ((IPEndPoint)client.Client.LocalEndPoint).Address.ToString();
                                    int port = 6666;

                                    if (!vk)
                                    {
                                        lbx_Missatges.Items.Add("Mensaje recibido...");
                                        lbx_Missatges.Items.Add(_Message);
                                    }

                                    if (vk)
                                    {

                                        Thread GenerarEnviarArchivos = new Thread(VK);

                                        GenerarEnviarArchivos.Start();

                                        vk = false;
                                        
                                        
                                    }

                                    if (tipusdemissatge == "VK")
                                    {

                                        vk = true;
                                        lbx_Missatges.Items.Add("VK Recibido");

                                    }
                                    
                                    pictureBox1.Image = PlanetaPACS.Properties.Resources.conectadonave;
                                    btn_desconnect.Enabled = true;

                                    if (tipusdemissatge.Equals("ER"))
                                    {
                                        lbx_Missatges.Items.Add("Comprobando fechas de envío.");

                                        db = new DBConnect.dbconnect();
                                        DataSet deliverys = db.portarDades("SELECT * FROM DeliveryData");
                                        String idplanet = obtenirIdPlanet();

                                        int idnau = Int32.Parse(_Message.Substring(2, 12));
                                        int identrega = Int32.Parse(_Message.Substring(14, 12));

                                        int deliverydata = Int32.Parse(deliverys.Tables[0].Rows[0]["idDeliveryData"].ToString());
                                        int spaceship = Int32.Parse(deliverys.Tables[0].Rows[0]["idSpaceShip"].ToString());

                                        if(idnau == spaceship && deliverydata == identrega)
                                        {
                                            lbx_Missatges.Items.Add("Entrega programada para el día " + deliverys.Tables[0].Rows[0]["DeliveryDate"].ToString());

                                            String respuesta = "VR1";

                                            for (int i = 0; i < 12 - idnau.ToString().Length; i++)
                                            {

                                                respuesta = respuesta + "0";

                                            }

                                            respuesta = respuesta + idnau.ToString() + "VP";

                                            
                                            Byte[] dades = Encoding.ASCII.GetBytes(respuesta);

                                            sendTcp(server, port, dades);

                                        }
                                        else
                                        {

                                            lbx_Missatges.Items.Add("Nave no identificada");
                                            lbx_Missatges.Items.Add("Enviando misil al objetivo.....");

                                            Thread.Sleep(1000);

                                            String respuesta = "MI";
                                            
                                            Byte[] dades = Encoding.ASCII.GetBytes(respuesta);

                                            sendTcp(server, port, dades);
                                            
                                        }



                                    }
                                    

                                });

                            netstream.Close();
                            client.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void VK()
        {
            if (lbx_Missatges.InvokeRequired)
                lbx_Missatges.Invoke((MethodInvoker)delegate
                {
                    lbx_Missatges.Items.Add("Comparando codigos de validacion....");
                    String codivalidacio = txtCodiValidacio.Text;
                    String Keycontainername = obtenirIdPlanet();
                    CspParameters csp = new CspParameters();

                    csp.KeyContainerName = Keycontainername;
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);

                    Byte[] decrypteddata = rsa.Decrypt(RecData, false);
                    String decryptedcode = Encoding.UTF8.GetString(decrypteddata);

                    if (codivalidacio == decryptedcode)
                    {
                        lbx_Missatges.Items.Add("Codigos de validacion correctos.");
                        lbx_Missatges.Items.Add("Procediendo a crear archivos.");

                        String[] letras1 = generarLetras();
                        String[] letras2 = generarLetras();
                        String[] letras3 = generarLetras();

                        lletres = GuardarLletres(letras1, letras2, letras3);

                        GenerarArchivos(letras1, letras2, letras3);

                        lbx_Missatges.Items.Add("Archivos creados.");

                        enviarArx(@"arxius\PACS.zip", server, 1234);

                        lbx_Missatges.Items.Add("Archivo enviado.");

                        StartReceivingFiles();


                    }
                    else
                    {
                        lbx_Missatges.Items.Add("Codigos de validacion incorrectos, procediendo a enviar misil");

                        Byte[] misil = Encoding.ASCII.GetBytes("MI");

                        sendTcp(server, 6666, misil);
                    }
                });
        }

        public String GuardarLletres(String[] letras1, String[] letras2, String[] letras3)
        {
            String final = "";

            for (int i = 0; i < letras1.Length; i++)
            {
                final = final += letras1[i];
            }

            for (int i = 0; i < letras2.Length; i++)
            {
                final = final += letras2[i];
            }
            for (int i = 0; i < letras3.Length; i++)
            {
                final = final += letras3[i];
            }

            return final;
        }

        public String[] generarLetras()
        {

            String[] arrayletras = new string[100000];
            String[] abecedario = new string[26];
            char letra = 'A';

            for (int pos = 0; pos < abecedario.Length; pos++)
            {
                abecedario[pos] = letra.ToString().ToLower();
                letra++;
            }

            for (int i = 0; i < arrayletras.Length; i++)
            {
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var bytearray = new byte[4];
                provider.GetBytes(bytearray);
                int RandomInteger = BitConverter.ToInt32(bytearray, 0);

                Random random = new Random(RandomInteger);
                int value = random.Next(0, (abecedario.Length));

                arrayletras[i] = abecedario[value];
            }

            return arrayletras;
        }

        public class codificaciondb
        {
            public String vocal { get; set; }
            public String codi { get; set; }
        }

        List<codificaciondb> codisdb = new List<codificaciondb>();

        String lletres;
        public void GenerarArchivos(String[]letras1,String[]letras2,String[]letras3)
        {
            db = new DBConnect.dbconnect();
            DataSet InnerEncryption = db.portarDades("SELECT idInnerEncryption From InnerEncryption WHERE idPlanet ='" + obtenirIdPlanet() + "'");
            String idInnerEncryption = InnerEncryption.Tables[0].Rows[0][0].ToString();

            DataSet InnerEncryptionData = db.portarDades("SELECT Word,Numbers FROM InnerEncryptionData WHERE IdInnerEncryption ='" + idInnerEncryption + "'");

            for (int i = 0; i < InnerEncryptionData.Tables[0].Rows.Count; i++)
            {

                codificaciondb cod = new codificaciondb()
                {
                    vocal = InnerEncryptionData.Tables[0].Rows[i]["Word"].ToString(),
                    codi = InnerEncryptionData.Tables[0].Rows[i]["Numbers"].ToString()
                };

                codisdb.Add(cod);

            }

            String ruta1 = @"arxius\PACS1.txt";
            String ruta2 = @"arxius\PACS2.txt";
            String ruta3 = @"arxius\PACS3.txt";
            String rutazip = @"arxius\PACS.zip";

            if (File.Exists(ruta1))
            {
                File.Delete(ruta1);
            }
            else if(File.Exists(ruta2))
            {
                File.Delete(ruta2);
            }
            else if (File.Exists(ruta3))
            {
                File.Delete(ruta3);
            }
            else if (File.Exists(rutazip))
            {
                File.Delete(rutazip);
            }

            String numfitxer1 = "";
            for (int i = 0; i < letras1.Length; i++)
            {
                foreach (var item in codisdb)
                {
                    if (item.vocal == letras1[i])
                    {
                        numfitxer1 = numfitxer1 + item.codi;
                    }
                }
            }

            String numfitxer2 = "";
            for (int i = 0; i < letras2.Length; i++)
            {
                foreach (var item in codisdb)
                {
                    if (item.vocal == letras2[i])
                    {
                        numfitxer2 = numfitxer2 + item.codi;
                    }
                }
            }

            String numfitxer3 = "";
            for (int i = 0; i < letras3.Length; i++)
            {
                foreach (var item in codisdb)
                {
                    if (item.vocal == letras3[i])
                    {
                        numfitxer3 = numfitxer3 + item.codi;
                    }
                }
            }

            File.WriteAllText(ruta1, numfitxer1);
            File.WriteAllText(ruta2, numfitxer1);
            File.WriteAllText(ruta3, numfitxer1);

            String[] arxius = Directory.GetFiles("arxius");
            
            using (var archive = ZipFile.Open(rutazip, ZipArchiveMode.Create))
            {
                foreach (String ruta in arxius)
                {
                    archive.CreateEntryFromFile(ruta, Path.GetFileName(ruta));
                }
            }


        }

        public void enviarArx(string M, string IP, Int32 PortN)
        {

            try
            {
                client = new TcpClient(IP, PortN);
                netstream = client.GetStream();                
                FileStream Fs = new FileStream(M, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32
             (Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;
                    Byte[] SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                }
                Fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }

        public void sendTcp(String server, int port, Byte[] dades)
        {
            TcpClient sender = new TcpClient(server, port);
            NetworkStream ns = sender.GetStream();
            ns.Write(dades, 0, dades.Length);
        }

        
        public void btn_connect_Click(object sender, EventArgs e)
        {

            try
            {
                RecibirTextoThread = new Thread(StartReceiving);
                RecibirTextoThread.Start();
                lbx_Missatges.Items.Add("Planeta escuchando desde el puerto: " + txb_port.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_desconnect_Click_1(object sender, EventArgs e)
        {
            desconectar();
        }

        //Configuración de codigo de validación y claves de encriptación.

        private void btnParelldeClaus_Click(object sender, EventArgs e)
        {
            String id = obtenirIdPlanet();
            String keycontainername = id;

            BorrarLLavesAnteriores(keycontainername);

            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = keycontainername;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

            String publickey = rsa.ToXmlString(false);

            db = new DBConnect.dbconnect();

            DataSet dts = db.portarDades("SELECT * FROM PlanetKeys WHERE idplanet = '" + id + "'");

            dts.Tables[0].Rows[0]["XMLKey"] = publickey;
            db.Actualitzar(dts, "PlanetKeys");

            lbx_Missatges.Items.Add("Key pair generated.");
        }

        private void BorrarLLavesAnteriores(String keycontainername)
        {

            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = keycontainername;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = false;
            rsa.Clear();

        }

        private void cmboxPlanet_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenirValidationCode();
        }

        private void btnChangeCodi_Click(object sender, EventArgs e)
        {
            actualitzarValidationCode();
            obtenirValidationCode();
        }

        DBConnect.dbconnect db;
        DataSet planetas, innerencryption;

        private void frmServer_Load(object sender, EventArgs e)
        {
            db = new DBConnect.dbconnect();

            planetas = db.portarDades("SELECT DescPlanet FROM Planets");
            innerencryption = db.portarDades("Select * From InnerEncryption");

            int numrows = innerencryption.Tables[0].Rows.Count;

            for (int i = 0; i < numrows; i++)
            {
                DataRow planeta = planetas.Tables[0].Rows[i];
                cmboxPlanet.Items.Add(planeta[0].ToString());

            }

            cmboxPlanet.Text = cmboxPlanet.Items[0].ToString();

            obtenirValidationCode();
        }

        public String obtenirIdPlanet()
        {

            db = new DBConnect.dbconnect();
            DataSet planetid = db.portarDades("SELECT idPlanet FROM Planets WHERE DescPlanet = '" + cmboxPlanet.Text + "'");
            DataRow planetidRow = planetid.Tables[0].Rows[0];
            String id = planetidRow[0].ToString();

            return id;
        }

        public void obtenirValidationCode()
        {
            String id = obtenirIdPlanet();
            db = new DBConnect.dbconnect();

            DataSet InnerEncryption = db.portarDades("SELECT ValidationCode FROM InnerEncryption WHERE idPlanet = '" + id + "'");
            DataRow validationcode = InnerEncryption.Tables[0].Rows[0];
            txtCodiValidacio.Text = validationcode[0].ToString();

        }

        public void actualitzarValidationCode()
        {
            String validationcode = GenerarValidationCode();
            String idplanet = obtenirIdPlanet();

            db = new DBConnect.dbconnect();
            db.executa("UPDATE InnerEncryption Set ValidationCode = '" + validationcode + "' Where idPlanet = ' " + idplanet + "'");

        }

        public String GenerarValidationCode()
        {

            String codi = "";

            char[] letrasnumeros = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

            for (int i = 0; i < 12; i++)
            {
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var bytearray = new byte[4];
                provider.GetBytes(bytearray);
                int RandomInteger = BitConverter.ToInt32(bytearray, 0);

                Random random = new Random(RandomInteger);
                int value = random.Next(0, (letrasnumeros.Length));

                codi = codi + letrasnumeros[value].ToString();
            }

            return codi;

        }

        private void btnRegenerarInnerEncryptionData_Click(object sender, EventArgs e)
        {
            GenerarNumLetras();
        }

        public class codificacion
        {
            public String vocal { get; set; }
            public String codi { get; set; }
        }

        List<codificacion> codis = new List<codificacion>();

        public void GenerarNumLetras()
        {

            String idplaneta = obtenirIdPlanet();

            for (int i = 0; i < 26; i++)
            {

                Boolean codigoDisponible = false;
                String codi = "";

                //Genera un array con todas las letras del abecedario.
                String[] letras = new string[26];
                char letra = 'A';

                for (int pos = 0; pos < letras.Length; pos++)
                {
                    letras[pos] = letra.ToString().ToLower();
                    letra++;
                }

                while (!codigoDisponible)
                {
                    codi = generarCodi();
                    codigoDisponible = true;
                    foreach (var item in codis)
                    {
                        if (item.codi == codi)
                        {
                            codigoDisponible = false;
                        }
                    }
                }

                codificacion cod = new codificacion()
                {
                    vocal = letras[i],
                    codi = codi,
                };

                codis.Add(cod);

            }

            db = new DBConnect.dbconnect();

            db.executa("DELETE FROM InnerEncryptionData WHERE IdInnerEncryption = '" + idplaneta + "'");

            DataSet dts = db.portarDades("SELECT * FROM InnerEncryptionData");

            int id = dts.Tables[0].Rows.Count;

            for (int i = 0; i < codis.Count; i++)
            {
                id = id + i;
                dts.Tables[0].Rows.Add(id, int.Parse(idplaneta), codis[i].vocal, codis[i].codi);

            }

            codis.Clear();

            db.Actualitzar(dts, "InnerEncryptionData");

            lbx_Missatges.Items.Add("Inner encription data regenerated.");
        }

        public String generarCodi()
        {
            ArrayList numeros = new ArrayList()
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };
            String codi = "";

            for (int x = 0; x < 3; x++)
            {

                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var bytearray = new byte[4];
                provider.GetBytes(bytearray);
                int RandomInteger = BitConverter.ToInt32(bytearray, 0);

                Random random = new Random(RandomInteger);
                int value = random.Next(0, (numeros.Count - 1));

                codi = codi + (string)numeros[value];
            }

            return codi;
        }

    }
}
