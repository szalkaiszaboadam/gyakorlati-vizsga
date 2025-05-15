using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Feladat
{
    internal class Program
    {

        static double feladatEgy(double[] x)
        {
            double legnagyobbkulonb = Math.Round(x[1] - x[0]);
            for (int i = 2; i < x.Length; i++)
            {
                if (x[i] - x[i-1] > legnagyobbkulonb)
                {
                    legnagyobbkulonb = x[i]- x[i -1];
                }
            }
            return legnagyobbkulonb;
        }

        static double feladatKetto(double[] x)
        {
            double legkisebbkulonb = Math.Round(x[1] - x[0]);
            for (int i = 0; i < x.Length-1; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if ( Math.Abs(x[i] - x[j]) < legkisebbkulonb)
                    {
                        legkisebbkulonb = Math.Abs(x[i] - x[j]);
                    }
                }
            }
            return legkisebbkulonb;
        }

        static int feladatHarom(int x)
        {
            int db = 0;
            while (x % 2 == 0) 
            {
                x = x / 2;
                db++;
            }
            return db;  
        }

        static int[] feladatNegy(int x) 
        {
            int[] ermek = { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] hanyerme = new int[ermek.Length];

            int ii = 0;
            while (ii < ermek.Length && x != 0)
            {
                hanyerme[ii] = x / ermek[ii];
                x = x % ermek[ii];
                ii++;
            }
            return hanyerme;    
        }

        static void feladatHet()
        {
            Console.Write("Kérek egy hexadecimális számot: ");
            string hexnum = Console.ReadLine();

            int outputnum = 0;
            Dictionary<string, int> hexaertekek = new Dictionary<string, int>() {
                {"0", 0 },
                {"1", 1 },
                {"2", 2 },
                {"3", 3 },
                {"4", 4 },
                {"5", 5 },
                {"6", 6 },
                {"7", 7 },
                {"8", 8 },
                {"9", 9 },
                {"A", 10 },
                {"B", 11 },
                {"C", 12 },
                {"D", 13 },
                {"E", 14 },
                {"F", 15 }
            };
            for (int i = hexnum.Length; i >= 0; i--)
            {
                char digit = hexnum[i];
                int pos = (int)Math.Pow(10, digit);
            }
        }

        static void Main(string[] args)

        {
            //1. feladat és 2. feladat
            double[] valos = { 1, 64, 95, 16.4, 1.98, 200, 5000, 2000.4 };
            double tesztlegnagyobbkulonb = 4800;
            double tesztlegkisebbkulonb = 0.98;
            Console.WriteLine("1. feladat: {0}", feladatEgy(valos) == tesztlegnagyobbkulonb);
            Console.WriteLine("2. feladat: {0}", feladatKetto(valos) == tesztlegkisebbkulonb);


            //3. feladat
            int egeszszam = 12, tesztprim2 = 2;
            Console.WriteLine("3. feladat: {0}", feladatHarom(egeszszam) == tesztprim2);

            //4. feladat
            int osszeg = 6958;
            Console.WriteLine("4. feladat:");
            List<int> cimletek = feladatNegy(osszeg).ToList();


            #region 5. feladat
            Console.WriteLine("5. feladat");
            Console.Write("\tÍrjon be egy egész számot: ");
            int fibonacciiszam = 0;
            fibonacciiszam = int.Parse(Console.ReadLine());
            var fibonaccii = new List<int>();
            int a = 0; int b = 1;
            for (int i = 0; i < 100; i++)
            {

                fibonaccii.Add(a);
                int csere = a;
                a = b;
                b = csere + b;
            }

            int tru = 0;
            for (int i = 0; i < fibonaccii.Count; i++)
            {
                if (fibonacciiszam == fibonaccii[i])
                {
                    Console.WriteLine("\tA megadott szám eleme a Fibonacchi-sorozatnak!");
                    tru = 1; break;
                }
            }

            if (tru == 0)
            {
                Console.WriteLine("\tA megadott szám nem eleme a Fibonacchi-sorozatnak!");
            }
            #endregion

            #region 6. feladat
            Console.WriteLine("6. feladat:");

            Console.Write("\tÍrjon be egy egész számot paraméterként: ");
            int bekertszam0 = 0;
            bekertszam0 = int.Parse(Console.ReadLine());

            int bekertszam0temp = bekertszam0;

            List<int> eredmeny0 = new List<int>();

            int maradek0;
            while (bekertszam0 > 0)
            {
                maradek0 = bekertszam0 % 2;
                bekertszam0 = bekertszam0 / 2;
                eredmeny0.Add(maradek0);
            }

            Console.Write("\tA(z) {0} átkovertálva 2-s számrendszerbe: ", bekertszam0temp);
            for (int i = eredmeny0.Count - 1; i >= 0; i--)
            {
                Console.Write("{0}", eredmeny0[i]);
            }

            #endregion

            //7. feladat
            

            #region 8. feladat 
            Console.WriteLine("\n8. feladat:");

            Console.Write("\tÍrjon be egy egész számot: ");
            int bekertszam = 0;
            bekertszam = int.Parse(Console.ReadLine());

            int bekertszamtemp = bekertszam;

            int szamrendszer = 0;
            do
            {
                Console.Write("\tÍrjon be egy tetszlőeges számrendszert:");
                szamrendszer = int.Parse(Console.ReadLine());
            } while (!(szamrendszer >= 2 && szamrendszer <= 9));

            List<int> eredmeny = new List<int>();

            int maradek;
            while (bekertszam > 0)
            {
                maradek = bekertszam % szamrendszer;
                bekertszam = bekertszam / szamrendszer;
                eredmeny.Add(maradek);
            }

            Console.Write("\tA(z) {0} átkovertálva {1}-s számrendszerbe: ", bekertszamtemp, szamrendszer);
            for (int i = eredmeny.Count-1; i >= 0; i--)
            {
                Console.Write("{0}", eredmeny[i]);
            }
            #endregion

            #region 9. feladat
            Console.WriteLine("\n9. feladat");
            int szam = 0;
            Console.Write("\tÍrjon be egy öttel osztható páratlan egész számot: ");
            do
            {
                szam = int.Parse(Console.ReadLine());
            } while (!(!(szam % 2 == 0) && szam % 5 == 0));

            #endregion

            #region 10. feladat
            Console.WriteLine("10. feladat:");
            StreamWriter ir = new StreamWriter("lista.txt");

            for (int i = 0; i < 11; i++)
            {
                ir.WriteLine(i);
            }

            ir.Close();

            string file = @"lista.txt";
            for (int i = file.Length; i > 0; i--)
            {
                Console.WriteLine("\t{0}", i);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
