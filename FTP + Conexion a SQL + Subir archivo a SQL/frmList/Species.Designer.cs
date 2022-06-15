
namespace frmList
{
    partial class Species
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.swTextBox3 = new Custom_Inherited_Controls.SWTextBox();
            this.swTextBox2 = new Custom_Inherited_Controls.SWTextBox();
            this.swTextBox1 = new Custom_Inherited_Controls.SWTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Specie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(235, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code Specie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(228, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desc. Especie";
            // 
            // swTextBox3
            // 
            this.swTextBox3.CampoDB = "DescSpecie";
            this.swTextBox3.CampoVacio = false;
            this.swTextBox3.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.swTextBox3.Forana = false;
            this.swTextBox3.Location = new System.Drawing.Point(305, 50);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.NombreControl = null;
            this.swTextBox3.Size = new System.Drawing.Size(67, 20);
            this.swTextBox3.TabIndex = 5;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampoDB = "CodeSpecie";
            this.swTextBox2.CampoVacio = true;
            this.swTextBox2.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Texto;
            this.swTextBox2.Forana = false;
            this.swTextBox2.Location = new System.Drawing.Point(305, 24);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.NombreControl = null;
            this.swTextBox2.Size = new System.Drawing.Size(67, 20);
            this.swTextBox2.TabIndex = 4;
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampoDB = "idSpecie";
            this.swTextBox1.CampoVacio = false;
            this.swTextBox1.DatoPermitido = Custom_Inherited_Controls.SWTextBox.TipoDato.Numero;
            this.swTextBox1.Forana = false;
            this.swTextBox1.Location = new System.Drawing.Point(146, 24);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.NombreControl = null;
            this.swTextBox1.Size = new System.Drawing.Size(35, 20);
            this.swTextBox1.TabIndex = 3;
            // 
            // Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Name = "Species";
            this.Text = "Species";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Inherited_Controls.SWTextBox swTextBox1;
        private Custom_Inherited_Controls.SWTextBox swTextBox2;
        private Custom_Inherited_Controls.SWTextBox swTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}