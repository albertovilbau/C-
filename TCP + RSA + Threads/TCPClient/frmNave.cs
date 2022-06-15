using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO.Compression;



namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile = new OpenFileDialog();

        bool RedActiva = false;
        int cantidadPings = 0;
        int numeroPing = 0;
        int errorPing = 0;

        public string SendingFilePath = string.Empty;

        string IP;
        string Port;

        Thread RecibirTextoThread,RecibirArchivoThread;

        private const int BufferSize = 128;
        byte[] SendingBuffer = null;
        TcpClient client = null;
        NetworkStream netstream = null;
        DBConnect.dbconnect db;
        String idplanet;

        public void conectar(){
            int port = Convert.ToInt32(txb_port.Text);

            while (cantidadPings < 5)
            {
                pnl_status.Image = NavePACS.Properties.Resources.conectandoplaneta;
                RedActiva = NetworkInterface.GetIsNetworkAvailable();

                Ping Pings = new Ping();
                int timeout = 10;

                numeroPing++;

                IP = txb_ip.Text;
                Port = txb_port.Text;

                if (Pings.Send(IP, timeout).Status == IPStatus.Success)
                {
                    
                    if (lbx_console.InvokeRequired)
                        lbx_console.Invoke((MethodInvoker)delegate
                        {
                            lbx_console.Items.Add("Rastreo " + numeroPing + " planeta avistado");
                            Thread.Sleep(500);
                        });
                }
                else
                {
                    if (lbx_console.InvokeRequired)
                        lbx_console.Invoke((MethodInvoker)delegate
                        {
                            lbx_console.Items.Add("Rastreo " + numeroPing + " planeta no avistado");
                            errorPing++;
                            Thread.Sleep(500);
                        });
                }
                cantidadPings++;
            }

            if (errorPing == 5)
            {
                pnl_status.Image = NavePACS.Properties.Resources.disconnected;
                lb_statusInfo.Text = "No se ha podido establecer enlace con el planeta.";
            }
            else
            {
                pnl_status.Image = NavePACS.Properties.Resources.conectadoplaneta;
                if (lb_statusInfo.InvokeRequired)
                    lb_statusInfo.Invoke((MethodInvoker)delegate
                    {
                        lb_statusInfo.Text = "Conexión con el planeta disponible.";
                    });

                if (txb_ip.InvokeRequired)
                    txb_ip.Invoke((MethodInvoker)delegate
                    {
                        txb_ip.Enabled = false;
                    });

                if (txb_port.InvokeRequired)
                    txb_port.Invoke((MethodInvoker)delegate
                    {
                        txb_port.Enabled = false;
                    });

                if (btn_desconnect.InvokeRequired)
                    btn_desconnect.Invoke((MethodInvoker)delegate
                    {
                        btn_desconnect.Enabled = true;
                    });

                if (btn_enviararchivo.InvokeRequired)
                    btn_enviararchivo.Invoke((MethodInvoker)delegate
                    {
                        btn_enviararchivo.Enabled = true;
                    });

                if (btn_examinar.InvokeRequired)
                    btn_examinar.Invoke((MethodInvoker)delegate
                    {
                        btn_examinar.Enabled = true;
                    });

                if (btn_sendMessage.InvokeRequired)
                    btn_sendMessage.Invoke((MethodInvoker)delegate
                    {
                        btn_sendMessage.Enabled = true;
                    });

                if (lbox_mensajes.InvokeRequired)
                    lbox_mensajes.Invoke((MethodInvoker)delegate
                    {
                        lbox_mensajes.Items.Add("Escuchando desde el puerto: " + port);
                    });
            }
        }

        public void StartReceiving()
        {
            recibirArchivo(6666);
        }

        public void StartReceivingFiles()
        {
            RecibirTextoThread.Suspend();
            RecibirArchivoThread = new Thread(ReciveFiles);
            RecibirArchivoThread.Start();
        }

        public void ReciveFiles()
        {
            recibirArchivo(1234);
        }

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

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            while (true)
            {
                TcpClient client = null;
                NetworkStream netstream = null;
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

                        if (((IPEndPoint)client.Client.LocalEndPoint).Port == 1234)
                        {
                            if (lbox_mensajes.InvokeRequired)
                                lbox_mensajes.Invoke((MethodInvoker)delegate
                                {
                                    lbox_mensajes.Items.Add("Se ha recibido un archivo");
                                });
                            result = MessageBox.Show(message, caption, buttons);

                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                int totalrecbytes = 0;
                                FileStream Fs = new FileStream(@"recibido\" + "PACS" + ".zip", FileMode.OpenOrCreate, FileAccess.Write);
                                while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                                {
                                    Fs.Write(RecData, 0, RecBytes);
                                    totalrecbytes += RecBytes;
                                }

                                Fs.Close();
                                if (lbox_mensajes.InvokeRequired)
                                    lbox_mensajes.Invoke((MethodInvoker)delegate
                                    {
                                        lbox_mensajes.Items.Add("Se ha guardado el archivo");                                        
                                        btn_desconnect.Enabled = true;

                                        if (File.Exists(@"recibido\PACS.zip"))
                                        {
                                            db = new DBConnect.dbconnect();

                                            DataSet codificacio = db.portarDades("SELECT * FROM InnerEncryptionData WHERE IdInnerEncryption = '" + idplanet + "'");

                                            GuardarCodificacion(codificacio);

                                            lbox_mensajes.Items.Add("Comenzando descodificacion....");

                                            Thread generararxiu = new Thread(GenerarArchivo);

                                            generararxiu.Start(); 
                                        }

                                    });

                                netstream.Close();
                                client.Close();
                            }
                        }
                        else
                        {
                            netstream.Read(RecData, 0, RecData.Length);
                            if (lbox_mensajes.InvokeRequired)
                                lbox_mensajes.Invoke((MethodInvoker)delegate
                                {
                                    lbox_mensajes.Items.Add("Mensaje recibido...");
                                    string _Message = Encoding.ASCII.GetString(RecData);

                                    lbox_mensajes.Items.Add(_Message);                                    
                                    btn_desconnect.Enabled = true;

                                    String validationresult = _Message.Substring(15, 2);
                                    String tipusmessage = _Message.Substring(0, 2);
                                    

                                    if (validationresult.Equals("VP") || tipusmessage.Equals("VK"))
                                    {
                                        lbox_mensajes.Items.Add("Validation in progress....");

                                        int idnau = Int32.Parse(_Message.Substring(3, 12));
                                        db = new DBConnect.dbconnect();
                                        DataSet DeliveryDatas = db.portarDades("SELECT * FROM DeliveryData WHERE idSpaceShip = '" + idnau.ToString() + "'");
                                        idplanet = DeliveryDatas.Tables[0].Rows[0]["idPlanet"].ToString();

                                        DataSet ValidationCodes = db.portarDades("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idplanet + "'");
                                        String validationcode = ValidationCodes.Tables[0].Rows[0]["ValidationCode"].ToString();

                                        RSACryptoServiceProvider publickey = new RSACryptoServiceProvider();
                                        publickey.FromXmlString(GetPublicKey(idplanet));

                                        Byte[] datatoencrypt = Encoding.ASCII.GetBytes(validationcode);
                                        Byte[] encryptedcode = publickey.Encrypt(datatoencrypt, false);

                                        Byte[] tipomensaje = Encoding.ASCII.GetBytes("VK");

                                        responderPlaneta(tipomensaje);

                                        Thread.Sleep(1000);

                                        responderPlaneta(encryptedcode);

                                        StartReceivingFiles();                                                                                                                 

                                    }
                                    else if(tipusmessage.Equals("MI"))
                                    {
                                        MessageBox.Show("Validation result failed, missile sended.");
                                        pnl_status.Image = NavePACS.Properties.Resources.alarm;
                                        MessageBox.Show("Evacuate the ship");
                                        Application.Exit();
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

        public class codificaciondb
        {
            public String vocal { get; set; }
            public String codi { get; set; }
        }

        List<codificaciondb> codisdb = new List<codificaciondb>();

        public void GuardarCodificacion(DataSet codificacio)
        {

            for (int i = 0; i < codificacio.Tables[0].Rows.Count; i++)
            {

                codificaciondb cod = new codificaciondb()
                {
                    vocal = codificacio.Tables[0].Rows[i]["Word"].ToString(),
                    codi = codificacio.Tables[0].Rows[i]["Numbers"].ToString()
                };

                codisdb.Add(cod);

            }

        }

        public void GenerarArchivo()
        {


            String numeros = "";

            ZipFile.ExtractToDirectory(@"recibido\PACS.zip", "recibido");

            File.Delete(@"recibido\PACS.zip");

            numeros = numeros + File.ReadAllText(@"recibido\PACS1.txt");
            numeros = numeros + File.ReadAllText(@"recibido\PACS2.txt");
            numeros = numeros + File.ReadAllText(@"recibido\PACS3.txt");

            File.Delete(@"recibido\PACS1.txt");
            File.Delete(@"recibido\PACS2.txt");
            File.Delete(@"recibido\PACS3.txt");

            Char[] numerosindividuales = numeros.ToCharArray();

            String[] codis = new string[numerosindividuales.Length / 3];

            int posicionnumeros = numeros.Length;

            int x = 0;

            for (int i = 0; i < codis.Length; i++)
            {

                codis[i] = numeros.Substring(x, 3);

                x = x + 3;

            }

            String lletres = "";

            for (int i = 0; i < codis.Length; i++)
            {

                foreach (var item in codisdb)
                {
                    if (item.codi == codis[i])
                    {
                        lletres = lletres + item.vocal;
                    }
                }

            }

            File.WriteAllText(@"recibido\PACSSOL.txt", lletres);

            if (lbox_mensajes.InvokeRequired)
                lbox_mensajes.Invoke((MethodInvoker)delegate
                {
                    lbox_mensajes.Items.Add("Archivo descodificado y volcado en PACSSOL.txt");
                    lbox_mensajes.Items.Add("Procediendo a mandar archivo de vuelta...");

                    enviarArx(@"recibido\PACSSOL.txt", txb_ip.Text, 8455);
                });
        }

        private String GetPublicKey(String idplanet)
        {
            String publickey;

            DataSet publickeyds = db.portarDades("SELECT XMLKey FROM PlanetKeys WHERE idPlanet = '" + idplanet + "';");

            publickey = publickeyds.Tables[0].Rows[0][0].ToString();

            return publickey;
        }

        public void comprovarXarxa()
        {
            if (txb_ip.Text == "" || txb_port.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                RecibirTextoThread = new Thread(conectar);

                RecibirTextoThread.Start();               

                
            }
        }

        public void responderPlaneta(Byte[] dades)
        {
            String server = txb_ip.Text;
            int port = 4321;

            TcpClient sender = new TcpClient(server, port);
            NetworkStream ns = sender.GetStream();
            ns.Write(dades, 0, dades.Length);
        }

        public void enviarMsg()
        {
            if (txb_ip.Text == "" || txb_port.Text == "" || txb_message.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                string server = txb_ip.Text;
                int port = Convert.ToInt32(txb_port.Text);

                TcpClient client = new TcpClient(server, port);
                Byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
            }
        }

        public void examinar()
        {

            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "All Files (*.*)|*.*";
            Dlg.CheckFileExists = true;
            Dlg.Title = "Choose a File";
            Dlg.InitialDirectory = @"C:\";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                SendingFilePath = Dlg.FileName;
                txb_ruta.Text = SendingFilePath;

            }
        }

        public void desconectar()
        {

            lb_statusInfo.Text = "";
            lbx_console.Items.Clear();
            pnl_status.Image = NavePACS.Properties.Resources.disconnected;

            txb_ip.Enabled = true;
            txb_port.Enabled = true;
            btn_desconnect.Enabled = false;
            btn_enviararchivo.Enabled = false;
            btn_examinar.Enabled = false;
            btn_sendMessage.Enabled = false;

            Application.Exit();
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
                        SendingBuffer = new byte[CurrentPacketLength];
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
        
        

        public void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            comprovarXarxa();

            RecibirTextoThread = new Thread(StartReceiving);
            RecibirTextoThread.Start();
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            desconectar();
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            enviarMsg();
            if (txb_port.Text != "4321")
            {
                throw new Exception("Puerto incorrecto");
            }
            
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            examinar();
        }

        private void btn_enviararchivo_Click(object sender, EventArgs e)
        {
            enviarArx(txb_ruta.Text, IP, Convert.ToInt32(Port));
            if (txb_port.Text != "1234")
            {
                throw new Exception("Puerto incorrecto");
            }
        }
    }
}
