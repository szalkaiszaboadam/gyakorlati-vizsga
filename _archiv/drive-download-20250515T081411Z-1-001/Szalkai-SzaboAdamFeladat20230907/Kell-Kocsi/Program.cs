using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kell_kocsi
{
    class berles
    {
        public string berleskezd;
        public string berlesveg;
        public string atvetelhely;
        public string leadashely;
        public string rendszam;


        public berles(string sor)
        {
            string[] szet = sor.Split(',');

            //if szet[0] 

            this.berleskezd = szet[0];
            this.berlesveg = szet[1];
            this.atvetelhely = szet[2];
            this.leadashely = szet[3];
            this.rendszam = szet[4];
          


        }

    }

    class autok
    {

        public string rendszam;
        public int szallithatoutasok;
        public string meghajtastipusa;
        public int napiberleti;

        public autok(string sor)
        {
            string[] szet = sor.Split(',');

            //if szet[0] 

           
            this.rendszam = szet[0];
            this.szallithatoutasok = int.Parse(szet[1]);
            this.meghajtastipusa = szet[2];
            this.napiberleti = int.Parse(szet[3]);



        }

    }

    internal class Program
    {

        static List<string> csereRendezesSzoveg(List<string> cseres)
        {
            string tmp;
            for (int i = 0; i < cseres.Count - 1; i++) 
            {
                for (int j = i + 1; j < cseres.Count; j++) 
                {
                    if (cseres[i].CompareTo(cseres[j]) > 0)
                    {
                        tmp = cseres[i];
                        cseres[i] = cseres[j];
                        cseres[j] = tmp;
                    }
                }
            }
            return cseres;
        }



        static void Main(string[] args)
        {

            #region 1. feladat
            Console.WriteLine("1.feladat");

            List<berles> berles = new List<berles>();
            try
            {
                #region berles

                StreamReader olvas = new StreamReader("Berles.csv");

                while (!olvas.EndOfStream)
                {
                    string egysor = olvas.ReadLine();
                    berles adatok = new berles(egysor);
                    berles.Add(adatok);
                }

                int length = berles.Count;

                olvas.Close();
                #endregion

                Console.WriteLine("\tAz Adott ügyfélhez {0} bérlési esemény tartozik.", length);

            }
            catch (Exception)
            {
                Console.WriteLine("\tA Berles.csv nevű fájl beolvasása sikeretlen!");
            }


            List<autok> autok = new List<autok>();
            try
            {
                #region autok

                StreamReader olvas2 = new StreamReader("Autok.csv");

                while (!olvas2.EndOfStream)
                {
                    string egysor = olvas2.ReadLine();
                    autok adatok2 = new autok(egysor);
                    autok.Add(adatok2);
                }

                int length2 = autok.Count;

                olvas2.Close();
                #endregion

                Console.WriteLine("\tAz Adott ügyfélhez {0} különböző autót bérelt.", length2);

            }
            catch (Exception)
            {
                Console.WriteLine("\tAz Autok.csv nevű fájl beolvasása sikeretlen!");
            }
            #endregion

            #region 2. feladat
            Console.WriteLine("2. feladat");

            #region berles
            List<string> rendezettrendszamok = new List<string>();
            for (int i = 0; i < berles.Count; i++)
            {
                rendezettrendszamok.Add(berles[i].rendszam);
            }
            csereRendezesSzoveg(rendezettrendszamok);


            List<string> rendezettberleskezd = new List<string>();
            for (int i = 0; i < berles.Count; i++)
            {
                rendezettberleskezd.Add(berles[i].berleskezd);
            }
            csereRendezesSzoveg(rendezettberleskezd);


            foreach (var elem in rendezettrendszamok)
            {
                Console.WriteLine("\t {0}", elem);
               /* for (int i = 0; i < berles.Count; i++)
                {
                    if (elem == berles[i].rendszam)
                    {
                        Console.WriteLine(elem);
                    }
                }*/
            }

            #endregion



                #region autok
                List<string> rendezettrendszamok2 = new List<string>();
                for (int i = 0; i < autok.Count; i++)
                {
                    rendezettrendszamok2.Add(autok[i].rendszam);
                }
                csereRendezesSzoveg(rendezettrendszamok2);
            #endregion




            #endregion

            #region 3. feladat
            Console.WriteLine("3. feladat:");
            Console.WriteLine("\t Adja meg a rendszámot:");
            
            
            int hiba = 0;

            do
            {
                string rendszam = Console.ReadLine();

                if (rendszam.Length > 8)
                {
                    hiba += 1;
                }

            }
            while (hiba < 2);

            if (hiba > 3)
            {
                Console.WriteLine("rendszamss");
            } 


            #endregion


            Console.ReadKey();
            }
        }
    }
