using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobokocka
{
    public partial class Form1 : Form
    {

        List<int> elsoJatekos = new List<int>();
        List<int> masodikJatekos = new List<int>();
        List<int> harmadikJatekos = new List<int>();
        List<int> negyedikJatekos = new List<int>();
        List<int> otodikJatekos = new List<int>();
        List<int> hatodikJatekos = new List<int>();



        List<int> elsoDobasok = new List<int>();
        List<int> masodikDobasok = new List<int>();
        List<int> harmadikDobasok = new List<int>();
        List<int> negyedikDobasok = new List<int>();
        List<int> otodikDobasok = new List<int>();
        List<int> hatodikDobasok = new List<int>();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

           button1.Visible = true;
           label1.Visible = false;
           label2.Visible = false;
           label3.Visible = false;
           label4.Visible = false;
           label5.Visible = false;
           label6.Visible = false;
           label7.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            Random rnd = new Random();


            for (int j = 0; j < 5; j++)
            {
                elsoJatekos.Add(rnd.Next(1, 7));
            }
            for (int j = 0; j < 5; j++)
            {
                masodikJatekos.Add(rnd.Next(1, 7));
            }
            for (int j = 0; j < 5; j++)
            {
                harmadikJatekos.Add(rnd.Next(1, 7));
            }
            for (int j = 0; j < 5; j++)
            {
                negyedikJatekos.Add(rnd.Next(1, 7));
            }
            for (int j = 0; j < 5; j++)
            {
                otodikJatekos.Add(rnd.Next(1, 7));
            }
            for (int j = 0; j < 5; j++)
            {
                hatodikJatekos.Add(rnd.Next(1, 7));
            }


            label1.Text += string.Join(" ", elsoJatekos);
            label2.Text += string.Join(" ", masodikJatekos);
            label3.Text += string.Join(" ", harmadikJatekos);
            label4.Text += string.Join(" ", negyedikJatekos);
            label5.Text += string.Join(" ", otodikJatekos);
            label6.Text += string.Join(" ", hatodikJatekos);




            bool elsoPar = elsoJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool elsoDrill = elsoJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool elsoFull = false;
            if (elsoPar == true && elsoDrill == true)
            {
                elsoFull = true;
            }
            else { elsoFull = false; }
            bool elsoSor = false;
            if (elsoJatekos[0] == 1 && elsoJatekos[1] == 2 && elsoJatekos[2] == 3 && elsoJatekos[3] == 4 && elsoJatekos[4] == 5)
            {
                elsoSor = true;
            } else { elsoSor = false; }
            bool elsoPoker = elsoJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool elsoRF = elsoJatekos.GroupBy(i => i).Any(s => s.Count() == 5);



            if (elsoPar == true)
            {
                elsoDobasok.Add(1);
            }
            if (elsoDrill == true) 
            {
                elsoDobasok.Add(2);
            }
            if (elsoFull == true)
            {
                elsoDobasok.Add(3);
            }
            if (elsoSor == true)
            {
                elsoDobasok.Add(4);
            }
            if (elsoPoker == true)
            {
                elsoDobasok.Add(5);
            }
            if (elsoRF == true)
            {
                elsoDobasok.Add(6);
            }



            bool masodikPar = masodikJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool masodikDrill = masodikJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool masodikFull = false;
            if (masodikPar == true && masodikDrill == true)
            {
                masodikFull = true;
            }
            else { masodikFull = false; }
            bool masodikSor = false;
            if (masodikJatekos[0] == 1 && masodikJatekos[1] == 2 && masodikJatekos[2] == 3 && masodikJatekos[3] == 4 && masodikJatekos[4] == 5)
            {
                masodikSor = true;
            }
            else { masodikSor = false; }
            bool masodikPoker = masodikJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool masodikRF = masodikJatekos.GroupBy(i => i).Any(s => s.Count() == 5);


            if (masodikPar == true)
            {
                masodikDobasok.Add(1);
            }
            if (masodikDrill == true)
            {
                masodikDobasok.Add(2);
            }
            if (masodikFull == true)
            {
                masodikDobasok.Add(3);
            }
            if (masodikSor == true)
            {
                masodikDobasok.Add(4);
            }
            if (masodikPoker == true)
            {
                masodikDobasok.Add(5);
            }
            if (masodikRF == true)
            {
                masodikDobasok.Add(6);
            }



            bool harmadikPar = harmadikJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool harmadikDrill = harmadikJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool harmadikFull = false;
            if (harmadikPar == true && harmadikDrill == true)
            {
                harmadikFull = true;
            }
            else { harmadikFull = false; }
            bool harmadikSor = false;
            if (harmadikJatekos[0] == 1 && harmadikJatekos[1] == 2 && harmadikJatekos[2] == 3 && harmadikJatekos[3] == 4 && harmadikJatekos[4] == 5)
            {
                harmadikSor = true;
            }
            else { harmadikSor = false; }
            bool harmadikPoker = harmadikJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool harmadikRF = harmadikJatekos.GroupBy(i => i).Any(s => s.Count() == 5);

            if (harmadikPar == true)
            {
                harmadikDobasok.Add(1);
            }
            if (harmadikDrill == true)
            {
                harmadikDobasok.Add(2);
            }
            if (harmadikFull == true)
            {
                harmadikDobasok.Add(3);
            }
            if (harmadikSor == true)
            {
                harmadikDobasok.Add(4);
            }
            if (harmadikPoker == true)
            {
                harmadikDobasok.Add(5);
            }
            if (harmadikRF == true)
            {
                harmadikDobasok.Add(6);
            }


            bool negyedikPar = negyedikJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool negyedikDrill = negyedikJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool negyedikFull = false;
            if (negyedikPar == true && negyedikDrill == true)
            {
                negyedikFull = true;
            }
            else { negyedikFull = false; }
            bool negyedikSor = false;
            if (negyedikJatekos[0] == 1 && negyedikJatekos[1] == 2 && negyedikJatekos[2] == 3 && negyedikJatekos[3] == 4 && negyedikJatekos[4] == 5)
            {
                negyedikSor = true;
            }
            else { negyedikSor = false; }
            bool negyedikPoker = negyedikJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool negyedikRF = negyedikJatekos.GroupBy(i => i).Any(s => s.Count() == 5);

            if (negyedikPar == true)
            {
                negyedikDobasok.Add(1);
            }
            if (negyedikDrill == true)
            {
                negyedikDobasok.Add(2);
            }
            if (negyedikFull == true)
            {
                negyedikDobasok.Add(3);
            }
            if (negyedikSor == true)
            {
                negyedikDobasok.Add(4);
            }
            if (negyedikPoker == true)
            {
                negyedikDobasok.Add(5);
            }
            if (negyedikRF == true)
            {
                negyedikDobasok.Add(6);
            }

            bool otodikPar = otodikJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool otodikDrill = otodikJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool otodikFull = false;
            if (otodikPar == true && otodikDrill == true)
            {
                otodikFull = true;
            }
            else { otodikFull = false; }
            bool otodikSor = false;
            if (otodikJatekos[0] == 1 && otodikJatekos[1] == 2 && otodikJatekos[2] == 3 && otodikJatekos[3] == 4 && otodikJatekos[4] == 5)
            {
                otodikSor = true;
            }
            else { otodikSor = false; }
            bool otodikPoker = otodikJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool otodikRF = otodikJatekos.GroupBy(i => i).Any(s => s.Count() == 5);


            if (otodikPar == true)
            {
                otodikDobasok.Add(1);
            }
            if (otodikDrill == true)
            {
                otodikDobasok.Add(2);
            }
            if (otodikFull == true)
            {
                otodikDobasok.Add(3);
            }
            if (otodikSor == true)
            {
                otodikDobasok.Add(4);
            }
            if (otodikPoker == true)
            {
                otodikDobasok.Add(5);
            }
            if (otodikRF == true)
            {
                otodikDobasok.Add(6);
            }



            bool hatodikPar = hatodikJatekos.GroupBy(i => i).Any(s => s.Count() == 2);

            bool hatodikDrill = hatodikJatekos.GroupBy(i => i).Any(s => s.Count() == 3);
            bool hatodikFull = false;
            if (hatodikPar == true && hatodikDrill == true)
            {
                hatodikFull = true;
            }
            else { hatodikFull = false; }
            bool hatodikSor = false;
            if (hatodikJatekos[0] == 1 && hatodikJatekos[1] == 2 && hatodikJatekos[2] == 3 && hatodikJatekos[3] == 4 && hatodikJatekos[4] == 5)
            {
                hatodikSor = true;
            }
            else { hatodikSor = false; }
            bool hatodikPoker = hatodikJatekos.GroupBy(i => i).Any(s => s.Count() == 4);
            bool hatodikRF = hatodikJatekos.GroupBy(i => i).Any(s => s.Count() == 5);

            if (hatodikPar == true)
            {
                hatodikDobasok.Add(1);
            }
            if (hatodikDrill == true)
            {
                hatodikDobasok.Add(2);
            }
            if (hatodikFull == true)
            {
                hatodikDobasok.Add(3);
            }
            if (hatodikSor == true)
            {
                hatodikDobasok.Add(4);
            }
            if (hatodikPoker == true)
            {
                hatodikDobasok.Add(5);
            }
            if (hatodikRF == true)
            {
                hatodikDobasok.Add(6);
            }















            int elsoLegnagyobb;
            if (elsoDobasok.Count > 0)
            {
                elsoLegnagyobb = elsoDobasok[0];
                for (int i = 0; i < elsoDobasok.Count; i++)
                {
                    if (elsoDobasok[i] > elsoLegnagyobb)
                    {
                        elsoLegnagyobb = elsoDobasok[i];
                    }
                }
            } else
            {
                elsoLegnagyobb = 0;
            }


            int masodikLegnagyobb;
            if (masodikDobasok.Count > 0)
            {
               masodikLegnagyobb = masodikDobasok[0];
                for (int i = 0; i < masodikDobasok.Count; i++)
                {
                    if (masodikDobasok[i] > masodikLegnagyobb)
                    {
                        masodikLegnagyobb = masodikDobasok[i];
                    }
                }
            } else
            {
                masodikLegnagyobb = 0;
            }
 

            int harmadikLegnagyobb;
            if (harmadikDobasok.Count > 0)
            {
                harmadikLegnagyobb = harmadikDobasok[0];            
                
                for (int i = 0; i < harmadikDobasok.Count; i++)
                {
                if (harmadikDobasok[i] > harmadikLegnagyobb)
                {
                    harmadikLegnagyobb = harmadikDobasok[i];
                }
            }
            }
            else
            {
                harmadikLegnagyobb = 0;
            }
            


            int negyedikLegnagyobb;
            if (negyedikDobasok.Count > 0)
            {
                 negyedikLegnagyobb = negyedikDobasok[0];
                for (int i = 0; i < negyedikDobasok.Count; i++)
                {
                    if (negyedikDobasok[i] > negyedikLegnagyobb)
                    {
                        negyedikLegnagyobb = negyedikDobasok[i];
                    }
            }
            } else
            {
                negyedikLegnagyobb = 0;
            }



            int otodikLegnagyobb;
            if (otodikDobasok.Count > 0)
            {
                otodikLegnagyobb = otodikDobasok[0];
                for (int i = 0; i < otodikDobasok.Count; i++)
                {
                    if (otodikDobasok[i] > otodikLegnagyobb)
                    {
                        otodikLegnagyobb = otodikDobasok[i];
                    }
                }
            } else
            {
                otodikLegnagyobb = 0;
            }
            

            int hatodikLegnagyobb;
            if (hatodikDobasok.Count > 0)
            {
                hatodikLegnagyobb = hatodikDobasok[0];
                for (int i = 0; i < hatodikDobasok.Count; i++)
                {
                    if (hatodikDobasok[i] > hatodikLegnagyobb)
                    {
                        hatodikLegnagyobb = hatodikDobasok[i];
                    }
                } 
            } else
            {
                hatodikLegnagyobb= 0;   
            }

            


            label1.Text += ", legnagyobb:" + elsoLegnagyobb;
            label2.Text += ", legnagyobb:" + masodikLegnagyobb;
            label3.Text += ", legnagyobb:" + harmadikLegnagyobb;
            label4.Text += ", legnagyobb:" + negyedikLegnagyobb;
            label5.Text += ", legnagyobb:" + otodikLegnagyobb;
            label6.Text += ", legnagyobb:" + hatodikLegnagyobb;


            /* string elsolegNev = "";
             if (elsoLegnagyobb == 1)
             {
                 elsolegNev = "Pár";
             }

             label7.Text += " " */






            label7.Text += "dsgf";
        }
    }
}
