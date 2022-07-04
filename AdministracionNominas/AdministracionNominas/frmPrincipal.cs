using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic;
using System.Deployment.Application;


namespace AdministracionNominas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DataSet dts;
        databaseconect.database dbconect;

        private String[,] exportarusuariosArray(String taula)
        {

            //Esta funcion recorre la base de datos para devolvernos un array de dos dimensiones, en la columna 0 estará el mail
            //y en la columna 1 estará el nombre de la persona.

            //Conexión con la base de datos gracias a la libreria.
            dbconect = new databaseconect.database();

            dts = dbconect.portarDades(taula);

            DataTable usuarios = dts.Tables[0];

            //Creamos el array donde pondremos las personas. 
            String[,] usuariosv = new string[usuarios.Rows.Count, usuarios.Columns.Count];

            //Bucle que recorre la base de datos y va añadiendo las personas al array.
            for (int i = 0; i < usuarios.Rows.Count; i++)
            {
                for (int x = 0; x < usuarios.Columns.Count; x++)
                {

                    usuariosv[i, x] = usuarios.Rows[i][x].ToString();

                }
            }

            return usuariosv;
        }

        private void pctSend_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            //Definimos la ruta donde están los pdfs de la nomina.
            String ruta;

            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Selecciona la carpeta donde se encuentren las nominas.";
            folder.ShowNewFolderButton = false;

            if (folder.ShowDialog() == DialogResult.OK)
            {

                ruta = folder.SelectedPath;

                //Configuramos la conexión con el servidor de correo.
                String user = "user";
                String password = "password";
                String host = "smtp.gmail.com";
                int port = 587;

                SmtpClient client = new SmtpClient(host, port)
                {
                    Credentials = new NetworkCredential(user, password),
                    EnableSsl = true
                };

                //Realizamos la conexión con la base de datos.
                dbconect = new databaseconect.database();

                dts = dbconect.portarDades("Nominas");

                DataTable usuariosdb = dts.Tables[0];

                //Llamamos a la funcion para que nos devuelva el array con las personas.
                String[,] usuarios = exportarusuariosArray("Nominas");

                int arraylenght = usuariosdb.Rows.Count - 1;

                //Creamos un array donde guardaremos los nombres de los pdfs de las nominas.
                String[] nominas = Directory.GetFiles(ruta);

                Boolean tienenomina = false;

                int pdfnomina = 0;

                Boolean nominaencontrada = false;

                //Tenemos 2 For uno que recorre la lista de personas, y otro que recorre la lista de archivos.
                for (int i = 0; i < usuarios.Length/2; i++)
                {
                    for (int x = 0; x < nominas.Length; x++)
                    {
                        //Este for recorre la lista de archivos hasta dar con el archivo de la persona que esta buscando. (Si no encuentra pasará a otra persona).
                        String persona = usuarios[i, 1];
                        if (!nominaencontrada)
                        {
                            tienenomina = nominas[x].Contains(persona);
                            if (tienenomina)
                            {
                                pdfnomina = x;
                                nominaencontrada = true;

                            }
                        }


                    }
                    //Si el for anterior ha encontrado un archivo para la persona que estaba buscando entonces comienza con la construccion del mensaje.
                    if (tienenomina)
                    {
                        //Se configura el correo electronico que vaya a recibir.
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("nominas@cimupc.org");
                        mail.To.Add(usuarios[i, 0]);

                        mail.Subject = "Nòmina";
                        mail.Body = "Bon dia, \n \nT'adjuntem la nòmina d'aquest mes. Qualsevol consulta no contesteu aquest mail, podeu dirigir-vos a dp@cimupc.org.   \n \nSalutacions, \n \nDesenvolupament de persones";

                        Attachment attachment;

                        //Se selecciona el archivo pdf encontrado antes.
                        attachment = new Attachment(nominas[pdfnomina]);
                        mail.Attachments.Add(attachment);

                        client.Send(mail);

                        nominaencontrada = false;

                        //Código para exportar a un archivo CSV (Creación de logs)

                        DateTime fechahora = DateTime.Now;

                        //Creamos un archivo con la fecha y hora actual.
                        String rutalog = @"C:\Administracion Nominas Logs\" + fechahora.ToString("HH;mm_dd-MM-yyyy") + "_logs(Nominas).csv";

                        using (StreamWriter log = File.AppendText(rutalog))
                        {
                            //Escribimos una linea para cada persona que enviemos una nomina. 
                            log.WriteLine("Nomina enviada a: " + usuarios[i, 0]);

                        }

                    }

                }

                this.Cursor = Cursors.Default;

                MessageBox.Show("Nominas enviadas.");

                frmLogs frm = new frmLogs();
                frm.ShowDialog();

            }
        }

        private void pctSendIrpf_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //Definimos la ruta donde están los pdfs del IRPF.
            String ruta;

            String año = Microsoft.VisualBasic.Interaction.InputBox(
                "Insertar año del IRPF"
                );

            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Selecciona la carpeta donde se encuentren los IRPF.";
            folder.ShowNewFolderButton = false;

            if (folder.ShowDialog() == DialogResult.OK)
            {

                ruta = folder.SelectedPath;

                //Configuramos la conexión con el servidor de correo.
                String user = "user";
                String password = "password";
                String host = "smtp.gmail.com";
                int port = 587;

                SmtpClient client = new SmtpClient(host, port)
                {
                    Credentials = new NetworkCredential(user, password),
                    EnableSsl = true
                };

                //Realizamos la conexión con la base de datos.
                dbconect = new databaseconect.database();

                dts = dbconect.portarDades("IRPF");

                DataTable usuariosdb = dts.Tables[0];

                //Llamamos a la funcion para que nos devuelva el array con las personas.
                String[,] usuarios = exportarusuariosArray("IRPF");

                int arraylenght = usuariosdb.Rows.Count - 1;

                //Creamos un array donde guardaremos los nombres de los pdfs de los IRPF.
                String[] irpfs = Directory.GetFiles(ruta);

                Boolean tieneirpf = false;

                int pdfnomina = 0;

                Boolean irpfencontrado = false;

                //Tenemos 2 For uno que recorre la lista de personas, y otro que recorre la lista de archivos.
                for (int i = 0; i < usuarios.Length / 2; i++)
                {
                    for (int x = 0; x < irpfs.Length; x++)
                    {
                        //Este for recorre la lista de archivos hasta dar con el archivo de la persona que esta buscando. (Si no encuentra pasará a otra persona).
                        String persona = usuarios[i, 1];
                        if (!irpfencontrado)
                        {
                            tieneirpf = irpfs[x].Contains(persona);
                            if (tieneirpf)
                            {
                                pdfnomina = x;
                                irpfencontrado = true;

                            }
                        }


                    }
                    //Si el for anterior ha encontrado un archivo para la persona que estaba buscando entonces comienza con la construccion del mensaje.
                    if (tieneirpf)
                    {
                        //Se configura el correo electronico que vaya a recibir.
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("nominas@cimupc.org");
                        mail.To.Add(usuarios[i, 0]);

                        mail.Subject = "Certificat de retenció IRPF";
                        mail.Body = "Bon dia, \n \nT'adjuntem el certificat de retencions corresponent a l' any " + año + ". Qualsevol consulta no contesteu aquest mail, podeu dirigir-vos a dp@cimupc.org.   \n \nSalutacions, \n \nDesenvolupament de persones";

                        Attachment attachment;

                        //Se selecciona el archivo pdf encontrado antes.
                        attachment = new Attachment(irpfs[pdfnomina]);
                        mail.Attachments.Add(attachment);

                        client.Send(mail);

                        irpfencontrado = false;

                        //Código para exportar a un archivo CSV (Creación de logs)

                        DateTime fechahora = DateTime.Now;

                        //Creamos un archivo con la fecha y hora actual.
                        String rutalog = @"C:\Administracion Nominas Logs\" + fechahora.ToString("HH;mm_dd-MM-yyyy") + "_logs(IRPF).csv";

                        using (StreamWriter log = File.AppendText(rutalog))
                        {
                            //Escribimos una linea para cada persona que enviemos una nomina. 
                            log.WriteLine("IRPF enviada a: " + usuarios[i, 0]);

                        }                        

                    }

                }

                this.Cursor = Cursors.Default;

                MessageBox.Show("IRPFs enviados.");

                frmLogs frm = new frmLogs();
                frm.ShowDialog();

            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkDB()
        {
            //Funcion que prueba a hacer ping a la base de datos para ver si esta encendido. Se actualiza automaticamente gracias al timer de mas abajo.
            Ping pingdb = new Ping();
            int timeout = 10;

            if(pingdb.Send("10.12.12.9", timeout).Status == IPStatus.Success)
            {
                lblServerDB.Text = "Correcto";
                lblServerDB.ForeColor = Color.Green;
            }
            else
            {
                lblServerDB.Text = "Servidor apagado o fallo en la conexión";
                lblServerDB.ForeColor = Color.Red;
            }

        }

        //Label que muestra la versión del programa
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            checkDB();

            if (!Directory.Exists(@"C:\Administracion Nominas Logs"))
            {
                Directory.CreateDirectory(@"C:\Administracion Nominas Logs");
            }

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lblVersion.Text = "Version: " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            else
            {
                lblVersion.Text = "Version: Test version";
            }                      

        }

        private void pctBoxCheck_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Quieres hacer check de Nominas (En caso de IRPF clic NO)", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                //Sacamos los usuarios de la BD y los metemos en un array
                String[,] usuarios = exportarusuariosArray("Nominas");                

                //Configuramos el dialogo para seleccionar la capeta donde están las nominas
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Selecciona la carpeta donde se encuentren las Nominas.";
                folder.ShowNewFolderButton = false;

                if (folder.ShowDialog() == DialogResult.OK)
                {

                    //Metemos el nombre de todos los arhicvos en una array
                    String[] archivos = Directory.GetFiles(folder.SelectedPath);

                    List<String> faltandb = new List<string>();
                    List<String> faltanarchivo = new List<string>();
                    Boolean tienearchivo = false;
                    Boolean repetido = false;

                    //Miramos que usuarios no tienen su nominas
                    for (int i = 0; i < usuarios.Length/2; i++)
                    {

                        for (int x = 0; x < archivos.Length; x++)
                        {

                            if (archivos[x].Contains(usuarios[i,1]))
                            {
                                tienearchivo = true;
                                break;
                            }
                            else
                            {
                                tienearchivo = false;
                            }

                        }


                        if (!tienearchivo)
                        {
                            faltandb.Add(usuarios[i, 1]);
                        }

                    }

                    for (int i = 0; i < archivos.Length; i++)
                    {

                        for (int x = 0; x < usuarios.Length/2; x++)
                        {
                            if (archivos[i].Contains(usuarios[x,1]))
                            {
                                tienearchivo = true;
                                break;
                            }
                            else
                            {
                                tienearchivo = false;
                            }
                        }

                        if (!tienearchivo)
                        {
                            foreach (var item in faltanarchivo)
                            {
                                if (item.Contains(archivos[i]))
                                {
                                    repetido = true;
                                    break;
                                }
                                else
                                {
                                    repetido = false;
                                }
                            }

                            if (!repetido)
                            {
                                if (archivos[i].Contains(".PDF") || archivos[i].Contains(".pdf"))
                                {
                                    String nombrearchivo = Path.GetFileName(archivos[i]);
                                    faltanarchivo.Add(nombrearchivo);
                                }
                                
                            }

                        }

                    }

                    //Mostramos por pantalla los usuarios cuyo archivo no ha encontrado.
                    String displaydb = string.Join(Environment.NewLine, faltandb);
                    String displayarchivo = string.Join(Environment.NewLine, faltanarchivo);

                    MessageBox.Show("-Los siguiente usuarios estan en la BD pero no tienen archivo:" + Environment.NewLine + Environment.NewLine +displaydb + Environment.NewLine + Environment.NewLine + "-Los siguientes usuarios tienen archivo pero no están en la BD:" + Environment.NewLine + Environment.NewLine + displayarchivo);

                }

            }
            else if (dialog == DialogResult.No)
            {
                String[,] usuarios = exportarusuariosArray("IRPF");

                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Selecciona la carpeta donde se encuentren los IRPF.";
                folder.ShowNewFolderButton = false;

                if (folder.ShowDialog() == DialogResult.OK)
                {

                    //Metemos el nombre de todos los arhicvos en una array
                    String[] archivos = Directory.GetFiles(folder.SelectedPath);

                    List<String> faltandb = new List<string>();
                    List<String> faltanarchivo = new List<string>();
                    Boolean tienearchivo = false;
                    Boolean repetido = false;

                    //Miramos que usuarios no tienen sus IRPFs
                    for (int i = 0; i < usuarios.Length / 2; i++)
                    {

                        for (int x = 0; x < archivos.Length; x++)
                        {

                            if (archivos[x].Contains(usuarios[i, 1]))
                            {
                                tienearchivo = true;
                                break;
                            }
                            else
                            {
                                tienearchivo = false;
                            }

                        }


                        if (!tienearchivo)
                        {
                            faltandb.Add(usuarios[i, 1]);
                        }

                    }

                    for (int i = 0; i < archivos.Length; i++)
                    {

                        for (int x = 0; x < usuarios.Length / 2; x++)
                        {
                            if (archivos[i].Contains(usuarios[x, 1]))
                            {
                                tienearchivo = true;
                                break;
                            }
                            else
                            {
                                tienearchivo = false;
                            }
                        }

                        if (!tienearchivo)
                        {
                            foreach (var item in faltanarchivo)
                            {
                                if (item.Contains(archivos[i]))
                                {
                                    repetido = true;
                                    break;
                                }
                                else
                                {
                                    repetido = false;
                                }
                            }

                            if (!repetido)
                            {
                                if (archivos[i].Contains(".PDF") || archivos[i].Contains(".pdf"))
                                {
                                    String nombrearchivo = Path.GetFileName(archivos[i]);
                                    faltanarchivo.Add(nombrearchivo);
                                }

                            }

                        }

                    }

                    //Mostramos por pantalla los usuarios cuyo archivo no ha encontrado.
                    String displaydb = string.Join(Environment.NewLine, faltandb);
                    String displayarchivo = string.Join(Environment.NewLine, faltanarchivo);

                    MessageBox.Show("-Los siguiente usuarios estan en la BD pero no tienen archivo:" + Environment.NewLine + Environment.NewLine + displaydb + Environment.NewLine + Environment.NewLine + "-Los siguientes usuarios tienen archivo pero no están en la BD:" + Environment.NewLine + Environment.NewLine + displayarchivo);


                }

            }

            

        }

        private void dbTimer_Tick(object sender, EventArgs e)
        {
            checkDB();
        }

        //Eventos para cambiar el raton al pasar por encima de una de las opciones.
        private void frmLauncher1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void frmLauncher1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pctSend_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pctSend_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pctExit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pctExit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pctSendIrpf_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pctSendIrpf_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pctBoxCheck_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pctBoxCheck_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
