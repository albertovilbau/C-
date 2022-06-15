using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace FTP_Admin
{
    class Program
    {
        public static void listarArchivos()
        {

            FtpWebRequest ftprequest;

            ftprequest = (FtpWebRequest) WebRequest.Create("ftp://10.0.1.220//home//g8");

            String ftpuser = "g8";
            String ftppassword = "12345aA";

            ftprequest.Credentials = new NetworkCredential(ftpuser, ftppassword);

            ftprequest.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)ftprequest.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);

            string res = reader.ReadToEnd();

            Console.WriteLine(res);

            reader.Close();
            response.Close();

        }

        public static void listarArchivos(String carpeta)
        {

            FtpWebRequest ftprequest;

            ftprequest = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g8//" + carpeta);

            String ftpuser = "g8";
            String ftppassword = "12345aA";

            ftprequest.Credentials = new NetworkCredential(ftpuser, ftppassword);

            ftprequest.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)ftprequest.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);

            string res = reader.ReadToEnd();

            Console.WriteLine(res);

            reader.Close();
            response.Close();

        }

        public static void descargarArchivo(String archivo, String carpeta)
        {

            FtpWebRequest ftprequest;

            ftprequest = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g8/" + archivo);

            String ftpuser = "g8";
            String ftppassword = "12345aA";

            ftprequest.Credentials = new NetworkCredential(ftpuser, ftppassword);

            ftprequest.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse response = (FtpWebResponse)ftprequest.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);

            string res = reader.ReadToEnd();

            File.WriteAllText(carpeta + archivo, res);

            Console.Write($"Download Complete, status {response.StatusDescription}");
            Console.Write("-------------------------------------------------------\n");

            eliminarArchivo(archivo);
            subirArchivo(archivo, carpeta, "Tractats");

            reader.Close();
            response.Close();

        }

        public static void eliminarArchivo(String archivo)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g8/" + archivo);

            String ftpuser = "g8";
            String ftppassword = "12345aA";

            request.Credentials = new NetworkCredential(ftpuser, ftppassword);

            request.Method = WebRequestMethods.Ftp.DeleteFile;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            //Console.WriteLine("Delete status: {0}", response.StatusDescription);
            response.Close();
        }

        public static void subirArchivo(String archivo, String carpeta)
        {
            try
            {
                FtpWebRequest ftprequest;

                ftprequest = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g8/" + archivo);

                String ftpuser = "g8";
                String ftppassword = "12345aA";

                ftprequest.Credentials = new NetworkCredential(ftpuser, ftppassword);
                ftprequest.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] contenido = File.ReadAllBytes(carpeta + archivo);
                ftprequest.ContentLength = contenido.Length;

                Stream stream = ftprequest.GetRequestStream();
                stream.Write(contenido, 0, contenido.Length);
                stream.Close();
                Console.WriteLine($"Archivo: {archivo} subido con exito.\n");
            }
            catch (WebException e)
            {
                String status = ((FtpWebResponse)e.Response).StatusDescription;
                Console.WriteLine(status);
            }

        }

        public static void subirArchivo(String archivo, String carpeta, String carpetadestino)
        {
            try
            {
                FtpWebRequest ftprequest;

                ftprequest = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g8//" + carpetadestino + @"/" + archivo);

                String ftpuser = "g8";
                String ftppassword = "12345aA";

                ftprequest.Credentials = new NetworkCredential(ftpuser, ftppassword);
                ftprequest.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] contenido = File.ReadAllBytes(carpeta + archivo);
                ftprequest.ContentLength = contenido.Length;

                Stream stream = ftprequest.GetRequestStream();
                stream.Write(contenido, 0, contenido.Length);
                stream.Close();
                //Console.WriteLine($"Archivo: {archivo} subido con exito.\n");
            }
            catch (WebException e)
            {
                String status = ((FtpWebResponse)e.Response).StatusDescription;
                Console.WriteLine(status);
            }

        }

        private static void leerarchivo()
        {
            Console.Write("Especifica nombre archivo: ");
            String archivo = Console.ReadLine();
            int numlinines = 0;

            generaldata gndata = new generaldata();
            String fechadocumento = "", receptor = "";
            emisor emisor = new emisor();            

            List<string> fechaentrega = new List<string>();
            List<cantidades> cantidades = new List<cantidades>();
            List<articulo> articulos = new List<articulo>();
            

            archivo = @"..\Orders\" + archivo;

            StreamReader lector = new StreamReader(archivo);

            List<string> list = new List<string>();

            while (lector.Peek()!= -1)
            {
                list.Add(lector.ReadLine());
                numlinines++;
            }

            lector.Close();

            for (int i = 1; i < numlinines; i++)
            {

                String[] split = list[i].Split('|');

                if (split[0].Equals("ORD"))
                {

                    gndata.pedido = split[1];

                    if (split[2].Equals("220"))
                    {
                        gndata.tipo = "1";
                    }
                    else
                    {
                        gndata.tipo = "2";
                    }

                }
                else if (split[0].Equals("DTM"))
                {

                    fechadocumento = split[1];

                }
                else if (split[0].Equals("NADMS"))
                {

                    emisor.area = split[1];
                    emisor.emisorcode = split[2];

                }
                else if (split[0].Equals("NADMR"))
                {

                    receptor = split[1];

                }
                else if (split[0].Equals("LIN"))
                {

                    articulo art = new articulo();
                    art.destino = split[1];
                    art.codigo = split[2];
                    art.tipodecodigo = split[3];
                    articulos.Add(art);

                }
                else if (split[0].Equals("QTYLIN"))
                {

                    cantidades can = new cantidades();
                    can.calificador = split[1];
                    can.cantidad = split[2];

                    cantidades.Add(can);

                }
                else if(split[0].Equals("DTMLIN"))
                {

                    fechaentrega.Add(split[1]);

                }
            }

            databaseconect.database db = new databaseconect.database();

            String consultaroder, consultaorderdetail, consultaorderinfo;

            int idfabrica = getidfabrica(receptor);

            consultaroder = "INSERT INTO ORDERS VALUES (" + "'" + gndata.pedido + "'" + ", " + "'" + fechadocumento + "'" + ", " + "'" + Int32.Parse(gndata.tipo) + "'" + ", " + "'" + idfabrica + "');";
            db.executa(consultaroder);

            int producto = 0;

            int idorder = getidorder(gndata.pedido);
            foreach (var item in articulos)
            {

                int idplanet = getidplanet(item.destino);
                int idreference = getidreference(item.codigo);

                int cantidad = Int32.Parse(cantidades[producto].cantidad);
                String deliverydate = fechaentrega[producto];

                consultaorderdetail = "INSERT INTO ORDERSDETAIL VALUES ('" + idorder + "','" + idplanet + "','" + idreference + "','" + cantidad + "','" + deliverydate + "');";
                db.executa(consultaorderdetail);

                producto++;

            }

            int idagency = getidagency(emisor.emisorcode);
            int idoperationalarea = getoperationalarea(emisor.area);

            consultaorderinfo = "INSERT INTO ORDERINFO VALUES ('" + idorder + "','" + idagency + "','" + idoperationalarea + "');";
            db.executa(consultaorderinfo);


            Console.WriteLine("Comanda subida a la base de datos");

        }

        private static int getoperationalarea(String area)
        {
            int id;
            databaseconect.database db = new databaseconect.database();

            DataSet dts = db.portarDadesConsulta("SELECT idOperationalArea FROM [OperationalAreas] WHERE CodeOperationalArea = '" + area + "';", "OperationalAreas");
            id = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return id;
        }

        private static int getidagency(String emisorcode)
        {
            int id;
            databaseconect.database db = new databaseconect.database();

            DataSet dts = db.portarDadesConsulta("SELECT idAgency FROM [Agencies] WHERE CodeAgency = '" + emisorcode + "';", "Agencies");
            id = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return id;
        }

        private static int getidreference(String codereference)
        {
            int id;
            databaseconect.database db = new databaseconect.database();

            DataSet dts = db.portarDadesConsulta("SELECT idReference FROM [References] WHERE codeReference = '" + codereference + "';", "References");
            id = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return id;
        }

        private static int getidplanet(String codeplanet)
        {
            int id;
            databaseconect.database db = new databaseconect.database();

            DataSet dts = db.portarDadesConsulta("SELECT idPlanet FROM PLANETS WHERE CodePlanet = '" + codeplanet + "';", "Planets");
            id = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return id;
        }
        private static int getidorder(String codeorder)
        {
            int id;
            databaseconect.database db = new databaseconect.database();

            DataSet dts = db.portarDadesConsulta("SELECT idOrder FROM ORDERS WHERE codeOrder = '" + codeorder + "';", "Orders");
            id = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return id;
        }
        private static int getidfabrica(String receptor)
        {
            databaseconect.database db = new databaseconect.database();
            int idfabrica;

            DataSet dts = db.portarDadesConsulta("SELECT idFactory FROM Factories WHERE codeFactory = '" + receptor + "';", "Factories");

            idfabrica = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            return idfabrica;
        }

        private static String hacerping()
        {
            Ping pong = new Ping();
            String direccion = "10.0.1.220";
            PingReply respuesta = pong.Send(direccion);

            String estado = "";

            if (respuesta.Status == IPStatus.Success)
            {
                estado = "Servidor encendido";
            }
            else
            {
                estado = "Servidor apagado";
            }

            return estado;
        }

        static void Main(string[] args)
        {
            String carpetaarchivos = @"..\FTP Files\";
            String opcionmenu = "";

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|                         *FTP*                           |");
            Console.WriteLine("|                         ADMIN                           |");
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("Opción I: Información conexión servidor.\n" +
                "Opción M: Mapear contenido servidor.\n" +
                "Opción M2: Mapear carpeta específica\n"+
                "Opción D: Descargar Archivo.\n" +
                "Opción S: Subir Archivo.\n" +
                "Opción C: Cambiar ruta carpeta local.\n" +
                "Opción E: Exit.\n" +
                "Opcion X: Leer pedido\n");

            Console.WriteLine("");

            while (opcionmenu != "E")
            {

                Console.Write("Opción: ");

                opcionmenu = Console.ReadLine();
                opcionmenu = opcionmenu.ToUpper();


                if (opcionmenu == "I")
                {

                    String estado = hacerping();

                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Carpeta donde se guardan los archivos: {carpetaarchivos}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Información de conexión:");
                    Console.WriteLine("IP: 10.0.1.220");
                    Console.WriteLine("Estado del servidor: " + estado);
                    Console.WriteLine("---------------------------------------------------------");
                }
                else if (opcionmenu == "M")
                {
                    Console.WriteLine("Archivos en la carpeta G8:");
                    Console.WriteLine("");
                    listarArchivos();
                    Console.WriteLine("");
                }
                else if (opcionmenu == "M2")
                {
                    Console.Write("Carpeta: ");
                    String carpeta = Console.ReadLine();

                    Console.WriteLine($"Archivos en {carpeta}:");
                    Console.WriteLine("");
                    listarArchivos(carpeta);
                    Console.WriteLine("");
                }
                else if (opcionmenu == "D")
                {
                    Console.WriteLine("");
                    Console.Write("Archivo: ");
                    String archivo = Console.ReadLine();

                    descargarArchivo(archivo, carpetaarchivos);
                }
                else if (opcionmenu == "S")
                {
                    Console.WriteLine("");
                    Console.Write("Archivo: ");
                    String archivo = Console.ReadLine();

                    subirArchivo(archivo, carpetaarchivos);
                }else if (opcionmenu == "C")
                {
                    Console.Write("Nueva carpeta: ");
                    carpetaarchivos = Console.ReadLine();
                }
                else if (opcionmenu == "X")
                {
                    leerarchivo();
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta.");
                }
            }

        }
    }
}
