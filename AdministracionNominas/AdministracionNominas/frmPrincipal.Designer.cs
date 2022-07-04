
namespace AdministracionNominas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pctSend = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblServerDB = new System.Windows.Forms.Label();
            this.dbTimer = new System.Windows.Forms.Timer(this.components);
            this.pctSendIrpf = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.frmLauncher1 = new CustomUserControls.frmLauncher();
            this.pctBoxCheck = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSendIrpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(296, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(631, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración de Nóminas CIM-UPC";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(262, 141);
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(248, 237);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(258, 20);
            this.lblUsuarios.TabIndex = 3;
            this.lblUsuarios.Text = "Añadir, editar o borrar usuarios";
            // 
            // pctSend
            // 
            this.pctSend.BackColor = System.Drawing.Color.Transparent;
            this.pctSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSend.BackgroundImage")));
            this.pctSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSend.Location = new System.Drawing.Point(529, 197);
            this.pctSend.Name = "pctSend";
            this.pctSend.Size = new System.Drawing.Size(116, 106);
            this.pctSend.TabIndex = 5;
            this.pctSend.TabStop = false;
            this.pctSend.Click += new System.EventHandler(this.pctSend_Click);
            this.pctSend.MouseEnter += new System.EventHandler(this.pctSend_MouseEnter);
            this.pctSend.MouseLeave += new System.EventHandler(this.pctSend_MouseLeave);
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctExit.BackgroundImage")));
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctExit.Location = new System.Drawing.Point(875, 509);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(48, 47);
            this.pctExit.TabIndex = 6;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            this.pctExit.MouseEnter += new System.EventHandler(this.pctExit_MouseEnter);
            this.pctExit.MouseLeave += new System.EventHandler(this.pctExit_MouseLeave);
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.Location = new System.Drawing.Point(248, 409);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(105, 20);
            this.lblIRPF.TabIndex = 7;
            this.lblIRPF.Text = "Enviar IRPF";
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.Location = new System.Drawing.Point(653, 238);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(131, 20);
            this.lblSend.TabIndex = 9;
            this.lblSend.Text = "Enviar nóminas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Conexión con la Base de datos: ";
            // 
            // lblServerDB
            // 
            this.lblServerDB.AutoSize = true;
            this.lblServerDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerDB.Location = new System.Drawing.Point(533, 84);
            this.lblServerDB.Name = "lblServerDB";
            this.lblServerDB.Size = new System.Drawing.Size(57, 20);
            this.lblServerDB.TabIndex = 12;
            this.lblServerDB.Text = "label3";
            // 
            // dbTimer
            // 
            this.dbTimer.Enabled = true;
            this.dbTimer.Interval = 30000;
            this.dbTimer.Tick += new System.EventHandler(this.dbTimer_Tick);
            // 
            // pctSendIrpf
            // 
            this.pctSendIrpf.BackColor = System.Drawing.Color.Transparent;
            this.pctSendIrpf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSendIrpf.BackgroundImage")));
            this.pctSendIrpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSendIrpf.Location = new System.Drawing.Point(96, 365);
            this.pctSendIrpf.Name = "pctSendIrpf";
            this.pctSendIrpf.Size = new System.Drawing.Size(147, 106);
            this.pctSendIrpf.TabIndex = 13;
            this.pctSendIrpf.TabStop = false;
            this.pctSendIrpf.Click += new System.EventHandler(this.pctSendIrpf_Click);
            this.pctSendIrpf.MouseEnter += new System.EventHandler(this.pctSendIrpf_MouseEnter);
            this.pctSendIrpf.MouseLeave += new System.EventHandler(this.pctSendIrpf_MouseLeave);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(2, 549);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(68, 16);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "lblVersion";
            // 
            // frmLauncher1
            // 
            this.frmLauncher1.BackColor = System.Drawing.Color.Transparent;
            this.frmLauncher1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmLauncher1.BackgroundImage")));
            this.frmLauncher1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmLauncher1.DLL = "frmList";
            this.frmLauncher1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frmLauncher1.Formulario = "dbadmin";
            this.frmLauncher1.Location = new System.Drawing.Point(119, 196);
            this.frmLauncher1.Name = "frmLauncher1";
            this.frmLauncher1.Size = new System.Drawing.Size(114, 109);
            this.frmLauncher1.TabIndex = 2;
            this.frmLauncher1.MouseEnter += new System.EventHandler(this.frmLauncher1_MouseEnter);
            this.frmLauncher1.MouseLeave += new System.EventHandler(this.frmLauncher1_MouseLeave);
            // 
            // pctBoxCheck
            // 
            this.pctBoxCheck.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxCheck.BackgroundImage")));
            this.pctBoxCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCheck.Location = new System.Drawing.Point(537, 380);
            this.pctBoxCheck.Name = "pctBoxCheck";
            this.pctBoxCheck.Size = new System.Drawing.Size(92, 91);
            this.pctBoxCheck.TabIndex = 15;
            this.pctBoxCheck.TabStop = false;
            this.pctBoxCheck.Click += new System.EventHandler(this.pctBoxCheck_Click);
            this.pctBoxCheck.MouseEnter += new System.EventHandler(this.pctBoxCheck_MouseEnter);
            this.pctBoxCheck.MouseLeave += new System.EventHandler(this.pctBoxCheck_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Realizar check";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctBoxCheck);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pctSendIrpf);
            this.Controls.Add(this.lblServerDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.pctSend);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.frmLauncher1);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Nominas CIM-UPC";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSendIrpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctLogo;
        private CustomUserControls.frmLauncher frmLauncher1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox pctSend;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblServerDB;
        private System.Windows.Forms.Timer dbTimer;
        private System.Windows.Forms.PictureBox pctSendIrpf;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pctBoxCheck;
        private System.Windows.Forms.Label label3;
    }
}

