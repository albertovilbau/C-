
namespace frmList
{
    partial class DBPlantilla
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
            this.dtgDB = new System.Windows.Forms.DataGridView();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDB
            // 
            this.dtgDB.AllowUserToAddRows = false;
            this.dtgDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDB.Location = new System.Drawing.Point(56, 102);
            this.dtgDB.Name = "dtgDB";
            this.dtgDB.ReadOnly = true;
            this.dtgDB.Size = new System.Drawing.Size(661, 298);
            this.dtgDB.TabIndex = 0;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(571, 410);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(75, 23);
            this.btnActualitzar.TabIndex = 1;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(652, 410);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(65, 23);
            this.btnNou.TabIndex = 2;
            this.btnNou.Text = "Nou";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // DBPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmList.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 465);
            this.Controls.Add(this.btnNou);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.dtgDB);
            this.Name = "DBPlantilla";
            this.Text = "Data Base Admins";
            this.Load += new System.EventHandler(this.DataBaseAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDB;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnNou;
    }
}