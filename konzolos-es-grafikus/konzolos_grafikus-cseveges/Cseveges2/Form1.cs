using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseveges2
{

    public partial class Form1 : Form
    {
        private string ev;
        private string ido;

        private int ora;
        private int perc;
        private int masodperc;

        private string ev2;
        private string ido2;

        private int ora2;
        private int perc2;
        private int masodperc2;


        static List<Class1> csevegesek = new List<Class1>();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("csevegesek.txt", Encoding.UTF8);
            string sor = "0";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Class1 h = new Class1(sor);
                csevegesek.Add(h);
            }
            sr.Close();

            string[] sorok = System.IO.File.ReadAllLines("tagok.txt");
            List<string> tagok = new List<string>();
            foreach (string s in sorok)
            {
                tagok.Add(s);
                //listReadFile.Items.Add(s);

            }


            feladat4.Text += " Tagok száma: " + tagok.Count + "fő - Beszélgetések: " + csevegesek.Count + "db";
            List<TimeSpan> beszelgetesIdok = new List<TimeSpan>();
            for (int i = 0; i < csevegesek.Count; i++)
            {


                string[] d = csevegesek[i].Kezdet.Split('-');
                ev = d[0];
                ido = d[1];

                string asd = ido;
                DateTime kezdetDate = DateTime.ParseExact(ido, "HH:mm:ss",
                                        System.Globalization.CultureInfo.InvariantCulture);

                string[] d2 = csevegesek[i].Veg.Split('-');
                ev2 = d2[0];
                ido2 = d2[1];
                string asd2 = ido2;
                DateTime vegDate = DateTime.ParseExact(ido2, "HH:mm:ss",
                                        System.Globalization.CultureInfo.InvariantCulture);

                TimeSpan value = vegDate.Subtract(kezdetDate);
                
                beszelgetesIdok.Add(value);

                beszelgetesIdok.Sort();

                


            }

            feladat5.Text += "ku";

            }

        }
    }
