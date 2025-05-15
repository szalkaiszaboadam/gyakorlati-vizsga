using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statisztika
{
    class stat
    {
        public string jatekos;
        public string elsodobas;
        public string masodikdobas;
        public string harmadikdobas;


        public stat(string sor)
        {
            string[] szet = sor.Split(';');

            this.jatekos = szet[0];
            this.elsodobas = szet[1];
            this.masodikdobas = szet[2];
            this.harmadikdobas = szet[3];


        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {

            #region 1. feladat        
            List<stat> stat = new List<stat>();
            try
            {

                StreamReader olvas = new StreamReader("dobasok.txt");

                while (!olvas.EndOfStream)
                {
                    string egysor = olvas.ReadLine();
                    stat adatok = new stat(egysor);
                    stat.Add(adatok);
                }

                int length = stat.Count;

                olvas.Close();

                #region 2. feladat
                Console.WriteLine("2.feladat");
                Console.WriteLine("Körök száma: {0}", length);
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine("A dobasok.txt nevű fájl beolvasása sikeretlen!");
            }
            #endregion

            #region 3. feladat
            Console.WriteLine("3.feladat");

            #endregion
            int db = 0;
            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].harmadikdobas == "D25")
                {
                    db++;
                }
            }
            Console.WriteLine("3. dobásra Bullseye: {0}", db);

            #region 4. feladat
            Console.WriteLine("4. feladat");

            Console.Write("Adja meg a szektor értékét! Szektor= ");
            string bekert = Console.ReadLine();

            int elsodb = 0;
            int masodikdb = 0;

            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].elsodobas == bekert)
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
                if (stat[i].masodikdobas == bekert)
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
                if (stat[i].harmadikdobas == bekert)
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
                    Console.WriteLine("Az 1. játékos a(z) D16 szektoros dobásainak száma: {0}", elsodb);
                    Console.WriteLine("Az 2. játékos a(z) D16 szektoros dobásainak száma: {0}", masodikdb);
            #endregion

            #region 5. feladat
            Console.WriteLine("5. feladat");

            int elsofull = 0;
            int masodikfull = 0;

            for (int i = 0; i < stat.Count; i++)
            {
                if (stat[i].jatekos == "1" && stat[i].elsodobas == "T20" && stat[i].masodikdobas == "T20"  && stat[i].harmadikdobas == "T20")
                {
                    elsofull++;
                }

                if (stat[i].jatekos == "2" && stat[i].elsodobas == "T20" && stat[i].masodikdobas == "T20" && stat[i].harmadikdobas == "T20")
                {
                    masodikfull++;
                }

            }
            Console.WriteLine("Az 1. játékos {} db 180-ast dobott.", elsofull);
            Console.WriteLine("Az 2. játékos {} db 180-ast dobott.", masodikfull);
            #endregion


            Console.ReadKey();
        }
    }
}