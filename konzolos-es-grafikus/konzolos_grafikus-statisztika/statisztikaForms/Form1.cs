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

namespace statisztikaForms
{

    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            this.Text = "Más";
            btnEnd.Enabled = false;
            lblkettesfeladat.Visible = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            btnEnd.Enabled = true;
            lblkettesfeladat.Visible = true;


            #region 1. feladat        
            List<stat> stat = new List<stat>();
            try
            {

                StreamReader olvas = new StreamReader(txbFileName.Text);

                while (!olvas.EndOfStream)
                {
                    string egysor = olvas.ReadLine();
                    stat adatok = new stat(egysor);
                    stat.Add(adatok);
                }

                int length = stat.Count;

                olvas.Close();

                #region 2. feladat
                /*Console.WriteLine("2.feladat");
                Console.WriteLine("Körök száma: {0}", length);*/
                lblkettesfeladat.Text = "2. feladat:\n Körök száma:" + length.ToString();
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine("A dobasok.txt nevű fájl beolvasása sikeretlen!");
            }
            #endregion



            #region 3. feladat
            //Console.WriteLine("3.feladat");

            #endregion
            int db = 0;
            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].harmadikdobas == "D25")
                {
                    db++;
                }
            }
            lblharmas.Text = "3.feladat:\n 3. dobásra Bullseye: " + db;


            #region 4. feladat
            //Console.WriteLine("4. feladat");

            //Console.Write("Adja meg a szektor értékét! Szektor= ");
            //string bekert = Console.ReadLine();

            int elsodb = 0;
            int masodikdb = 0;

            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].elsodobas == bekert.Text)
                {
                    if (stat[i].jatekos == "1")
                    {
                        elsodb++;
                    }
                    if (stat[i].jatekos == "2")
                    {
                        masodikdb++;
                    }
                }
                if (stat[i].masodikdobas == bekert.Text)
                {
                    if (stat[i].jatekos == "1")
                    {
                        elsodb++;
                    }
                    if (stat[i].jatekos == "2")
                    {
                        masodikdb++;
                    }
                }
                if (stat[i].harmadikdobas == bekert.Text)
                {
                    if (stat[i].jatekos == "1")
                    {
                        elsodb++;
                    }
                    if (stat[i].jatekos == "2")
                    {
                        masodikdb++;
                    }
                }

            }
            //Console.WriteLine("Az 1. játékos a(z) D16 szektoros dobásainak száma: {0}", elsodb);
            //Console.WriteLine("Az 2. játékos a(z) D16 szektoros dobásainak száma: {0}", masodikdb);

            negyes.Text = "Az 1. játékos a(z) " + bekert.Text + " szektoros dobásainak száma: " + elsodb + "\nAz 2. játékos a(z) " + bekert.Text + " szektoros dobásainak száma: " + masodikdb;
            #endregion

            #region 5. feladat
            //Console.WriteLine("5. feladat");

            int elsofull = 0;
            int masodikfull = 0;

            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].jatekos == "1" && stat[i].elsodobas == "T20" && stat[i].masodikdobas == "T20" && stat[i].harmadikdobas == "T20")
                {
                    elsofull++;
                }

                if (stat[i].jatekos == "2" && stat[i].elsodobas == "T20" && stat[i].masodikdobas == "T20" && stat[i].harmadikdobas == "T20")
                {
                    masodikfull++;
                }

            }
            otos.Text = "Az 1. játékos " + elsofull + " db 180-ast dobott.\nAz 2. játékos " + masodikfull + " db 180-ast dobott.";
            //Console.WriteLine("Az 1. játékos {} db 180-ast dobott.", elsofull);
            //Console.WriteLine("Az 2. játékos {} db 180-ast dobott.", masodikfull);
            #endregion



        }

        private void lblkettesfeladat_Click(object sender, EventArgs e)
        {

        }

        private void mehet_Click(object sender, EventArgs e)
        {

        }

        private void bekert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
