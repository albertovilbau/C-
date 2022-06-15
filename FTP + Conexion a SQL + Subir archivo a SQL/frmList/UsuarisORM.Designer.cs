
namespace frmList
{
    partial class UsuarisORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarisORM));
            this.dtgUsuaris = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNou = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.txtboxIdEspecie = new Custom_Inherited_Controls.SWTextBox();
            this.txtBoxIdPlanet = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxPhoto = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIdUserCategory = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIdUserRank = new Custom_Inherited_Controls.SWTextBox();
            this.txtPassword = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxLogin = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxUsername = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxCodeUser = new Custom_Inherited_Controls.SWTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxIdUser = new Custom_Inherited_Controls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuaris
            // 
            this.dtgUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuaris.Location = new System.Drawing.Point(28, 12);
            this.dtgUsuaris.Name = "dtgUsuaris";
            this.dtgUsuaris.Size = new System.Drawing.Size(1286, 342);
            this.dtgUsuaris.TabIndex = 0;
            this.dtgUsuaris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgUsuaris_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1351, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "id Especie: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1363, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "id Planet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1374, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Photo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1327, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Id User Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1340, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Id User Rank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1357, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1378, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1355, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1353, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Code User:";
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(1354, 330);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(75, 23);
            this.btnNou.TabIndex = 39;
            this.btnNou.Text = "Nou";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(1441, 330);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(75, 23);
            this.btnActualitzar.TabIndex = 40;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // txtboxIdEspecie
            // 
            this.txtboxIdEspecie.CampoDB = "idSpecie";
            this.txtboxIdEspecie.CampoVacio = false;
            this.txtboxIdEspecie.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdEspecie.Forana = false;
            this.txtboxIdEspecie.Location = new System.Drawing.Point(1416, 280);
            this.txtboxIdEspecie.Name = "txtboxIdEspecie";
            this.txtboxIdEspecie.NombreControl = null;
            this.txtboxIdEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdEspecie.TabIndex = 29;
            // 
            // txtBoxIdPlanet
            // 
            this.txtBoxIdPlanet.CampoDB = "idPlanet";
            this.txtBoxIdPlanet.CampoVacio = false;
            this.txtBoxIdPlanet.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtBoxIdPlanet.Forana = false;
            this.txtBoxIdPlanet.Location = new System.Drawing.Point(1416, 253);
            this.txtBoxIdPlanet.Name = "txtBoxIdPlanet";
            this.txtBoxIdPlanet.NombreControl = null;
            this.txtBoxIdPlanet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdPlanet.TabIndex = 28;
            // 
            // txtboxPhoto
            // 
            this.txtboxPhoto.CampoDB = "Photo";
            this.txtboxPhoto.CampoVacio = false;
            this.txtboxPhoto.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxPhoto.Forana = false;
            this.txtboxPhoto.Location = new System.Drawing.Point(1416, 227);
            this.txtboxPhoto.Name = "txtboxPhoto";
            this.txtboxPhoto.NombreControl = null;
            this.txtboxPhoto.Size = new System.Drawing.Size(100, 20);
            this.txtboxPhoto.TabIndex = 27;
            // 
            // txtboxIdUserCategory
            // 
            this.txtboxIdUserCategory.CampoDB = "idUserCategory";
            this.txtboxIdUserCategory.CampoVacio = false;
            this.txtboxIdUserCategory.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdUserCategory.Forana = false;
            this.txtboxIdUserCategory.Location = new System.Drawing.Point(1416, 193);
            this.txtboxIdUserCategory.Name = "txtboxIdUserCategory";
            this.txtboxIdUserCategory.NombreControl = null;
            this.txtboxIdUserCategory.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdUserCategory.TabIndex = 26;
            // 
            // txtboxIdUserRank
            // 
            this.txtboxIdUserRank.CampoDB = "idUserRank";
            this.txtboxIdUserRank.CampoVacio = false;
            this.txtboxIdUserRank.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdUserRank.Forana = false;
            this.txtboxIdUserRank.Location = new System.Drawing.Point(1416, 166);
            this.txtboxIdUserRank.Name = "txtboxIdUserRank";
            this.txtboxIdUserRank.NombreControl = null;
            this.txtboxIdUserRank.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdUserRank.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.CampoDB = "Password";
            this.txtPassword.CampoVacio = false;
            this.txtPassword.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtPassword.Forana = false;
            this.txtPassword.Location = new System.Drawing.Point(1416, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NombreControl = null;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.CampoDB = "Login";
            this.txtboxLogin.CampoVacio = false;
            this.txtboxLogin.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxLogin.Forana = false;
            this.txtboxLogin.Location = new System.Drawing.Point(1416, 112);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.NombreControl = null;
            this.txtboxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxLogin.TabIndex = 23;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.CampoDB = "UserName";
            this.txtboxUsername.CampoVacio = false;
            this.txtboxUsername.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxUsername.Forana = false;
            this.txtboxUsername.Location = new System.Drawing.Point(1416, 85);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.NombreControl = null;
            this.txtboxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsername.TabIndex = 22;
            // 
            // txtboxCodeUser
            // 
            this.txtboxCodeUser.CampoDB = "CodeUser";
            this.txtboxCodeUser.CampoVacio = false;
            this.txtboxCodeUser.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxCodeUser.Forana = false;
            this.txtboxCodeUser.Location = new System.Drawing.Point(1416, 59);
            this.txtboxCodeUser.Name = "txtboxCodeUser";
            this.txtboxCodeUser.NombreControl = null;
            this.txtboxCodeUser.Size = new System.Drawing.Size(100, 20);
            this.txtboxCodeUser.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1353, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "ID User:";
            // 
            // txtboxIdUser
            // 
            this.txtboxIdUser.CampoDB = "idUser";
            this.txtboxIdUser.CampoVacio = false;
            this.txtboxIdUser.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdUser.Forana = false;
            this.txtboxIdUser.Location = new System.Drawing.Point(1416, 33);
            this.txtboxIdUser.Name = "txtboxIdUser";
            this.txtboxIdUser.NombreControl = null;
            this.txtboxIdUser.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdUser.TabIndex = 41;
            // 
            // UsuarisORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 374);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtboxIdUser);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnNou);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIdEspecie);
            this.Controls.Add(this.txtBoxIdPlanet);
            this.Controls.Add(this.txtboxPhoto);
            this.Controls.Add(this.txtboxIdUserCategory);
            this.Controls.Add(this.txtboxIdUserRank);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxCodeUser);
            this.Controls.Add(this.dtgUsuaris);
            this.Name = "UsuarisORM";
            this.Text = "Usuaris (ORM)";
            this.Load += new System.EventHandler(this.UsuarisORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuaris;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom_Inherited_Controls.SWTextBox txtboxIdEspecie;
        private Custom_Inherited_Controls.SWTextBox txtBoxIdPlanet;
        private Custom_Inherited_Controls.SWTextBox txtboxPhoto;
        private Custom_Inherited_Controls.SWTextBox txtboxIdUserCategory;
        private Custom_Inherited_Controls.SWTextBox txtboxIdUserRank;
        private Custom_Inherited_Controls.SWTextBox txtPassword;
        private Custom_Inherited_Controls.SWTextBox txtboxLogin;
        private Custom_Inherited_Controls.SWTextBox txtboxUsername;
        private Custom_Inherited_Controls.SWTextBox txtboxCodeUser;
        private System.Windows.Forms.Button btnNou;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Label label10;
        private Custom_Inherited_Controls.SWTextBox txtboxIdUser;
    }
}