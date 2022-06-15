namespace PCB_Criptografia
{
    partial class frmCriptografia
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtEncriptat = new System.Windows.Forms.TextBox();
            this.txtDescrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar2 = new System.Windows.Forms.Button();
            this.btnEncriptar2 = new System.Windows.Forms.Button();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescrypted2 = new System.Windows.Forms.TextBox();
            this.txtEncriptat2 = new System.Windows.Forms.TextBox();
            this.txtOriginal2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMissatge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(26, 33);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(96, 40);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Generate keys";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(527, 33);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(96, 40);
            this.btnLoadKey.TabIndex = 2;
            this.btnLoadKey.Text = "Load external key";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(23, 119);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(42, 13);
            this.lblOriginal.TabIndex = 3;
            this.lblOriginal.Text = "Original";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(96, 116);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(274, 20);
            this.txtOriginal.TabIndex = 4;
            // 
            // txtEncriptat
            // 
            this.txtEncriptat.Location = new System.Drawing.Point(96, 152);
            this.txtEncriptat.Name = "txtEncriptat";
            this.txtEncriptat.Size = new System.Drawing.Size(274, 20);
            this.txtEncriptat.TabIndex = 5;
            // 
            // txtDescrypted
            // 
            this.txtDescrypted.Location = new System.Drawing.Point(96, 193);
            this.txtDescrypted.Name = "txtDescrypted";
            this.txtDescrypted.Size = new System.Drawing.Size(274, 20);
            this.txtDescrypted.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encriptat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desencriptat";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(26, 250);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(439, 138);
            this.txtKey.TabIndex = 9;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(390, 113);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 10;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(390, 151);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencriptar.TabIndex = 11;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnDesencriptar2
            // 
            this.btnDesencriptar2.Location = new System.Drawing.Point(865, 152);
            this.btnDesencriptar2.Name = "btnDesencriptar2";
            this.btnDesencriptar2.Size = new System.Drawing.Size(75, 23);
            this.btnDesencriptar2.TabIndex = 20;
            this.btnDesencriptar2.Text = "Desencriptar";
            this.btnDesencriptar2.UseVisualStyleBackColor = true;
            this.btnDesencriptar2.Click += new System.EventHandler(this.btnDesencriptar2_Click);
            // 
            // btnEncriptar2
            // 
            this.btnEncriptar2.Location = new System.Drawing.Point(865, 114);
            this.btnEncriptar2.Name = "btnEncriptar2";
            this.btnEncriptar2.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar2.TabIndex = 19;
            this.btnEncriptar2.Text = "Encriptar";
            this.btnEncriptar2.UseVisualStyleBackColor = true;
            this.btnEncriptar2.Click += new System.EventHandler(this.btnEncriptar2_Click);
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(527, 250);
            this.txtKey2.Multiline = true;
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(413, 138);
            this.txtKey2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Desencriptat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Encriptat";
            // 
            // txtDescrypted2
            // 
            this.txtDescrypted2.Location = new System.Drawing.Point(597, 193);
            this.txtDescrypted2.Name = "txtDescrypted2";
            this.txtDescrypted2.Size = new System.Drawing.Size(238, 20);
            this.txtDescrypted2.TabIndex = 15;
            // 
            // txtEncriptat2
            // 
            this.txtEncriptat2.Location = new System.Drawing.Point(597, 152);
            this.txtEncriptat2.Name = "txtEncriptat2";
            this.txtEncriptat2.Size = new System.Drawing.Size(238, 20);
            this.txtEncriptat2.TabIndex = 14;
            // 
            // txtOriginal2
            // 
            this.txtOriginal2.Location = new System.Drawing.Point(597, 116);
            this.txtOriginal2.Name = "txtOriginal2";
            this.txtOriginal2.Size = new System.Drawing.Size(238, 20);
            this.txtOriginal2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Original";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtMissatge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(26, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Port";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Items.AddRange(new object[] {
            "6700",
            "6800"});
            this.cmbPorts.Location = new System.Drawing.Point(98, 73);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(82, 21);
            this.cmbPorts.TabIndex = 29;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(210, 71);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMissatge
            // 
            this.txtMissatge.Location = new System.Drawing.Point(98, 31);
            this.txtMissatge.MaxLength = 16;
            this.txtMissatge.Name = "txtMissatge";
            this.txtMissatge.Size = new System.Drawing.Size(187, 20);
            this.txtMissatge.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Missatge";
            // 
            // frmCriptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesencriptar2);
            this.Controls.Add(this.btnEncriptar2);
            this.Controls.Add(this.txtKey2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescrypted2);
            this.Controls.Add(this.txtEncriptat2);
            this.Controls.Add(this.txtOriginal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrypted);
            this.Controls.Add(this.txtEncriptat);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnLoadKey);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmCriptografia";
            this.Text = "PCB Criptografia i TCP";
            this.Load += new System.EventHandler(this.frmCriptografia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtEncriptat;
        private System.Windows.Forms.TextBox txtDescrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnDesencriptar2;
        private System.Windows.Forms.Button btnEncriptar2;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescrypted2;
        private System.Windows.Forms.TextBox txtEncriptat2;
        private System.Windows.Forms.TextBox txtOriginal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMissatge;
        private System.Windows.Forms.Label label7;
    }
}

