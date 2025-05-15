using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data;

namespace rgb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. feladat
            int[][] list = File.ReadAllLines("kep.txt")
                         .Select(l => l.Split(' ').Select(i => int.Parse(i)).ToArray())
                         .ToArray();
            #endregion

            #region 2. feladat
            Console.WriteLine("Kérem egy képont adatait!");

            Console.Write("Sor: ");
            int sor = int.Parse(Console.ReadLine());

            Console.Write("Oszlop: ");
            int oszlop = int.Parse(Console.ReadLine());
            
            //1, 2
            //86, 113, 0
            //Console.WriteLine(list[2][7]);


            Console.WriteLine("A képpont színe RGB({0}, {1}, {2})", list[sor-1][(oszlop -1) *3], list[sor - 1][(oszlop - 1) * 3 +1], list[sor - 1][(oszlop - 1) * 3 +2]);
            #endregion

            #region 3. feladat
            Console.WriteLine("3. feladat");

            int db = 0;

            for (int i = 0; i < 360; i++)
            {
                for (int yy = 0; yy < 1920; yy=yy+3)
                {
                    if (list[i][yy] + list[i][yy+1] + list[i][yy+2]  > 600)
                    {
                        db++;
                    }
                }
            }

            Console.WriteLine("A világos képpontok száma: {0}", db);
            #endregion


            #region 4. feladat



            #endregion



            Console.ReadKey();
        }
    }
}
