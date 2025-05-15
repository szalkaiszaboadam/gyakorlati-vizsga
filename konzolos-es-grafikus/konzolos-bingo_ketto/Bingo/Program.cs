using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class BingoJatekos
    {
        public string neve;
        string[,] tabla = new string[5, 5];

        public BingoJatekos(string sor)
        {
            string[] szet = sor.Split('.');

            this.neve = szet[0];



            List<BingoTabla> osszesSzam = new List<BingoTabla>();

            StreamReader olvas2 = new StreamReader(szet[0] + ".txt"); 

            while (!olvas2.EndOfStream)
            {
                string egysor = olvas2.ReadLine();
                BingoTabla adatok = new BingoTabla(egysor);
                osszesSzam.Add(adatok);
            }

            olvas2.Close();

            List<string> osszesSzam2 = new List<string>();

            for (int i = 0; i < osszesSzam.Count; i++)
            {
                string egy = osszesSzam[i].egy;
                string ketto = osszesSzam[i].ketto;
                string harom = osszesSzam[i].harom;
                string negy = osszesSzam[i].negy;
                string ot = osszesSzam[i].ot;
                osszesSzam2.Add(egy);
                osszesSzam2.Add(ketto);
                osszesSzam2.Add(harom);
                osszesSzam2.Add(negy);
                osszesSzam2.Add(ot);
            }

            #region tabla
            tabla[0, 0] = osszesSzam2[0];
            tabla[0, 1] = osszesSzam2[1];
            tabla[0, 2] = osszesSzam2[2];
            tabla[0, 3] = osszesSzam2[3];
            tabla[0, 4] = osszesSzam2[4];
            tabla[1, 0] = osszesSzam2[5];
            tabla[1, 1] = osszesSzam2[6];
            tabla[1, 2] = osszesSzam2[7];
            tabla[1, 3] = osszesSzam2[8];
            tabla[1, 4] = osszesSzam2[9];
            tabla[2, 0] = osszesSzam2[10];
            tabla[2, 1] = osszesSzam2[11];
            tabla[2, 2] = osszesSzam2[12];
            tabla[2, 3] = osszesSzam2[13];
            tabla[2, 4] = osszesSzam2[14];
            tabla[3, 0] = osszesSzam2[15];
            tabla[3, 1] = osszesSzam2[16];
            tabla[3, 2] = osszesSzam2[17];
            tabla[3, 3] = osszesSzam2[18];
            tabla[3, 4] = osszesSzam2[19];
            tabla[4, 0] = osszesSzam2[20];
            tabla[4, 1] = osszesSzam2[21];
            tabla[4, 2] = osszesSzam2[22];
            tabla[4, 3] = osszesSzam2[23];
            tabla[4, 4] = osszesSzam2[24];
            #endregion

        }

    }

    class BingoTabla
    {
        public string egy;
        public string ketto;
        public string harom;
        public string negy;
        public string ot;

        public BingoTabla(string sor)
        {
            string[] szet = sor.Split(';');

            this.egy = szet[0];
            this.ketto = szet[1];
            this.harom = szet[2];
            this.negy = szet[3];
            this.ot = szet[4];

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1, 2, 3
            List<BingoJatekos> jatekosok = new List<BingoJatekos>();

            StreamReader olvas = new StreamReader("nevek.text");

            while (!olvas.EndOfStream)
            {
                string egysor = olvas.ReadLine();
                BingoJatekos adatok = new BingoJatekos(egysor);
                jatekosok.Add(adatok);
            }

            olvas.Close();
            #endregion

            #region 4
            Console.WriteLine("4. Feladat: Játékosok száma: {0}", jatekosok.Count);
            #endregion

            Console.WriteLine("7. Feladat: Kihúzott számok");

            List<string> veletlenSzamok = new List<string>();
            Random rnd = new Random();

            for (int j = 0; j < 100; j++)
            {
                string temp = rnd.Next(1, 76).ToString();
                if (!(veletlenSzamok.Contains(temp)))
                {
                    veletlenSzamok.Add(temp);
                }
                int szam = 1;
                Console.WriteLine("{0} --> {1}", szam, temp);

            }



            Console.ReadKey();
        }
    }
}
