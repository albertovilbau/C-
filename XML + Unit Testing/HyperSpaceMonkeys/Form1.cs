using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;


namespace HyperSpaceMonkeys
{
    public partial class Form1 : Form
    {

        static string filePath = @"..\..\Resources\DataBank.xml";
        public XElement xelement = XElement.Load(filePath);
        int naveX, naveY, planetX, planetY;
        string namePlanet;
        bool situat = false;

        Calculos.Calculo calculaciones = new Calculos.Calculo();

        List<int> res = new List<int>();

        public class Tabla
        {
            public string name { get; set; }
            public string sector { get; set; }
            public string filiation { get; set; }
            public string natives { get; set; }
        }

        public class TablaCompleta
        {
            public string name { get; set; }
            public string sector { get; set; }
            public string filiation { get; set; }
            public string natives { get; set; }
            public string longui { get; set; }
            public string lat { get; set; }
            public string parsecs { get; set; }
            public string route { get; set; }
            public string landingdefault { get; set; }
        }

        public class TablaRutas
        {
            public string type { get; set; }
            public string nameRoute { get; set; }
            public string mapRoute { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            //Añadir planetas a origen
            foreach (XElement planet in xelement.Descendants("name"))
            {
                cmb_Origen.Items.Add((string)planet);
            }
        }

        private void cmb_Afiliation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Detail.Items.Clear();
            cmb_Detail.Text = "";

            //Añadimos los datos a destination dependiendo nuestra selección
            if (cmb_Afiliation.SelectedItem.ToString() == "Filiations")
            {
                foreach (XElement filiation in xelement.Element("filiations").Elements("description"))
                {
                    cmb_Detail.Items.Add((string)filiation);
                }
            }
            else
            {
                foreach (XElement regions in xelement.Element("regions").Elements("Region").Elements("nameRegion"))
                {
                    cmb_Detail.Items.Add((string)regions);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Llenar el datagridview dependiendo la seleccion
            if (cmb_Afiliation.Text == "Filiations")
            {
                //Buscamos en el XML
                var xFiliation = (from aa in xelement.Element("planets").Elements("planet")
                                  where ((string)aa.Element("filiation").Value == cmb_Detail.Text.ToString())
                                  select aa).ToList();

                //Rellenamos la lista de los datos encontrados antes
                List<Tabla> lista = (from item in xFiliation
                                     select new Tabla()
                                     {
                                         name = item.Element("name").Value,
                                         sector = item.Element("sector").Value,
                                         filiation = item.Element("filiation").Value,
                                         natives = item.Element("natives").Value,
                                     }).ToList();

                dgv_Content.DataSource = lista;
            }
            else
            {
                //Buscamos en el XML
                var xRegion = (from aa in xelement.Element("planets").Elements("planet")
                               where (aa.Element("sector").Value.Contains(cmb_Detail.Text.ToString()))
                               select aa).ToList();

                //Rellenamos la lista de los datos encontrados antes
                List<Tabla> lista = (from item in xRegion
                                     select new Tabla()
                                     {
                                         name = item.Element("name").Value,
                                         sector = item.Element("sector").Value,
                                         filiation = item.Element("filiation").Value,
                                         natives = item.Element("natives").Value,
                                     }).ToList();

                dgv_Content.DataSource = lista;
            }
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void dgv_Content_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbx_Routes.Items.Clear();

            //Buscamos en el XML
            var xDetalles = (from aa in xelement.Element("planets").Elements("planet")
                             where ((string)aa.Element("name").Value == dgv_Content.Rows[e.RowIndex].Cells[0].Value.ToString())
                             select aa).ToList();

            //Buscamos en el XML
            var xRoutes = (from aa in xelement.Element("planets").Elements("planet")
                           where ((string)aa.Element("name").Value == dgv_Content.Rows[e.RowIndex].Cells[0].Value.ToString())
                           select aa.Element("hyperspaceRoute").Elements("route").ToArray());

            
            //Conseguimos las rutas y las separamos en un array
            var hyperscaperoutexmlarray = xRoutes.ToArray();
            List<String> hyperspaceroutexml = new List<string>();

            for (int i = 0; i < hyperscaperoutexmlarray[0].Length; i++)
            {
                hyperspaceroutexml.Add(hyperscaperoutexmlarray[0][i].ToString());
            }

            for (int i = 0; i < hyperspaceroutexml.Count; i++)
            {
                hyperspaceroutexml[i] = hyperspaceroutexml[i].Substring(7, (hyperspaceroutexml[i].Length - 15));
            }

            //Rellenamos la lista de los datos encontrados antes
            List<TablaCompleta> lista = (from item in xDetalles
                                         select new TablaCompleta()
                                         {
                                             name = item.Element("name").Value,
                                             sector = item.Element("sector").Value,
                                             filiation = item.Element("filiation").Value,
                                             natives = item.Element("natives").Value,
                                             longui = item.Element("situation").Element("long").Value,
                                             lat = item.Element("situation").Element("lat").Value,
                                             parsecs = item.Element("situation").Element("parsecs").Value,
                                             landingdefault = item.Element("landingDefault").Value,
                                         }).ToList();

            //Mostramos los datos
            foreach (var bb in lista)
            {
                namePlanet = bb.name;
                lbl_Planet.Text = bb.name;
                lbl_Sector.Text = bb.sector;
                lbl_Filiation.Text = bb.filiation;
                lbl_Natives.Text = bb.natives;
                lbl_Longitude.Text = bb.longui;
                lbl_Latitude.Text = bb.lat;
                for (int i = 0; i < hyperspaceroutexml.Count; i++)
                {
                    lbx_Routes.Items.Add(hyperspaceroutexml[i]);
                }
                lbx_DefinedRoutes.Items.Add(bb.landingdefault);
                pb_Detail.ImageLocation = @"..\..\Resources\" + bb.name + ".png";
            }
            groupBox2.Enabled = true;
            groupBox2.Visible = true;
        }

        private void lbx_Routes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_CalculateVector.Enabled = true;
            //Buscamos en el XML
            var xDetallesRuta = (from aa in xelement.Element("hyperspaceRoutes").Elements("Route")
                                 where ((string)aa.Element("nameRoute").Value == lbx_Routes.Text.ToString())
                                 select aa).ToList();

            //Rellenamos la lista de los datos encontrados antes
            List<TablaRutas> lista = (from item in xDetallesRuta
                                         select new TablaRutas()
                                         {
                                             type = item.Element("type").Value,
                                             nameRoute = item.Element("nameRoute").Value,
                                             mapRoute = item.Element("mapRoute").Value,
                                             start = item.Element("start").Value,
                                             end = item.Element("end").Value,
                                         }).ToList();

            //Mostramos los datos
            foreach (var cc in lista)
            {
                lbl_Origin.Text = cc.start;
                lbl_Destination.Text = cc.end;
                lbl_RouteName.Text = cc.nameRoute;
                lbl_TypeRoute.Text = cc.type;
                if(cc.mapRoute == null)
                {
                    pb_Routes.Visible = false;
                }
                else
                {
                    pb_Routes.ImageLocation = @"..\..\Resources\" + cc.mapRoute;
                }
            }
            groupBox3.Enabled = true;
            groupBox3.Visible = true;
        }

        Thread realizarcalculosvector, realizarcalculoscoordenadas;
        private void btn_CalculateVector_Click(object sender, EventArgs e)
        {
            realizarcalculosvector = new Thread(calculosvector);
            realizarcalculoscoordenadas = new Thread(calcularcoordenadas);

            realizarcalculosvector.Start();
            realizarcalculoscoordenadas.Start();


        }

        private void calculosvector()
        {
            if (lbx_procesos.InvokeRequired)
                lbx_procesos.Invoke((MethodInvoker)delegate
                {
                    lbx_procesos.Items.Clear();
                    btn_HyperSpace.Enabled = true;

                    //Hacemos el MCD y el MCM
                    int NumMCD = calculaciones.generarMCD(Int32.Parse(lbl_Longitude.Text), Int32.Parse(lbl_Latitude.Text));
                    int NumMCM = calculaciones.generarMCM(Int32.Parse(lbl_Longitude.Text), Int32.Parse(lbl_Latitude.Text));

                    //Los usamos para los calculos
                    res = (calculaciones.Calculs(NumMCD, NumMCM));

                    //Mostramos
                    lbx_procesos.Items.Add("Vector calculs start:");
                    Application.DoEvents();
                    int pos = 0;
                    lbx_procesos.Items.Add("Coefficient Q: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("Coefficient R: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("Coefficient S: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("Coefficient T: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("Coefficient X: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("Coefficient Y: " + res[pos++]);
                    Application.DoEvents();
                    lbx_procesos.Items.Add("");
                    lbx_procesos.Items.Add("--------------------------");
                    lbx_procesos.Items.Add("");
                    
                });
        }

        private void calcularcoordenadas()
        {

            realizarcalculosvector.Join();

            if (lbx_procesos.InvokeRequired)
                lbx_procesos.Invoke((MethodInvoker)delegate
                {
                    //Hacemos calculos de coordenadas nave
                    Random r = new Random();
                    naveX = r.Next(0, 6);
                    naveY = r.Next(1, 6);
                    planetX = calculaciones.CalculoLongitudGrid(res);
                    planetY = calculaciones.CalculoLatitudGrid(res);

                    char[] letra = { 'A', 'B', 'C', 'D', 'E', 'F' };


                    lbx_procesos.Items.Add("Map vector Ship: " + letra[naveX] + naveY);
                    Thread.Sleep(500);
                    lbx_procesos.Items.Add("Map vector Planet: " + letra[planetX] + planetY);
                });
        }

        private void btn_HyperSpace_Click(object sender, EventArgs e)
        {            
            pb_Vectorize.Visible = true;
            pb_Vectorize.ImageLocation = @"..\..\Resources\HyperSpace.gif";
            tbl_HyperSpace.Visible = true;            

            PictureBox nave = new PictureBox();
            nave.ImageLocation = @"..\..\Resources\nave.png";
            nave.SizeMode = PictureBoxSizeMode.StretchImage;


            PictureBox planeta = new PictureBox();
            planeta.ImageLocation = @"..\..\Resources\" + namePlanet + ".png";
            planeta.SizeMode = PictureBoxSizeMode.StretchImage;

            //FALTA QUE SE BORREN LAS PICTURE BOX QUE HAY Y COLOCAR LAS NUEVAS

            tbl_HyperSpace.Controls.Remove(tbl_HyperSpace.GetControlFromPosition(naveX + 1, naveY));

            tbl_HyperSpace.Controls.Add(nave, naveX + 1, naveY);
            tbl_HyperSpace.Controls.Add(planeta, planetX + 1, planetY);

            //if (situat == true)
            //{
            //    tbl_HyperSpace.Controls.Remove(nave);
            //    tbl_HyperSpace.Controls.Remove(planeta);
            //    situat = false;
            //}
            //else
            //{

            //    situat = true;
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
