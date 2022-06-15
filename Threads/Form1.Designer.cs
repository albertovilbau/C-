
namespace Sprint2Threads
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
            this.lblnumfitxers = new System.Windows.Forms.Label();
            this.lblnumlletres = new System.Windows.Forms.Label();
            this.txtnumfitxers = new System.Windows.Forms.TextBox();
            this.txtnumlletres = new System.Windows.Forms.TextBox();
            this.btnGenerarCodificacio = new System.Windows.Forms.Button();
            this.btnGenerarFitxers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumfitxers
            // 
            this.lblnumfitxers.AutoSize = true;
            this.lblnumfitxers.Location = new System.Drawing.Point(53, 33);
            this.lblnumfitxers.Name = "lblnumfitxers";
            this.lblnumfitxers.Size = new System.Drawing.Size(92, 13);
            this.lblnumfitxers.TabIndex = 0;
            this.lblnumfitxers.Text = "Número de fitxers:";
            // 
            // lblnumlletres
            // 
            this.lblnumlletres.AutoSize = true;
            this.lblnumlletres.Location = new System.Drawing.Point(53, 65);
            this.lblnumlletres.Name = "lblnumlletres";
            this.lblnumlletres.Size = new System.Drawing.Size(92, 13);
            this.lblnumlletres.TabIndex = 1;
            this.lblnumlletres.Text = "Número de lletres:";
            // 
            // txtnumfitxers
            // 
            this.txtnumfitxers.Location = new System.Drawing.Point(151, 30);
            this.txtnumfitxers.Name = "txtnumfitxers";
            this.txtnumfitxers.Size = new System.Drawing.Size(38, 20);
            this.txtnumfitxers.TabIndex = 2;
            // 
            // txtnumlletres
            // 
            this.txtnumlletres.Location = new System.Drawing.Point(151, 62);
            this.txtnumlletres.Name = "txtnumlletres";
            this.txtnumlletres.Size = new System.Drawing.Size(38, 20);
            this.txtnumlletres.TabIndex = 3;
            // 
            // btnGenerarCodificacio
            // 
            this.btnGenerarCodificacio.Location = new System.Drawing.Point(56, 107);
            this.btnGenerarCodificacio.Name = "btnGenerarCodificacio";
            this.btnGenerarCodificacio.Size = new System.Drawing.Size(75, 40);
            this.btnGenerarCodificacio.TabIndex = 4;
            this.btnGenerarCodificacio.Text = "Generar codificació";
            this.btnGenerarCodificacio.UseVisualStyleBackColor = true;
            this.btnGenerarCodificacio.Click += new System.EventHandler(this.btnGenerarCodificacio_Click);
            // 
            // btnGenerarFitxers
            // 
            this.btnGenerarFitxers.Location = new System.Drawing.Point(160, 107);
            this.btnGenerarFitxers.Name = "btnGenerarFitxers";
            this.btnGenerarFitxers.Size = new System.Drawing.Size(75, 40);
            this.btnGenerarFitxers.TabIndex = 5;
            this.btnGenerarFitxers.Text = "Generar fitxers";
            this.btnGenerarFitxers.UseVisualStyleBackColor = true;
            this.btnGenerarFitxers.Click += new System.EventHandler(this.btnGenerarFitxers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 178);
            this.Controls.Add(this.btnGenerarFitxers);
            this.Controls.Add(this.btnGenerarCodificacio);
            this.Controls.Add(this.txtnumlletres);
            this.Controls.Add(this.txtnumfitxers);
            this.Controls.Add(this.lblnumlletres);
            this.Controls.Add(this.lblnumfitxers);
            this.Name = "Form1";
            this.Text = "Processat de fitxers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumfitxers;
        private System.Windows.Forms.Label lblnumlletres;
        private System.Windows.Forms.TextBox txtnumfitxers;
        private System.Windows.Forms.TextBox txtnumlletres;
        private System.Windows.Forms.Button btnGenerarCodificacio;
        private System.Windows.Forms.Button btnGenerarFitxers;
    }
}

