namespace TCPClient
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.gbx_comprovacions = new System.Windows.Forms.GroupBox();
            this.pnl_status = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_enviararchivo = new System.Windows.Forms.Button();
            this.txb_ruta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbox_mensajes = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.gbx_comprovacions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_status)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_desconnect.Enabled = false;
            this.btn_desconnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_desconnect.Location = new System.Drawing.Point(520, 372);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(87, 23);
            this.btn_desconnect.TabIndex = 12;
            this.btn_desconnect.Text = "Desconnectar";
            this.btn_desconnect.UseVisualStyleBackColor = false;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_sendMessage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_message);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(414, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(322, 102);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviar mensaje";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.BackColor = System.Drawing.Color.Black;
            this.btn_sendMessage.Enabled = false;
            this.btn_sendMessage.Location = new System.Drawing.Point(218, 62);
            this.btn_sendMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(98, 27);
            this.btn_sendMessage.TabIndex = 6;
            this.btn_sendMessage.Text = "Enviar missatge";
            this.btn_sendMessage.UseVisualStyleBackColor = false;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensaje";
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(58, 18);
            this.txb_message.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(260, 36);
            this.txb_message.TabIndex = 2;
            // 
            // gbx_comprovacions
            // 
            this.gbx_comprovacions.BackColor = System.Drawing.Color.Transparent;
            this.gbx_comprovacions.Controls.Add(this.pnl_status);
            this.gbx_comprovacions.Controls.Add(this.label4);
            this.gbx_comprovacions.Controls.Add(this.txb_port);
            this.gbx_comprovacions.Controls.Add(this.label2);
            this.gbx_comprovacions.Controls.Add(this.txb_ip);
            this.gbx_comprovacions.Controls.Add(this.lb_statusInfo);
            this.gbx_comprovacions.Controls.Add(this.label1);
            this.gbx_comprovacions.Controls.Add(this.lbx_console);
            this.gbx_comprovacions.Controls.Add(this.btn_comprovarXarxa);
            this.gbx_comprovacions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbx_comprovacions.Location = new System.Drawing.Point(82, 63);
            this.gbx_comprovacions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_comprovacions.Name = "gbx_comprovacions";
            this.gbx_comprovacions.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_comprovacions.Size = new System.Drawing.Size(328, 199);
            this.gbx_comprovacions.TabIndex = 9;
            this.gbx_comprovacions.TabStop = false;
            this.gbx_comprovacions.Text = "Comrobar enlace";
            // 
            // pnl_status
            // 
            this.pnl_status.Image = global::NavePACS.Properties.Resources.disconnected;
            this.pnl_status.Location = new System.Drawing.Point(16, 106);
            this.pnl_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(90, 89);
            this.pnl_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_status.TabIndex = 9;
            this.pnl_status.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puerto";
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(56, 51);
            this.txb_port.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(55, 20);
            this.txb_port.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(56, 26);
            this.txb_ip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(101, 20);
            this.txb_ip.TabIndex = 5;
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(122, 95);
            this.lb_statusInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(0, 13);
            this.lb_statusInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "status";
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.Color.Black;
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Info;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(120, 115);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(201, 82);
            this.lbx_console.TabIndex = 1;
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(236, 18);
            this.btn_comprovarXarxa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(83, 63);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.Text = " Comprobar enlace";
            this.btn_comprovarXarxa.UseVisualStyleBackColor = false;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_examinar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_enviararchivo);
            this.groupBox1.Controls.Add(this.txb_ruta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(414, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar fichero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ruta";
            // 
            // btn_examinar
            // 
            this.btn_examinar.BackColor = System.Drawing.Color.Black;
            this.btn_examinar.Enabled = false;
            this.btn_examinar.Location = new System.Drawing.Point(96, 55);
            this.btn_examinar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(98, 27);
            this.btn_examinar.TabIndex = 16;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = false;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-32, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Arxiu";
            // 
            // btn_enviararchivo
            // 
            this.btn_enviararchivo.BackColor = System.Drawing.Color.Black;
            this.btn_enviararchivo.Enabled = false;
            this.btn_enviararchivo.Location = new System.Drawing.Point(198, 55);
            this.btn_enviararchivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_enviararchivo.Name = "btn_enviararchivo";
            this.btn_enviararchivo.Size = new System.Drawing.Size(98, 27);
            this.btn_enviararchivo.TabIndex = 14;
            this.btn_enviararchivo.Text = "Enviar archivo";
            this.btn_enviararchivo.UseVisualStyleBackColor = false;
            this.btn_enviararchivo.Click += new System.EventHandler(this.btn_enviararchivo_Click);
            // 
            // txb_ruta
            // 
            this.txb_ruta.Location = new System.Drawing.Point(74, 33);
            this.txb_ruta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_ruta.Name = "txb_ruta";
            this.txb_ruta.Size = new System.Drawing.Size(224, 20);
            this.txb_ruta.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lbox_mensajes);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(82, 266);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(654, 101);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servidor envía";
            // 
            // lbox_mensajes
            // 
            this.lbox_mensajes.BackColor = System.Drawing.Color.Black;
            this.lbox_mensajes.ForeColor = System.Drawing.SystemColors.Info;
            this.lbox_mensajes.FormattingEnabled = true;
            this.lbox_mensajes.Location = new System.Drawing.Point(4, 17);
            this.lbox_mensajes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbox_mensajes.Name = "lbox_mensajes";
            this.lbox_mensajes.Size = new System.Drawing.Size(318, 82);
            this.lbox_mensajes.TabIndex = 2;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_desconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_comprovacions);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 507);
            this.MinimumSize = new System.Drawing.Size(840, 507);
            this.Name = "frmClient";
            this.Text = "Nave";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_comprovacions.ResumeLayout(false);
            this.gbx_comprovacions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_status)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.GroupBox gbx_comprovacions;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.PictureBox pnl_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_enviararchivo;
        private System.Windows.Forms.TextBox txb_ruta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lbox_mensajes;
    }
}

