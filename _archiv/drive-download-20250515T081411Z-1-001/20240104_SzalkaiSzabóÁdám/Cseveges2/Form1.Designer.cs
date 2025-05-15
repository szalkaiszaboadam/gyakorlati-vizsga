namespace Cseveges2
{
    partial class Form1
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
            this.feladat4 = new System.Windows.Forms.Label();
            this.labelotfeladat = new System.Windows.Forms.Label();
            this.feladat5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // feladat4
            // 
            this.feladat4.AutoSize = true;
            this.feladat4.Location = new System.Drawing.Point(467, 27);
            this.feladat4.Name = "feladat4";
            this.feladat4.Size = new System.Drawing.Size(54, 13);
            this.feladat4.TabIndex = 0;
            this.feladat4.Text = "4. feladat:";
            // 
            // labelotfeladat
            // 
            this.labelotfeladat.AutoSize = true;
            this.labelotfeladat.Location = new System.Drawing.Point(467, 54);
            this.labelotfeladat.Name = "labelotfeladat";
            this.labelotfeladat.Size = new System.Drawing.Size(211, 13);
            this.labelotfeladat.TabIndex = 1;
            this.labelotfeladat.Text = "5. feladat: Leghosszabb beszélgetés adatai";
            // 
            // feladat5
            // 
            this.feladat5.Location = new System.Drawing.Point(470, 71);
            this.feladat5.Multiline = true;
            this.feladat5.Name = "feladat5";
            this.feladat5.ReadOnly = true;
            this.feladat5.Size = new System.Drawing.Size(208, 85);
            this.feladat5.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feladat5);
            this.Controls.Add(this.labelotfeladat);
            this.Controls.Add(this.feladat4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feladat4;
        private System.Windows.Forms.Label labelotfeladat;
        private System.Windows.Forms.TextBox feladat5;
    }
}

