namespace statisztikaForms
{
    partial class Screen
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblkettesfeladat = new System.Windows.Forms.Label();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstat = new System.Windows.Forms.Button();
            this.lblharmas = new System.Windows.Forms.Label();
            this.bekert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.negyes = new System.Windows.Forms.Label();
            this.otos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(685, 402);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 36);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Vége";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblkettesfeladat
            // 
            this.lblkettesfeladat.AutoSize = true;
            this.lblkettesfeladat.Location = new System.Drawing.Point(188, 29);
            this.lblkettesfeladat.Name = "lblkettesfeladat";
            this.lblkettesfeladat.Size = new System.Drawing.Size(41, 13);
            this.lblkettesfeladat.TabIndex = 1;
            this.lblkettesfeladat.Text = "szöveg";
            this.lblkettesfeladat.Click += new System.EventHandler(this.lblkettesfeladat_Click);
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(26, 45);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.Size = new System.Drawing.Size(100, 20);
            this.txbFileName.TabIndex = 2;
            this.txbFileName.Text = "dobasok.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kérem a fájl nevét:";
            // 
            // btnstat
            // 
            this.btnstat.Location = new System.Drawing.Point(26, 71);
            this.btnstat.Name = "btnstat";
            this.btnstat.Size = new System.Drawing.Size(100, 30);
            this.btnstat.TabIndex = 4;
            this.btnstat.Text = "Statisztika";
            this.btnstat.UseVisualStyleBackColor = true;
            this.btnstat.Click += new System.EventHandler(this.btnstat_Click);
            // 
            // lblharmas
            // 
            this.lblharmas.AutoSize = true;
            this.lblharmas.Location = new System.Drawing.Point(188, 71);
            this.lblharmas.Name = "lblharmas";
            this.lblharmas.Size = new System.Drawing.Size(41, 13);
            this.lblharmas.TabIndex = 5;
            this.lblharmas.Text = "szöveg";
            // 
            // bekert
            // 
            this.bekert.Location = new System.Drawing.Point(191, 130);
            this.bekert.Name = "bekert";
            this.bekert.Size = new System.Drawing.Size(100, 20);
            this.bekert.TabIndex = 6;
            this.bekert.Text = "D16";
            this.bekert.TextChanged += new System.EventHandler(this.bekert_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adja meg a szektor értékét:";
            // 
            // negyes
            // 
            this.negyes.AutoSize = true;
            this.negyes.Location = new System.Drawing.Point(188, 168);
            this.negyes.Name = "negyes";
            this.negyes.Size = new System.Drawing.Size(41, 13);
            this.negyes.TabIndex = 8;
            this.negyes.Text = "szöveg";
            // 
            // otos
            // 
            this.otos.AutoSize = true;
            this.otos.Location = new System.Drawing.Point(188, 206);
            this.otos.Name = "otos";
            this.otos.Size = new System.Drawing.Size(41, 13);
            this.otos.TabIndex = 9;
            this.otos.Text = "szöveg";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otos);
            this.Controls.Add(this.negyes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bekert);
            this.Controls.Add(this.lblharmas);
            this.Controls.Add(this.btnstat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.lblkettesfeladat);
            this.Controls.Add(this.btnEnd);
            this.Name = "Screen";
            this.Text = "KÉpernyő";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblkettesfeladat;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstat;
        private System.Windows.Forms.Label lblharmas;
        private System.Windows.Forms.TextBox bekert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label negyes;
        private System.Windows.Forms.Label otos;
    }
}

