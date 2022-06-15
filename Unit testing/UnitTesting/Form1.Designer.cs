
namespace UnitTesting
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnRandomNumbers = new System.Windows.Forms.Button();
            this.btnCMD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCMDResoult = new System.Windows.Forms.Label();
            this.btnMCM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMCMResoult = new System.Windows.Forms.Label();
            this.btnCalculs = new System.Windows.Forms.Button();
            this.lboxCalculs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(158, 50);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(13, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "0";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(227, 50);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(13, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "0";
            // 
            // btnRandomNumbers
            // 
            this.btnRandomNumbers.Location = new System.Drawing.Point(65, 45);
            this.btnRandomNumbers.Name = "btnRandomNumbers";
            this.btnRandomNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnRandomNumbers.TabIndex = 2;
            this.btnRandomNumbers.Text = "Numbers";
            this.btnRandomNumbers.UseVisualStyleBackColor = true;
            this.btnRandomNumbers.Click += new System.EventHandler(this.btnRandomNumbers_Click);
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(65, 148);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(75, 23);
            this.btnCMD.TabIndex = 3;
            this.btnCMD.Text = "C.M.D";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultat CMD:";
            // 
            // lblCMDResoult
            // 
            this.lblCMDResoult.AutoSize = true;
            this.lblCMDResoult.Location = new System.Drawing.Point(240, 153);
            this.lblCMDResoult.Name = "lblCMDResoult";
            this.lblCMDResoult.Size = new System.Drawing.Size(13, 13);
            this.lblCMDResoult.TabIndex = 5;
            this.lblCMDResoult.Text = "0";
            // 
            // btnMCM
            // 
            this.btnMCM.Location = new System.Drawing.Point(65, 211);
            this.btnMCM.Name = "btnMCM";
            this.btnMCM.Size = new System.Drawing.Size(75, 23);
            this.btnMCM.TabIndex = 6;
            this.btnMCM.Text = "M.C.M";
            this.btnMCM.UseVisualStyleBackColor = true;
            this.btnMCM.Click += new System.EventHandler(this.btnMCM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultat CMD:";
            // 
            // lblMCMResoult
            // 
            this.lblMCMResoult.AutoSize = true;
            this.lblMCMResoult.Location = new System.Drawing.Point(240, 216);
            this.lblMCMResoult.Name = "lblMCMResoult";
            this.lblMCMResoult.Size = new System.Drawing.Size(13, 13);
            this.lblMCMResoult.TabIndex = 8;
            this.lblMCMResoult.Text = "0";
            // 
            // btnCalculs
            // 
            this.btnCalculs.Location = new System.Drawing.Point(65, 259);
            this.btnCalculs.Name = "btnCalculs";
            this.btnCalculs.Size = new System.Drawing.Size(89, 23);
            this.btnCalculs.TabIndex = 9;
            this.btnCalculs.Text = "Set de calculs";
            this.btnCalculs.UseVisualStyleBackColor = true;
            this.btnCalculs.Click += new System.EventHandler(this.btnCalculs_Click);
            // 
            // lboxCalculs
            // 
            this.lboxCalculs.FormattingEnabled = true;
            this.lboxCalculs.Location = new System.Drawing.Point(160, 259);
            this.lboxCalculs.Name = "lboxCalculs";
            this.lboxCalculs.Size = new System.Drawing.Size(120, 160);
            this.lboxCalculs.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 454);
            this.Controls.Add(this.lboxCalculs);
            this.Controls.Add(this.btnCalculs);
            this.Controls.Add(this.lblMCMResoult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMCM);
            this.Controls.Add(this.lblCMDResoult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.btnRandomNumbers);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Unit Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnRandomNumbers;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCMDResoult;
        private System.Windows.Forms.Button btnMCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMCMResoult;
        private System.Windows.Forms.Button btnCalculs;
        private System.Windows.Forms.ListBox lboxCalculs;
    }
}

