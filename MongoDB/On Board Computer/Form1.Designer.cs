
namespace On_Board_Computer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trview_db = new System.Windows.Forms.TreeView();
            this.cmbox_db = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbInicial = new System.Windows.Forms.TabPage();
            this.tbRegions = new System.Windows.Forms.TabPage();
            this.pnl_regions = new System.Windows.Forms.Panel();
            this.pctboxRegions = new System.Windows.Forms.PictureBox();
            this.grpbox_regions = new System.Windows.Forms.GroupBox();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblregion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlanets = new System.Windows.Forms.TabPage();
            this.pctPlanet = new System.Windows.Forms.PictureBox();
            this.gbSpaceRoutes = new System.Windows.Forms.GroupBox();
            this.lboxroutes = new System.Windows.Forms.ListBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.lblPlanetSector = new System.Windows.Forms.Label();
            this.lblPlanetParsecs = new System.Windows.Forms.Label();
            this.lblPlanetLatitude = new System.Windows.Forms.Label();
            this.lblPlanetLongitude = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.lblPlanetFiliation = new System.Windows.Forms.Label();
            this.lblPlanetSpecie = new System.Windows.Forms.Label();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbRoutes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tbRegions.SuspendLayout();
            this.pnl_regions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxRegions)).BeginInit();
            this.grpbox_regions.SuspendLayout();
            this.tbPlanets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).BeginInit();
            this.gbSpaceRoutes.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.gbGeneralInfo.SuspendLayout();
            this.tbRoutes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trview_db
            // 
            this.trview_db.BackColor = System.Drawing.Color.Black;
            this.trview_db.ForeColor = System.Drawing.Color.White;
            this.trview_db.Location = new System.Drawing.Point(12, 88);
            this.trview_db.Name = "trview_db";
            this.trview_db.Size = new System.Drawing.Size(164, 508);
            this.trview_db.TabIndex = 0;
            this.trview_db.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trview_db_AfterSelect);
            // 
            // cmbox_db
            // 
            this.cmbox_db.FormattingEnabled = true;
            this.cmbox_db.Items.AddRange(new object[] {
            "regions",
            "planets",
            "hyperspaceRoutes"});
            this.cmbox_db.Location = new System.Drawing.Point(22, 51);
            this.cmbox_db.Name = "cmbox_db";
            this.cmbox_db.Size = new System.Drawing.Size(121, 21);
            this.cmbox_db.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Location = new System.Drawing.Point(174, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Info item:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInicial);
            this.tabControl1.Controls.Add(this.tbRegions);
            this.tabControl1.Controls.Add(this.tbPlanets);
            this.tabControl1.Controls.Add(this.tbRoutes);
            this.tabControl1.Location = new System.Drawing.Point(166, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 508);
            this.tabControl1.TabIndex = 8;
            // 
            // tbInicial
            // 
            this.tbInicial.BackColor = System.Drawing.Color.Black;
            this.tbInicial.Location = new System.Drawing.Point(4, 22);
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.Size = new System.Drawing.Size(782, 482);
            this.tbInicial.TabIndex = 2;
            this.tbInicial.Text = "Inicial";
            // 
            // tbRegions
            // 
            this.tbRegions.BackColor = System.Drawing.Color.Black;
            this.tbRegions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbRegions.Controls.Add(this.pnl_regions);
            this.tbRegions.Location = new System.Drawing.Point(4, 22);
            this.tbRegions.Name = "tbRegions";
            this.tbRegions.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegions.Size = new System.Drawing.Size(782, 482);
            this.tbRegions.TabIndex = 0;
            this.tbRegions.Text = "Regions";
            // 
            // pnl_regions
            // 
            this.pnl_regions.Controls.Add(this.pctboxRegions);
            this.pnl_regions.Controls.Add(this.grpbox_regions);
            this.pnl_regions.Location = new System.Drawing.Point(125, 11);
            this.pnl_regions.Name = "pnl_regions";
            this.pnl_regions.Size = new System.Drawing.Size(485, 460);
            this.pnl_regions.TabIndex = 8;
            // 
            // pctboxRegions
            // 
            this.pctboxRegions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxRegions.Location = new System.Drawing.Point(127, 246);
            this.pctboxRegions.Name = "pctboxRegions";
            this.pctboxRegions.Size = new System.Drawing.Size(233, 195);
            this.pctboxRegions.TabIndex = 1;
            this.pctboxRegions.TabStop = false;
            // 
            // grpbox_regions
            // 
            this.grpbox_regions.Controls.Add(this.txtdescription);
            this.grpbox_regions.Controls.Add(this.label3);
            this.grpbox_regions.Controls.Add(this.lblregion);
            this.grpbox_regions.Controls.Add(this.label2);
            this.grpbox_regions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbox_regions.Location = new System.Drawing.Point(18, 14);
            this.grpbox_regions.Name = "grpbox_regions";
            this.grpbox_regions.Size = new System.Drawing.Size(451, 212);
            this.grpbox_regions.TabIndex = 0;
            this.grpbox_regions.TabStop = false;
            this.grpbox_regions.Text = "Regions";
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.Black;
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescription.ForeColor = System.Drawing.Color.White;
            this.txtdescription.Location = new System.Drawing.Point(20, 82);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.ReadOnly = true;
            this.txtdescription.Size = new System.Drawing.Size(411, 112);
            this.txtdescription.TabIndex = 9;
            this.txtdescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPTION:";
            // 
            // lblregion
            // 
            this.lblregion.AutoSize = true;
            this.lblregion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregion.ForeColor = System.Drawing.Color.Ivory;
            this.lblregion.Location = new System.Drawing.Point(76, 31);
            this.lblregion.Name = "lblregion";
            this.lblregion.Size = new System.Drawing.Size(0, 15);
            this.lblregion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "REGION: ";
            // 
            // tbPlanets
            // 
            this.tbPlanets.BackColor = System.Drawing.Color.Black;
            this.tbPlanets.Controls.Add(this.pctPlanet);
            this.tbPlanets.Controls.Add(this.gbSpaceRoutes);
            this.tbPlanets.Controls.Add(this.gbPosition);
            this.tbPlanets.Controls.Add(this.gbGeneralInfo);
            this.tbPlanets.Location = new System.Drawing.Point(4, 22);
            this.tbPlanets.Name = "tbPlanets";
            this.tbPlanets.Padding = new System.Windows.Forms.Padding(3);
            this.tbPlanets.Size = new System.Drawing.Size(782, 482);
            this.tbPlanets.TabIndex = 1;
            this.tbPlanets.Text = "Planets";
            // 
            // pctPlanet
            // 
            this.pctPlanet.Location = new System.Drawing.Point(261, 272);
            this.pctPlanet.Name = "pctPlanet";
            this.pctPlanet.Size = new System.Drawing.Size(204, 196);
            this.pctPlanet.TabIndex = 3;
            this.pctPlanet.TabStop = false;
            // 
            // gbSpaceRoutes
            // 
            this.gbSpaceRoutes.Controls.Add(this.lboxroutes);
            this.gbSpaceRoutes.ForeColor = System.Drawing.Color.White;
            this.gbSpaceRoutes.Location = new System.Drawing.Point(40, 178);
            this.gbSpaceRoutes.Name = "gbSpaceRoutes";
            this.gbSpaceRoutes.Size = new System.Drawing.Size(646, 88);
            this.gbSpaceRoutes.TabIndex = 2;
            this.gbSpaceRoutes.TabStop = false;
            this.gbSpaceRoutes.Text = "Hyper Space Routes";
            // 
            // lboxroutes
            // 
            this.lboxroutes.BackColor = System.Drawing.Color.Black;
            this.lboxroutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxroutes.ForeColor = System.Drawing.Color.White;
            this.lboxroutes.FormattingEnabled = true;
            this.lboxroutes.Location = new System.Drawing.Point(15, 19);
            this.lboxroutes.Name = "lboxroutes";
            this.lboxroutes.Size = new System.Drawing.Size(467, 52);
            this.lboxroutes.TabIndex = 0;
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.lblPlanetSector);
            this.gbPosition.Controls.Add(this.lblPlanetParsecs);
            this.gbPosition.Controls.Add(this.lblPlanetLatitude);
            this.gbPosition.Controls.Add(this.lblPlanetLongitude);
            this.gbPosition.Controls.Add(this.label14);
            this.gbPosition.Controls.Add(this.label13);
            this.gbPosition.Controls.Add(this.label12);
            this.gbPosition.Controls.Add(this.label11);
            this.gbPosition.ForeColor = System.Drawing.Color.White;
            this.gbPosition.Location = new System.Drawing.Point(369, 16);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(317, 156);
            this.gbPosition.TabIndex = 1;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Position";
            // 
            // lblPlanetSector
            // 
            this.lblPlanetSector.AutoSize = true;
            this.lblPlanetSector.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetSector.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetSector.ForeColor = System.Drawing.Color.White;
            this.lblPlanetSector.Location = new System.Drawing.Point(92, 116);
            this.lblPlanetSector.Name = "lblPlanetSector";
            this.lblPlanetSector.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetSector.TabIndex = 16;
            // 
            // lblPlanetParsecs
            // 
            this.lblPlanetParsecs.AutoSize = true;
            this.lblPlanetParsecs.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetParsecs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetParsecs.ForeColor = System.Drawing.Color.White;
            this.lblPlanetParsecs.Location = new System.Drawing.Point(92, 91);
            this.lblPlanetParsecs.Name = "lblPlanetParsecs";
            this.lblPlanetParsecs.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetParsecs.TabIndex = 15;
            // 
            // lblPlanetLatitude
            // 
            this.lblPlanetLatitude.AutoSize = true;
            this.lblPlanetLatitude.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetLatitude.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetLatitude.ForeColor = System.Drawing.Color.White;
            this.lblPlanetLatitude.Location = new System.Drawing.Point(106, 67);
            this.lblPlanetLatitude.Name = "lblPlanetLatitude";
            this.lblPlanetLatitude.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetLatitude.TabIndex = 14;
            // 
            // lblPlanetLongitude
            // 
            this.lblPlanetLongitude.AutoSize = true;
            this.lblPlanetLongitude.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetLongitude.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetLongitude.ForeColor = System.Drawing.Color.White;
            this.lblPlanetLongitude.Location = new System.Drawing.Point(112, 40);
            this.lblPlanetLongitude.Name = "lblPlanetLongitude";
            this.lblPlanetLongitude.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetLongitude.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.PaleGreen;
            this.label14.Location = new System.Drawing.Point(33, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "LONGITUDE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.PaleGreen;
            this.label13.Location = new System.Drawing.Point(33, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "PARSECS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.PaleGreen;
            this.label12.Location = new System.Drawing.Point(33, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "SECTOR:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.PaleGreen;
            this.label11.Location = new System.Drawing.Point(33, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "LATITUDE:";
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.lblPlanetFiliation);
            this.gbGeneralInfo.Controls.Add(this.lblPlanetSpecie);
            this.gbGeneralInfo.Controls.Add(this.lblPlanetName);
            this.gbGeneralInfo.Controls.Add(this.label10);
            this.gbGeneralInfo.Controls.Add(this.label9);
            this.gbGeneralInfo.Controls.Add(this.label8);
            this.gbGeneralInfo.Controls.Add(this.groupBox3);
            this.gbGeneralInfo.ForeColor = System.Drawing.Color.White;
            this.gbGeneralInfo.Location = new System.Drawing.Point(40, 16);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(317, 156);
            this.gbGeneralInfo.TabIndex = 0;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "General info";
            // 
            // lblPlanetFiliation
            // 
            this.lblPlanetFiliation.AutoSize = true;
            this.lblPlanetFiliation.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetFiliation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetFiliation.ForeColor = System.Drawing.Color.White;
            this.lblPlanetFiliation.Location = new System.Drawing.Point(109, 91);
            this.lblPlanetFiliation.Name = "lblPlanetFiliation";
            this.lblPlanetFiliation.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetFiliation.TabIndex = 12;
            // 
            // lblPlanetSpecie
            // 
            this.lblPlanetSpecie.AutoSize = true;
            this.lblPlanetSpecie.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetSpecie.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetSpecie.ForeColor = System.Drawing.Color.White;
            this.lblPlanetSpecie.Location = new System.Drawing.Point(86, 67);
            this.lblPlanetSpecie.Name = "lblPlanetSpecie";
            this.lblPlanetSpecie.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetSpecie.TabIndex = 11;
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.AutoSize = true;
            this.lblPlanetName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetName.ForeColor = System.Drawing.Color.White;
            this.lblPlanetName.Location = new System.Drawing.Point(91, 40);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(0, 15);
            this.lblPlanetName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.PaleGreen;
            this.label10.Location = new System.Drawing.Point(26, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "FILIATION:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PaleGreen;
            this.label9.Location = new System.Drawing.Point(26, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "SPECIE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleGreen;
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "PLANET:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(323, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 156);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbRoutes
            // 
            this.tbRoutes.BackColor = System.Drawing.Color.Black;
            this.tbRoutes.Controls.Add(this.groupBox1);
            this.tbRoutes.Location = new System.Drawing.Point(4, 22);
            this.tbRoutes.Name = "tbRoutes";
            this.tbRoutes.Size = new System.Drawing.Size(782, 482);
            this.tbRoutes.TabIndex = 3;
            this.tbRoutes.Text = "Routes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lblRouteName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(93, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hyper Space Routes";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(54, 110);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 15);
            this.lblEnd.TabIndex = 14;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(68, 85);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(0, 15);
            this.lblStart.TabIndex = 13;
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteName.ForeColor = System.Drawing.Color.White;
            this.lblRouteName.Location = new System.Drawing.Point(101, 59);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(0, 15);
            this.lblRouteName.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(65, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 15);
            this.lblType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleGreen;
            this.label7.Location = new System.Drawing.Point(17, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "END:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "START:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ROUTE NAME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleGreen;
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "TYPE:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(174, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 29);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(157, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 40);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 608);
            this.Controls.Add(this.trview_db);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbox_db);
            this.Name = "Form1";
            this.Text = "On board computer";
            this.tabControl1.ResumeLayout(false);
            this.tbRegions.ResumeLayout(false);
            this.pnl_regions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxRegions)).EndInit();
            this.grpbox_regions.ResumeLayout(false);
            this.grpbox_regions.PerformLayout();
            this.tbPlanets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).EndInit();
            this.gbSpaceRoutes.ResumeLayout(false);
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.gbGeneralInfo.ResumeLayout(false);
            this.gbGeneralInfo.PerformLayout();
            this.tbRoutes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trview_db;
        private System.Windows.Forms.ComboBox cmbox_db;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbRegions;
        private System.Windows.Forms.Panel pnl_regions;
        private System.Windows.Forms.PictureBox pctboxRegions;
        private System.Windows.Forms.GroupBox grpbox_regions;
        private System.Windows.Forms.RichTextBox txtdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblregion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbPlanets;
        private System.Windows.Forms.TabPage tbInicial;
        private System.Windows.Forms.TabPage tbRoutes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pctPlanet;
        private System.Windows.Forms.GroupBox gbSpaceRoutes;
        private System.Windows.Forms.ListBox lboxroutes;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.Label lblPlanetSector;
        private System.Windows.Forms.Label lblPlanetParsecs;
        private System.Windows.Forms.Label lblPlanetLatitude;
        private System.Windows.Forms.Label lblPlanetLongitude;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbGeneralInfo;
        private System.Windows.Forms.Label lblPlanetFiliation;
        private System.Windows.Forms.Label lblPlanetSpecie;
        private System.Windows.Forms.Label lblPlanetName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
    }
}

