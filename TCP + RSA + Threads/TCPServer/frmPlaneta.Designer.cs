namespace PracticaTCP
{
    partial class frmServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegenerarInnerEncryptionData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParelldeClaus = new System.Windows.Forms.Button();
            this.cmboxPlanet = new System.Windows.Forms.ComboBox();
            this.txtCodiValidacio = new System.Windows.Forms.TextBox();
            this.btnChangeCodi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txb_port);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(78, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrir puerto";
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(38, 22);
            this.txb_port.Margin = new System.Windows.Forms.Padding(2);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(63, 20);
            this.txb_port.TabIndex = 4;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Black;
            this.btn_connect.Location = new System.Drawing.Point(102, 20);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(88, 20);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connectar";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_desconnect.Enabled = false;
            this.btn_desconnect.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_desconnect.Location = new System.Drawing.Point(572, 23);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(86, 20);
            this.btn_desconnect.TabIndex = 4;
            this.btn_desconnect.Text = "Desconnectar";
            this.btn_desconnect.UseVisualStyleBackColor = false;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbx_Missatges);
            this.groupBox2.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(78, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(306, 227);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nave envía";
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbx_Missatges.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.Location = new System.Drawing.Point(4, 17);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(299, 199);
            this.lbx_Missatges.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnRegenerarInnerEncryptionData);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnParelldeClaus);
            this.groupBox3.Controls.Add(this.cmboxPlanet);
            this.groupBox3.Controls.Add(this.txtCodiValidacio);
            this.groupBox3.Controls.Add(this.btnChangeCodi);
            this.groupBox3.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox3.Location = new System.Drawing.Point(387, 82);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(310, 259);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información";
            // 
            // btnRegenerarInnerEncryptionData
            // 
            this.btnRegenerarInnerEncryptionData.BackColor = System.Drawing.Color.Black;
            this.btnRegenerarInnerEncryptionData.Location = new System.Drawing.Point(27, 153);
            this.btnRegenerarInnerEncryptionData.Name = "btnRegenerarInnerEncryptionData";
            this.btnRegenerarInnerEncryptionData.Size = new System.Drawing.Size(258, 39);
            this.btnRegenerarInnerEncryptionData.TabIndex = 10;
            this.btnRegenerarInnerEncryptionData.Text = "Regenerar Inner Encryption Data";
            this.btnRegenerarInnerEncryptionData.UseVisualStyleBackColor = false;
            this.btnRegenerarInnerEncryptionData.Click += new System.EventHandler(this.btnRegenerarInnerEncryptionData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Planeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo de validación:";
            // 
            // btnParelldeClaus
            // 
            this.btnParelldeClaus.BackColor = System.Drawing.Color.Black;
            this.btnParelldeClaus.Location = new System.Drawing.Point(24, 108);
            this.btnParelldeClaus.Name = "btnParelldeClaus";
            this.btnParelldeClaus.Size = new System.Drawing.Size(121, 39);
            this.btnParelldeClaus.TabIndex = 7;
            this.btnParelldeClaus.Text = "Generar nou parell de claus";
            this.btnParelldeClaus.UseVisualStyleBackColor = false;
            this.btnParelldeClaus.Click += new System.EventHandler(this.btnParelldeClaus_Click);
            // 
            // cmboxPlanet
            // 
            this.cmboxPlanet.FormattingEnabled = true;
            this.cmboxPlanet.Location = new System.Drawing.Point(164, 72);
            this.cmboxPlanet.Name = "cmboxPlanet";
            this.cmboxPlanet.Size = new System.Drawing.Size(121, 21);
            this.cmboxPlanet.TabIndex = 6;
            this.cmboxPlanet.SelectedIndexChanged += new System.EventHandler(this.cmboxPlanet_SelectedIndexChanged);
            // 
            // txtCodiValidacio
            // 
            this.txtCodiValidacio.Location = new System.Drawing.Point(24, 72);
            this.txtCodiValidacio.Name = "txtCodiValidacio";
            this.txtCodiValidacio.ReadOnly = true;
            this.txtCodiValidacio.Size = new System.Drawing.Size(121, 20);
            this.txtCodiValidacio.TabIndex = 5;
            // 
            // btnChangeCodi
            // 
            this.btnChangeCodi.BackColor = System.Drawing.Color.Black;
            this.btnChangeCodi.Location = new System.Drawing.Point(164, 108);
            this.btnChangeCodi.Name = "btnChangeCodi";
            this.btnChangeCodi.Size = new System.Drawing.Size(121, 39);
            this.btnChangeCodi.TabIndex = 4;
            this.btnChangeCodi.Text = "Cambiar codi validacio";
            this.btnChangeCodi.UseVisualStyleBackColor = false;
            this.btnChangeCodi.Click += new System.EventHandler(this.btnChangeCodi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(302, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlanetaPACS.Properties.Resources.backgroundplaneta2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_desconnect);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServer";
            this.Text = "Planeta";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnParelldeClaus;
        private System.Windows.Forms.ComboBox cmboxPlanet;
        private System.Windows.Forms.TextBox txtCodiValidacio;
        private System.Windows.Forms.Button btnChangeCodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegenerarInnerEncryptionData;
    }
}

