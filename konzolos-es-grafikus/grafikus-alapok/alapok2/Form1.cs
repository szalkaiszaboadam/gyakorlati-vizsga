using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace alapok2
{
    public partial class Form1 : Form
    {
        public string[] feliratok = File.ReadAllLines("gombok.txt");
        public int gombMagas = 30;
        public int gombSzeles = 60;
        public int gombTavol = 20;

        public List<Button> gombok = new List<Button>();
        public List<Label> cimkek = new List<Label>();


        public Form1()
        {
            int gombokSz = feliratok.Length;

            ClientSize = new Size(400, gombokSz * (gombMagas + gombTavol) + gombTavol);

            //this.Width = 200;
            //this.Height = gombokSz * (gombMagas + gombTavol) + gombTavol;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile(@"C:\Users\Szalkai-SzaboAdam\Downloads\Szalkai-SzaboAdamFeladat20231012\alapok\bin\Debug\hatter.png");


            for (int i = 0; i < gombokSz; i++)
            {
                Button tmp = new Button();                                             

                tmp.Height = gombMagas;
                tmp.Width = gombSzeles;

                tmp.Text = feliratok[i];
                tmp.Location = new Point(gombTavol, gombTavol + (gombTavol + gombMagas) * i);
                tmp.Click += new EventHandler(Button_Click);

                gombok.Add(tmp);
                Controls.Add(tmp);
            }

            

            Button ki = new Button();
            ki.Text = "Kilépés";
            ki.Height = gombMagas;

            

            ki.Width = gombSzeles ;
            ki.Location = new Point(ClientSize.Width - gombSzeles - 5, ClientSize.Height - gombMagas - 5);
            ki.Click += new EventHandler(kiGomb);
            Controls.Add(ki);

            for (int i = 0; i < gombokSz; i++)
            {
                Label tmp = new Label();

                tmp.Height = gombMagas;
                tmp.Width = gombSzeles;

                tmp.Text = feliratok[i] + " kiválasztva!";
                tmp.Location = new Point(gombTavol + gombSzeles + 5, gombTavol + (gombTavol + gombMagas) * i);
                
                cimkek.Add(tmp);
                Controls.Add(tmp);
            }

            gombok[1].Select();
            for (int i = 0; i < gombokSz; i++)
            {
                if (gombok[i].CanSelect)
                {
                    cimkek[i].Visible = true;
                } else
                {
                    cimkek[i].Visible = false;
                }
            }

        }

        /*static public void Main()
        {
            Application.Run(new Form1());
        }*/
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gomb lenyomva");
        }
        private void kiGomb(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
