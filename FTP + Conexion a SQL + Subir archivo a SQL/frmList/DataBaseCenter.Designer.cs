
namespace frmList
{
    partial class DataBaseCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseCenter));
            this.lblUsuaris = new System.Windows.Forms.Label();
            this.lblEspecies = new System.Windows.Forms.Label();
            this.lblCategoriesUsuaris = new System.Windows.Forms.Label();
            this.lblSectors = new System.Windows.Forms.Label();
            this.pctExitbtn = new System.Windows.Forms.PictureBox();
            this.frmLauncher4 = new CustomUserControls.frmLauncher();
            this.frmLauncher3 = new CustomUserControls.frmLauncher();
            this.frmLauncher2 = new CustomUserControls.frmLauncher();
            this.frmLauncher1 = new CustomUserControls.frmLauncher();
            this.frmLauncher_categorias_usuaris = new CustomUserControls.frmLauncher();
            this.frmLauncher_Sectors = new CustomUserControls.frmLauncher();
            this.fmrlauncher_usuaris = new CustomUserControls.frmLauncher();
            this.frmLauncher_opcions_menu = new CustomUserControls.frmLauncher();
            this.frmLauncher_especies = new CustomUserControls.frmLauncher();
            ((System.ComponentModel.ISupportInitialize)(this.pctExitbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuaris
            // 
            this.lblUsuaris.AutoSize = true;
            this.lblUsuaris.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuaris.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuaris.Location = new System.Drawing.Point(258, 440);
            this.lblUsuaris.Name = "lblUsuaris";
            this.lblUsuaris.Size = new System.Drawing.Size(134, 40);
            this.lblUsuaris.TabIndex = 5;
            this.lblUsuaris.Text = "Usuaris";
            // 
            // lblEspecies
            // 
            this.lblEspecies.AutoSize = true;
            this.lblEspecies.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecies.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecies.Location = new System.Drawing.Point(258, 186);
            this.lblEspecies.Name = "lblEspecies";
            this.lblEspecies.Size = new System.Drawing.Size(157, 40);
            this.lblEspecies.TabIndex = 6;
            this.lblEspecies.Text = "Espècies";
            // 
            // lblCategoriesUsuaris
            // 
            this.lblCategoriesUsuaris.AutoSize = true;
            this.lblCategoriesUsuaris.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriesUsuaris.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesUsuaris.Location = new System.Drawing.Point(773, 186);
            this.lblCategoriesUsuaris.Name = "lblCategoriesUsuaris";
            this.lblCategoriesUsuaris.Size = new System.Drawing.Size(385, 40);
            this.lblCategoriesUsuaris.TabIndex = 8;
            this.lblCategoriesUsuaris.Text = "Categories Usuaris (EF)";
            // 
            // lblSectors
            // 
            this.lblSectors.AutoSize = true;
            this.lblSectors.BackColor = System.Drawing.Color.Transparent;
            this.lblSectors.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectors.Location = new System.Drawing.Point(773, 440);
            this.lblSectors.Name = "lblSectors";
            this.lblSectors.Size = new System.Drawing.Size(212, 40);
            this.lblSectors.TabIndex = 9;
            this.lblSectors.Text = "Usuaris (EF)";
            // 
            // pctExitbtn
            // 
            this.pctExitbtn.BackColor = System.Drawing.Color.Transparent;
            this.pctExitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExitbtn.BackgroundImage")));
            this.pctExitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctExitbtn.Location = new System.Drawing.Point(1489, 862);
            this.pctExitbtn.Name = "pctExitbtn";
            this.pctExitbtn.Size = new System.Drawing.Size(159, 153);
            this.pctExitbtn.TabIndex = 10;
            this.pctExitbtn.TabStop = false;
            this.pctExitbtn.Click += new System.EventHandler(this.pctExitbtn_Click);
            // 
            // frmLauncher4
            // 
            this.frmLauncher4.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher4.BackgroundImage")));
            this.frmLauncher4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher4.DLL = "frmList";
            this.frmLauncher4.Formulario = "UsuarisORM";
            this.frmLauncher4.Location = new System.Drawing.Point(602, 373);
            this.frmLauncher4.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher4.Name = "frmLauncher4";
            this.frmLauncher4.Size = new System.Drawing.Size(166, 157);
            this.frmLauncher4.TabIndex = 14;
            // 
            // frmLauncher3
            // 
            this.frmLauncher3.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher3.BackgroundImage")));
            this.frmLauncher3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher3.DLL = "frmList";
            this.frmLauncher3.Formulario = "CategoriesUsuaris";
            this.frmLauncher3.Location = new System.Drawing.Point(602, 123);
            this.frmLauncher3.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher3.Name = "frmLauncher3";
            this.frmLauncher3.Size = new System.Drawing.Size(166, 157);
            this.frmLauncher3.TabIndex = 13;
            // 
            // frmLauncher2
            // 
            this.frmLauncher2.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher2.BackgroundImage")));
            this.frmLauncher2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher2.DLL = "frmList";
            this.frmLauncher2.Formulario = "Usuarios";
            this.frmLauncher2.Location = new System.Drawing.Point(67, 373);
            this.frmLauncher2.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher2.Name = "frmLauncher2";
            this.frmLauncher2.Size = new System.Drawing.Size(166, 157);
            this.frmLauncher2.TabIndex = 12;
            // 
            // frmLauncher1
            // 
            this.frmLauncher1.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher1.BackgroundImage")));
            this.frmLauncher1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher1.DLL = "frmList";
            this.frmLauncher1.Formulario = "Species";
            this.frmLauncher1.Location = new System.Drawing.Point(67, 123);
            this.frmLauncher1.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher1.Name = "frmLauncher1";
            this.frmLauncher1.Size = new System.Drawing.Size(166, 157);
            this.frmLauncher1.TabIndex = 11;
            this.frmLauncher1.Load += new System.EventHandler(this.frmLauncher1_Load);
            // 
            // frmLauncher_categorias_usuaris
            // 
            this.frmLauncher_categorias_usuaris.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher_categorias_usuaris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher_categorias_usuaris.BackgroundImage")));
            this.frmLauncher_categorias_usuaris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher_categorias_usuaris.DLL = null;
            this.frmLauncher_categorias_usuaris.Formulario = null;
            this.frmLauncher_categorias_usuaris.Location = new System.Drawing.Point(610, 144);
            this.frmLauncher_categorias_usuaris.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher_categorias_usuaris.Name = "frmLauncher_categorias_usuaris";
            this.frmLauncher_categorias_usuaris.Size = new System.Drawing.Size(132, 129);
            this.frmLauncher_categorias_usuaris.TabIndex = 4;
            // 
            // frmLauncher_Sectors
            // 
            this.frmLauncher_Sectors.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher_Sectors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher_Sectors.BackgroundImage")));
            this.frmLauncher_Sectors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher_Sectors.DLL = null;
            this.frmLauncher_Sectors.Formulario = null;
            this.frmLauncher_Sectors.Location = new System.Drawing.Point(610, 398);
            this.frmLauncher_Sectors.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher_Sectors.Name = "frmLauncher_Sectors";
            this.frmLauncher_Sectors.Size = new System.Drawing.Size(132, 129);
            this.frmLauncher_Sectors.TabIndex = 3;
            // 
            // fmrlauncher_usuaris
            // 
            this.fmrlauncher_usuaris.BackColor = System.Drawing.Color.Transparent;
            this.fmrlauncher_usuaris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fmrlauncher_usuaris.BackgroundImage")));
            this.fmrlauncher_usuaris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fmrlauncher_usuaris.DLL = null;
            this.fmrlauncher_usuaris.Formulario = null;
            this.fmrlauncher_usuaris.Location = new System.Drawing.Point(121, 398);
            this.fmrlauncher_usuaris.Margin = new System.Windows.Forms.Padding(2);
            this.fmrlauncher_usuaris.Name = "fmrlauncher_usuaris";
            this.fmrlauncher_usuaris.Size = new System.Drawing.Size(132, 129);
            this.fmrlauncher_usuaris.TabIndex = 2;
            // 
            // frmLauncher_opcions_menu
            // 
            this.frmLauncher_opcions_menu.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher_opcions_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher_opcions_menu.BackgroundImage")));
            this.frmLauncher_opcions_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher_opcions_menu.DLL = null;
            this.frmLauncher_opcions_menu.Formulario = null;
            this.frmLauncher_opcions_menu.Location = new System.Drawing.Point(121, 654);
            this.frmLauncher_opcions_menu.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher_opcions_menu.Name = "frmLauncher_opcions_menu";
            this.frmLauncher_opcions_menu.Size = new System.Drawing.Size(132, 129);
            this.frmLauncher_opcions_menu.TabIndex = 1;
            // 
            // frmLauncher_especies
            // 
            this.frmLauncher_especies.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher_especies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher_especies.BackgroundImage")));
            this.frmLauncher_especies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher_especies.DLL = null;
            this.frmLauncher_especies.Formulario = null;
            this.frmLauncher_especies.Location = new System.Drawing.Point(121, 144);
            this.frmLauncher_especies.Margin = new System.Windows.Forms.Padding(2);
            this.frmLauncher_especies.Name = "frmLauncher_especies";
            this.frmLauncher_especies.Size = new System.Drawing.Size(132, 129);
            this.frmLauncher_especies.TabIndex = 0;
            // 
            // DataBaseCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmList.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1720, 1080);
            this.Controls.Add(this.frmLauncher4);
            this.Controls.Add(this.frmLauncher3);
            this.Controls.Add(this.frmLauncher2);
            this.Controls.Add(this.lblEspecies);
            this.Controls.Add(this.frmLauncher1);
            this.Controls.Add(this.pctExitbtn);
            this.Controls.Add(this.lblSectors);
            this.Controls.Add(this.lblCategoriesUsuaris);
            this.Controls.Add(this.lblUsuaris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 0);
            this.Name = "DataBaseCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administración de la base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.pctExitbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUserControls.frmLauncher frmLauncher_especies;
        private CustomUserControls.frmLauncher frmLauncher_opcions_menu;
        private CustomUserControls.frmLauncher fmrlauncher_usuaris;
        private CustomUserControls.frmLauncher frmLauncher_Sectors;
        private CustomUserControls.frmLauncher frmLauncher_categorias_usuaris;
        private System.Windows.Forms.Label lblUsuaris;
        private System.Windows.Forms.Label lblEspecies;
        private System.Windows.Forms.Label lblCategoriesUsuaris;
        private System.Windows.Forms.Label lblSectors;
        private System.Windows.Forms.PictureBox pctExitbtn;
        private CustomUserControls.frmLauncher frmLauncher1;
        private CustomUserControls.frmLauncher frmLauncher2;
        private CustomUserControls.frmLauncher frmLauncher3;
        private CustomUserControls.frmLauncher frmLauncher4;
    }
}