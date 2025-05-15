using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Cseveges2
{

    public partial class Form1 : Form
    {
        List<csevegesAdat> csevegesek = new List<csevegesAdat>();
        //csevegesAdat[] csevegesek = new csevegesAdat[1000];
        //string[] tagok = new string[50];
        List<string> tagok = new List<string>();

        class csevegesAdat
        {
            public DateTime kezdet;
            public DateTime veg;
            public string kezdemenyezo;
            public string fogado;


            public csevegesAdat(string sor)
            {
                string[] szet = sor.Split(';');

                kezdet = DateTime.ParseExact(szet[0], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
                veg = DateTime.ParseExact(szet[1], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
                kezdemenyezo = szet[2];
                fogado = szet[3];

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region csevegesek
           // csevegesAdat[] csevegesek = new csevegesAdat[1000];
            StreamReader olvas = new StreamReader("csevegesek.txt");

            //int length = 0;

            //olvas.ReadLine();

            while (!olvas.EndOfStream)
            {
                //csevegesek[length] = new csevegesAdat(olvas.ReadLine());
                //length++;
                string egysor = olvas.ReadLine();
                csevegesAdat adatok = new csevegesAdat(egysor);
                csevegesek.Add(adatok);
            }

            olvas.Close();
            #endregion

            #region tagok
            //string[] tagok = new string[50];
            StreamReader olvas2 = new StreamReader("tagok.txt");

            //int length2 = 0;

            while (!olvas2.EndOfStream)
            {
                /*tagok[length2] = olvas2.ReadLine();
                length2++;*/
                string egysor = olvas2.ReadLine();
                tagok.Add(egysor);
            }

            olvas2.Close();
            #endregion

            #region 4. fealadat

            feladat4.Text = "4. feladat: A tagok száma: " + tagok.Count + "fő - Beszélgetések: " + csevegesek.Count + "db";
            #endregion

            #region 5. feladat


            TimeSpan max = csevegesek[0].veg - csevegesek[0].kezdet;
            int ii = 0;
            for (int i = 0; i < csevegesek.Count; i++)
            {
                TimeSpan temp = csevegesek[i].veg - csevegesek[i].kezdet;
                if (temp > max)
                {
                    max = temp;
                    ii = i;
                }
            }
            
            feladat5.Text = "Kezdeményező: " + csevegesek[ii].kezdemenyezo + Environment.NewLine + "Fogadó: " + csevegesek[ii].fogado + Environment.NewLine + "Kezdete: " + csevegesek[ii].kezdet + Environment.NewLine + "Vége: " + csevegesek[ii].veg + Environment.NewLine + "Hossz: " + max.TotalSeconds + "mp";

            #endregion





    

            
        }

        private void feladat63_Click(object sender, EventArgs e)
        {
            #region 6. feladat
            string nev = feladat6.Text;
            TimeSpan ossz = csevegesek[0].veg - csevegesek[0].veg;
            for (int i = 0; i < csevegesek.Count; i++)
            {

                if (csevegesek[i].kezdemenyezo == nev)
                {
                    TimeSpan temp = csevegesek[i].veg - csevegesek[i].kezdet;
                    ossz += temp;
                }
                if (csevegesek[i].fogado == nev)
                {
                    TimeSpan temp2 = csevegesek[i].veg - csevegesek[i].kezdet;
                    ossz += temp2;
                }


            }

            feladat62.Text = "A beszégetések össze ideje: " + ossz;
            #endregion



            #region 7. feladat
            List<string> nemBeszeltek = new List<string>();

            List<string> tagokBesz = new List<string>();
            for (int i = 0; i < csevegesek.Count; i++)
            {
                tagokBesz.Add(csevegesek[i].kezdemenyezo);
            }
            
            List<string> tagokEgyesevel = tagokBesz.Distinct().ToList();
            tagokEgyesevel.Sort();
            tagok.Sort();

            for (int i = 0; i < tagok.Count; i++)
            {
                for (int ii = 0; ii < tagokEgyesevel.Count; ii++)
                {
                    if (tagok[i] != tagokEgyesevel[ii])
                    {
                        nemBeszeltek.Add(tagok[i]);
                    }
                }
                      
            }

            feladat7.Text = String.Join(Environment.NewLine, nemBeszeltek);

            #endregion


        }


    }
    }
