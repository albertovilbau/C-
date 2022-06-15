
namespace frmList
{
    partial class Usuarios
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
            this.txtboxCodeUser = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxUsername = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxLogin = new Custom_Inherited_Controls.SWTextBox();
            this.txtPassword = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIdUserRank = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIdUserCategory = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxPhoto = new Custom_Inherited_Controls.SWTextBox();
            this.txtBoxIdPlanet = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIdEspecie = new Custom_Inherited_Controls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.UserReport1 = new frmList.UserReport();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxid = new Custom_Inherited_Controls.SWTextBox();
            this.SuspendLayout();
            // 
            // txtboxCodeUser
            // 
            this.txtboxCodeUser.CampoDB = "CodeUser";
            this.txtboxCodeUser.CampoVacio = false;
            this.txtboxCodeUser.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxCodeUser.Forana = false;
            this.txtboxCodeUser.Location = new System.Drawing.Point(153, 23);
            this.txtboxCodeUser.Name = "txtboxCodeUser";
            this.txtboxCodeUser.NombreControl = null;
            this.txtboxCodeUser.Size = new System.Drawing.Size(100, 20);
            this.txtboxCodeUser.TabIndex = 3;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.CampoDB = "UserName";
            this.txtboxUsername.CampoVacio = false;
            this.txtboxUsername.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxUsername.Forana = false;
            this.txtboxUsername.Location = new System.Drawing.Point(153, 49);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.NombreControl = null;
            this.txtboxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsername.TabIndex = 4;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.CampoDB = "Login";
            this.txtboxLogin.CampoVacio = false;
            this.txtboxLogin.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxLogin.Forana = false;
            this.txtboxLogin.Location = new System.Drawing.Point(153, 76);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.NombreControl = null;
            this.txtboxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.CampoDB = "Password";
            this.txtPassword.CampoVacio = false;
            this.txtPassword.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtPassword.Forana = false;
            this.txtPassword.Location = new System.Drawing.Point(396, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NombreControl = null;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtboxIdUserRank
            // 
            this.txtboxIdUserRank.CampoDB = "idUserRank";
            this.txtboxIdUserRank.CampoVacio = false;
            this.txtboxIdUserRank.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdUserRank.Forana = false;
            this.txtboxIdUserRank.Location = new System.Drawing.Point(396, 49);
            this.txtboxIdUserRank.Name = "txtboxIdUserRank";
            this.txtboxIdUserRank.NombreControl = null;
            this.txtboxIdUserRank.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdUserRank.TabIndex = 7;
            // 
            // txtboxIdUserCategory
            // 
            this.txtboxIdUserCategory.CampoDB = "idUserCategory";
            this.txtboxIdUserCategory.CampoVacio = false;
            this.txtboxIdUserCategory.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdUserCategory.Forana = false;
            this.txtboxIdUserCategory.Location = new System.Drawing.Point(396, 76);
            this.txtboxIdUserCategory.Name = "txtboxIdUserCategory";
            this.txtboxIdUserCategory.NombreControl = null;
            this.txtboxIdUserCategory.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdUserCategory.TabIndex = 8;
            // 
            // txtboxPhoto
            // 
            this.txtboxPhoto.CampoDB = "Photo";
            this.txtboxPhoto.CampoVacio = false;
            this.txtboxPhoto.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxPhoto.Forana = false;
            this.txtboxPhoto.Location = new System.Drawing.Point(617, 23);
            this.txtboxPhoto.Name = "txtboxPhoto";
            this.txtboxPhoto.NombreControl = null;
            this.txtboxPhoto.Size = new System.Drawing.Size(100, 20);
            this.txtboxPhoto.TabIndex = 9;
            // 
            // txtBoxIdPlanet
            // 
            this.txtBoxIdPlanet.CampoDB = "idPlanet";
            this.txtBoxIdPlanet.CampoVacio = false;
            this.txtBoxIdPlanet.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtBoxIdPlanet.Forana = false;
            this.txtBoxIdPlanet.Location = new System.Drawing.Point(617, 49);
            this.txtBoxIdPlanet.Name = "txtBoxIdPlanet";
            this.txtBoxIdPlanet.NombreControl = null;
            this.txtBoxIdPlanet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdPlanet.TabIndex = 10;
            // 
            // txtboxIdEspecie
            // 
            this.txtboxIdEspecie.CampoDB = "idSpecie";
            this.txtboxIdEspecie.CampoVacio = false;
            this.txtboxIdEspecie.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIdEspecie.Forana = false;
            this.txtboxIdEspecie.Location = new System.Drawing.Point(617, 76);
            this.txtboxIdEspecie.Name = "txtboxIdEspecie";
            this.txtboxIdEspecie.NombreControl = null;
            this.txtboxIdEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdEspecie.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(92, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(115, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(337, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(320, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id User Rank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(307, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id User Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(575, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Photo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(564, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "id Planet:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(552, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "id Especie: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 410);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(776, 102);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.UserReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(537, 472);
            this.crystalReportViewer1.TabIndex = 25;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(779, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID User:";
            // 
            // txtboxid
            // 
            this.txtboxid.CampoDB = "idUser";
            this.txtboxid.CampoVacio = false;
            this.txtboxid.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxid.Forana = false;
            this.txtboxid.Location = new System.Drawing.Point(831, 52);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.NombreControl = null;
            this.txtboxid.Size = new System.Drawing.Size(32, 20);
            this.txtboxid.TabIndex = 26;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 583);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnBuscar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Controls.SetChildIndex(this.txtboxCodeUser, 0);
            this.Controls.SetChildIndex(this.txtboxUsername, 0);
            this.Controls.SetChildIndex(this.txtboxLogin, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtboxIdUserRank, 0);
            this.Controls.SetChildIndex(this.txtboxIdUserCategory, 0);
            this.Controls.SetChildIndex(this.txtboxPhoto, 0);
            this.Controls.SetChildIndex(this.txtBoxIdPlanet, 0);
            this.Controls.SetChildIndex(this.txtboxIdEspecie, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.txtboxid, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Inherited_Controls.SWTextBox txtboxCodeUser;
        private Custom_Inherited_Controls.SWTextBox txtboxUsername;
        private Custom_Inherited_Controls.SWTextBox txtboxLogin;
        private Custom_Inherited_Controls.SWTextBox txtPassword;
        private Custom_Inherited_Controls.SWTextBox txtboxIdUserRank;
        private Custom_Inherited_Controls.SWTextBox txtboxIdUserCategory;
        private Custom_Inherited_Controls.SWTextBox txtboxPhoto;
        private Custom_Inherited_Controls.SWTextBox txtBoxIdPlanet;
        private Custom_Inherited_Controls.SWTextBox txtboxIdEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private UserReport UserReport1;
        private System.Windows.Forms.Label label10;
        private Custom_Inherited_Controls.SWTextBox txtboxid;
    }
}