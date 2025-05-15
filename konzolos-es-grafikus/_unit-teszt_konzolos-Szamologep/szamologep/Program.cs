using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace szamologep
{
  

    internal class Program
    {

        public class Szamologep
        {
            public int osszeadas(int x, int y)
            {
                return x + y;
            }

            public int kivonas(int x, int y)
            {
                return x - y;
            }

            public int szorzas(int x, int y)
            {
                return x * y;
            }

            public int osztas(int x, int y)
            {
                return x / y;
            }

            public double[] masodfoku(double a, double b, double c)
            {


                double d = Math.Pow(b,2) - 4 * a * c, gyök1, gyök2;
                if (d < 0) {
                    return new double[] { };
                else
                {
                    if (d == 0)
                    {
                        gyök1 = -b / (2 * a);
                        Console.WriteLine("Egy valós gyök van, értéke: {0}", gyök1);
                    }
                    else
                    {
                        gyök1 = (-b + Math.Sqrt(d)) / (2 * a);
                        gyök2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine("Két valós gyök van, értékük: {0} és {1}", gyök1, gyök2);
                    }
                }
                
            
            }


        }

        static void Main(string[] args)
        {
            Console.Write("Adj meg két számot:\n - ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" - ");
            int y = Convert.ToInt32(Console.ReadLine());

            Szamologep szamolo = new Szamologep();

            Console.WriteLine(szamolo.osszeadas(x, y));
            Console.WriteLine(szamolo.kivonas(x, y));
            Console.WriteLine(szamolo.szorzas(x, y));
            Console.WriteLine(szamolo.osztas(x, y));

            Console.Write("Adj meg három számot:\n - ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" - ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" - ");
            double c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(szamolo.masodfoku(a, b, c));

            Console.ReadKey();
        }
    }
}
