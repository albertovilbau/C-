namespace PCB_Fils
{
    partial class frmFils
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
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnEspera = new System.Windows.Forms.Button();
            this.btnConfigura = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.lblFilActual = new System.Windows.Forms.Label();
            this.txtLletra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDespesa = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.grpDespesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParametre
            // 
            this.btnParametre.Location = new System.Drawing.Point(47, 46);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(99, 23);
            this.btnParametre.TabIndex = 0;
            this.btnParametre.Text = "Fil paràmetre";
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // btnEspera
            // 
            this.btnEspera.Location = new System.Drawing.Point(167, 46);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(84, 23);
            this.btnEspera.TabIndex = 1;
            this.btnEspera.Text = "Fil  en espera";
            this.btnEspera.UseVisualStyleBackColor = true;
            this.btnEspera.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // btnConfigura
            // 
            this.btnConfigura.Location = new System.Drawing.Point(287, 46);
            this.btnConfigura.Name = "btnConfigura";
            this.btnConfigura.Size = new System.Drawing.Size(112, 23);
            this.btnConfigura.TabIndex = 2;
            this.btnConfigura.Text = "Configuració de fils";
            this.btnConfigura.UseVisualStyleBackColor = true;
            this.btnConfigura.Click += new System.EventHandler(this.btnConfigura_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(47, 122);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultat.Size = new System.Drawing.Size(508, 300);
            this.txtResultat.TabIndex = 3;
            // 
            // lblFilActual
            // 
            this.lblFilActual.AutoSize = true;
            this.lblFilActual.Location = new System.Drawing.Point(576, 98);
            this.lblFilActual.Name = "lblFilActual";
            this.lblFilActual.Size = new System.Drawing.Size(0, 13);
            this.lblFilActual.TabIndex = 4;
            // 
            // txtLletra
            // 
            this.txtLletra.Location = new System.Drawing.Point(82, 88);
            this.txtLletra.Name = "txtLletra";
            this.txtLletra.Size = new System.Drawing.Size(39, 20);
            this.txtLletra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "lletra";
            // 
            // grpDespesa
            // 
            this.grpDespesa.Controls.Add(this.label3);
            this.grpDespesa.Controls.Add(this.txtDespesa);
            this.grpDespesa.Controls.Add(this.label2);
            this.grpDespesa.Controls.Add(this.txtImport);
            this.grpDespesa.Controls.Add(this.btnDespesa);
            this.grpDespesa.Location = new System.Drawing.Point(579, 122);
            this.grpDespesa.Name = "grpDespesa";
            this.grpDespesa.Size = new System.Drawing.Size(200, 184);
            this.grpDespesa.TabIndex = 7;
            this.grpDespesa.TabStop = false;
            this.grpDespesa.Text = "Càlcul despesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Despesa";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Enabled = false;
            this.txtDespesa.Location = new System.Drawing.Point(80, 138);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(83, 20);
            this.txtDespesa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Import";
            // 
            // txtImport
            // 
            this.txtImport.Location = new System.Drawing.Point(73, 33);
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(83, 20);
            this.txtImport.TabIndex = 7;
            // 
            // btnDespesa
            // 
            this.btnDespesa.Location = new System.Drawing.Point(73, 59);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(99, 23);
            this.btnDespesa.TabIndex = 1;
            this.btnDespesa.Text = "Calcula despesa";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // frmFils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.grpDespesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLletra);
            this.Controls.Add(this.lblFilActual);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnConfigura);
            this.Controls.Add(this.btnEspera);
            this.Controls.Add(this.btnParametre);
            this.Name = "frmFils";
            this.Text = "Fils";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFils_FormClosed);
            this.grpDespesa.ResumeLayout(false);
            this.grpDespesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.Button btnEspera;
        private System.Windows.Forms.Button btnConfigura;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label lblFilActual;
        private System.Windows.Forms.TextBox txtLletra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDespesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Button btnDespesa;
    }
}

