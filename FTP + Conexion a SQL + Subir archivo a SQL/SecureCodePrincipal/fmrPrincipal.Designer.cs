
namespace SecureCodePrincipal
{
    partial class fmrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.userlbltitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmLauncher1 = new CustomUserControls.frmLauncher();
            this.panelIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierda
            // 
            resources.ApplyResources(this.panelIzquierda, "panelIzquierda");
            this.panelIzquierda.Controls.Add(this.pictureBox1);
            this.panelIzquierda.Controls.Add(this.pctExit);
            this.panelIzquierda.Controls.Add(this.frmLauncher1);
            this.panelIzquierda.Controls.Add(this.lbluser);
            this.panelIzquierda.Controls.Add(this.userlbltitle);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierda_Paint);
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pctExit, "pctExit");
            this.pctExit.Name = "pctExit";
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lbluser
            // 
            resources.ApplyResources(this.lbluser, "lbluser");
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Name = "lbluser";
            // 
            // userlbltitle
            // 
            resources.ApplyResources(this.userlbltitle, "userlbltitle");
            this.userlbltitle.BackColor = System.Drawing.Color.Transparent;
            this.userlbltitle.Name = "userlbltitle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLauncher1
            // 
            this.frmLauncher1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.frmLauncher1, "frmLauncher1");
            this.frmLauncher1.DLL = "frmList";
            this.frmLauncher1.Formulario = "DataBaseCenter";
            this.frmLauncher1.Name = "frmLauncher1";
            // 
            // fmrPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelIzquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            this.panelIzquierda.ResumeLayout(false);
            this.panelIzquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label userlbltitle;
        private CustomUserControls.frmLauncher frmlauncher_dbadmin;
        private CustomUserControls.frmLauncher frmLauncher1;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}