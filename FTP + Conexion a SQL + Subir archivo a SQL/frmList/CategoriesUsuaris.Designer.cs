
namespace frmList
{
    partial class CategoriesUsuaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesUsuaris));
            this.dtgCategoriesUsuaris = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxAccesLevel = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxDescCategory = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxCodeCategory = new Custom_Inherited_Controls.SWTextBox();
            this.txtboxIDuserCategory = new Custom_Inherited_Controls.SWTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNou = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriesUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCategoriesUsuaris
            // 
            this.dtgCategoriesUsuaris.AllowUserToAddRows = false;
            this.dtgCategoriesUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoriesUsuaris.Location = new System.Drawing.Point(24, 24);
            this.dtgCategoriesUsuaris.Name = "dtgCategoriesUsuaris";
            this.dtgCategoriesUsuaris.ReadOnly = true;
            this.dtgCategoriesUsuaris.Size = new System.Drawing.Size(545, 285);
            this.dtgCategoriesUsuaris.TabIndex = 0;
            this.dtgCategoriesUsuaris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgCategoriesUsuaris_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(596, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID User Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(609, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(604, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desc Category: ";
            // 
            // txtboxAccesLevel
            // 
            this.txtboxAccesLevel.CampoDB = "AccessLevel";
            this.txtboxAccesLevel.CampoVacio = true;
            this.txtboxAccesLevel.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxAccesLevel.Forana = false;
            this.txtboxAccesLevel.Location = new System.Drawing.Point(691, 197);
            this.txtboxAccesLevel.Name = "txtboxAccesLevel";
            this.txtboxAccesLevel.NombreControl = null;
            this.txtboxAccesLevel.Size = new System.Drawing.Size(100, 20);
            this.txtboxAccesLevel.TabIndex = 4;
            // 
            // txtboxDescCategory
            // 
            this.txtboxDescCategory.CampoDB = "DescCategory";
            this.txtboxDescCategory.CampoVacio = true;
            this.txtboxDescCategory.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxDescCategory.Forana = false;
            this.txtboxDescCategory.Location = new System.Drawing.Point(691, 158);
            this.txtboxDescCategory.Name = "txtboxDescCategory";
            this.txtboxDescCategory.NombreControl = null;
            this.txtboxDescCategory.Size = new System.Drawing.Size(100, 20);
            this.txtboxDescCategory.TabIndex = 3;
            // 
            // txtboxCodeCategory
            // 
            this.txtboxCodeCategory.CampoDB = "CodeCategory";
            this.txtboxCodeCategory.CampoVacio = true;
            this.txtboxCodeCategory.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxCodeCategory.Forana = false;
            this.txtboxCodeCategory.Location = new System.Drawing.Point(691, 118);
            this.txtboxCodeCategory.Name = "txtboxCodeCategory";
            this.txtboxCodeCategory.NombreControl = null;
            this.txtboxCodeCategory.Size = new System.Drawing.Size(100, 20);
            this.txtboxCodeCategory.TabIndex = 2;
            // 
            // txtboxIDuserCategory
            // 
            this.txtboxIDuserCategory.CampoDB = "idUserCategory";
            this.txtboxIDuserCategory.CampoVacio = true;
            this.txtboxIDuserCategory.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.txtboxIDuserCategory.Forana = false;
            this.txtboxIDuserCategory.Location = new System.Drawing.Point(691, 73);
            this.txtboxIDuserCategory.Name = "txtboxIDuserCategory";
            this.txtboxIDuserCategory.NombreControl = null;
            this.txtboxIDuserCategory.Size = new System.Drawing.Size(100, 20);
            this.txtboxIDuserCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(621, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acces level:";
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(599, 237);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(75, 23);
            this.btnNou.TabIndex = 9;
            this.btnNou.Text = "Nou";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(716, 237);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(75, 23);
            this.btnActualitzar.TabIndex = 10;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // CategoriesUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 327);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnNou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAccesLevel);
            this.Controls.Add(this.txtboxDescCategory);
            this.Controls.Add(this.txtboxCodeCategory);
            this.Controls.Add(this.txtboxIDuserCategory);
            this.Controls.Add(this.dtgCategoriesUsuaris);
            this.Name = "CategoriesUsuaris";
            this.Text = "Categories Usuaris";
            this.Load += new System.EventHandler(this.CategoriesUsuaris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriesUsuaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategoriesUsuaris;
        private Custom_Inherited_Controls.SWTextBox txtboxIDuserCategory;
        private Custom_Inherited_Controls.SWTextBox txtboxCodeCategory;
        private Custom_Inherited_Controls.SWTextBox txtboxDescCategory;
        private Custom_Inherited_Controls.SWTextBox txtboxAccesLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNou;
        private System.Windows.Forms.Button btnActualitzar;
    }
}