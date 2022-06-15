using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace On_Board_Computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<regions> regions;
        List<planeta> planets;
        List<hyperspaceRoute> hyperSpaceRoutes;
        ResourceManager rm = On_Board_Computer.Properties.Resources.ResourceManager;

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cmbox_db.Text == "regions")
            {

                trview_db.Nodes.Clear();
                regions = RegionsCollection.SelectAllRegions();
                tabControl1.SelectedIndex = 1;
                foreach (var item in regions)
                {
                    trview_db.Nodes.Add(item.nameRegion);                    
                }

            }
            else if (cmbox_db.Text == "hyperspaceRoutes")
            {
                trview_db.Nodes.Clear();
                hyperSpaceRoutes = hyperspaceRoutesCollection.SelectAllRoutes();
                tabControl1.SelectedIndex = 3;
                foreach (var item in hyperSpaceRoutes)
                {
                    trview_db.Nodes.Add(item.nameRoute);
                }
            }
            else if (cmbox_db.Text == "planets")
            {
                trview_db.Nodes.Clear();
                planets = PlanetasCollection.SelectAllPlanets();
                tabControl1.SelectedIndex = 2;
                foreach (var item in planets)
                {
                    trview_db.Nodes.Add(item.name);
                }
            }

        }

        private void trview_db_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (cmbox_db.Text == "regions")
            {

                foreach (var item in regions)
                {
                    if (item.nameRegion == trview_db.SelectedNode.Text)
                    {

                        lblregion.Text = item.nameRegion;
                        txtdescription.Text = item.descriptionRegion;
                        pctboxRegions.ImageLocation = @"planetes\" + item.mapRegion;
                        
                    }
                }

            }
            else if (cmbox_db.Text == "hyperspaceRoutes")
            {
                foreach (var item in hyperSpaceRoutes)
                {
                    if (item.nameRoute == trview_db.SelectedNode.Text)
                    {

                        lblEnd.Text = item.end;
                        lblStart.Text = item.start;
                        lblType.Text = item.type;
                        lblRouteName.Text = item.nameRoute;

                    }
                }
            }
            else if (cmbox_db.Text == "planets")
            {
                foreach (var item in planets)
                {
                    if (item.name == trview_db.SelectedNode.Text)
                    {

                        lblPlanetName.Text = item.name;
                        lblPlanetSpecie.Text = item.natives;
                        lblPlanetFiliation.Text = item.filiation;
                        lblPlanetLatitude.Text = item.situacion.latitud;
                        lblPlanetLongitude.Text = item.situacion.longitud;
                        lblPlanetParsecs.Text = item.situacion.parsecs;
                        lblPlanetSector.Text = item.sector;
                        pctPlanet.ImageLocation = @"planetes\" + item.name + ".jpg";

                        lboxroutes.Items.Clear();
                        for (int i = 0; i < item.hyperspaceRoute.route.Length; i++)
                        {
                            lboxroutes.Items.Add(item.hyperspaceRoute.route[i]);
                        }
                        

                    }
                }
            }

        }

    }
}
