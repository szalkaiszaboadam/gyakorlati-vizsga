using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
