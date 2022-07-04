
namespace frmList
{
    partial class dbadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbadmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNou = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dbTexBox3 = new InheritedControls.DBTexBox();
            this.dbTexBox2 = new InheritedControls.DBTexBox();
            this.btnCargarUsuarios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(584, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(440, 519);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(405, 122);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(75, 23);
            this.btnNou.TabIndex = 2;
            this.btnNou.Text = "Nuevo";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre archivo: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmList.Properties.Resources.Logo_Alta_Resolució;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 145);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbDB
            // 
            this.cmbDB.FormattingEnabled = true;
            this.cmbDB.Items.AddRange(new object[] {
            "Nominas",
            "IRPF"});
            this.cmbDB.Location = new System.Drawing.Point(31, 521);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new System.Drawing.Size(121, 21);
            this.cmbDB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione la base de datos:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(170, 519);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dbTexBox3
            // 
            this.dbTexBox3.CampoDB = "archivo";
            this.dbTexBox3.Location = new System.Drawing.Point(405, 70);
            this.dbTexBox3.Name = "dbTexBox3";
            this.dbTexBox3.Size = new System.Drawing.Size(189, 20);
            this.dbTexBox3.TabIndex = 9;
            // 
            // dbTexBox2
            // 
            this.dbTexBox2.CampoDB = "mail";
            this.dbTexBox2.Location = new System.Drawing.Point(405, 36);
            this.dbTexBox2.Name = "dbTexBox2";
            this.dbTexBox2.Size = new System.Drawing.Size(189, 20);
            this.dbTexBox2.TabIndex = 8;
            // 
            // btnCargarUsuarios
            // 
            this.btnCargarUsuarios.Location = new System.Drawing.Point(504, 122);
            this.btnCargarUsuarios.Name = "btnCargarUsuarios";
            this.btnCargarUsuarios.Size = new System.Drawing.Size(90, 23);
            this.btnCargarUsuarios.TabIndex = 15;
            this.btnCargarUsuarios.Text = "Cargar usuarios";
            this.btnCargarUsuarios.UseVisualStyleBackColor = true;
            this.btnCargarUsuarios.Click += new System.EventHandler(this.btnCargarUsuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(521, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dbadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarUsuarios);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dbTexBox3);
            this.Controls.Add(this.dbTexBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNou);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dbadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private InheritedControls.DBTexBox dbTexBox2;
        private InheritedControls.DBTexBox dbTexBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCargarUsuarios;
        private System.Windows.Forms.Button btnSalir;
    }
}