
namespace SecureCodePrincipal
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lblTituloSplash = new System.Windows.Forms.Label();
            this.pctboxLogoSplash = new System.Windows.Forms.PictureBox();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(115, 420);
            this.pgbSplash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbSplash.Maximum = 101;
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(920, 50);
            this.pgbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSplash.TabIndex = 0;
            // 
            // lblTituloSplash
            // 
            this.lblTituloSplash.AutoSize = true;
            this.lblTituloSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSplash.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSplash.Location = new System.Drawing.Point(140, 105);
            this.lblTituloSplash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSplash.Name = "lblTituloSplash";
            this.lblTituloSplash.Size = new System.Drawing.Size(406, 94);
            this.lblTituloSplash.TabIndex = 1;
            this.lblTituloSplash.Text = "Secure Core";
            // 
            // pctboxLogoSplash
            // 
            this.pctboxLogoSplash.BackColor = System.Drawing.Color.Transparent;
            this.pctboxLogoSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctboxLogoSplash.BackgroundImage")));
            this.pctboxLogoSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxLogoSplash.Location = new System.Drawing.Point(693, 42);
            this.pctboxLogoSplash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctboxLogoSplash.Name = "pctboxLogoSplash";
            this.pctboxLogoSplash.Size = new System.Drawing.Size(341, 306);
            this.pctboxLogoSplash.TabIndex = 2;
            this.pctboxLogoSplash.TabStop = false;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Enabled = true;
            this.timerSplashScreen.Interval = 200;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(564, 487);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(25, 27);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "0";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 546);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pctboxLogoSplash);
            this.Controls.Add(this.lblTituloSplash);
            this.Controls.Add(this.pgbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLogoSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblTituloSplash;
        private System.Windows.Forms.PictureBox pctboxLogoSplash;
        private System.Windows.Forms.Timer timerSplashScreen;
        private System.Windows.Forms.Label lblProgress;
    }
}

