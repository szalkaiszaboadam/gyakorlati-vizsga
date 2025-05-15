using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyelvvizsga
{

    class sikeres
    {
        public string nyelv;
        public int e2009;
        public int e2010;
        public int e2011;
        public int e2012;
        public int e2013;
        public int e2014;    
        public int e2015;
        public int e2016;
        public int e2017;
      //  public int e2018;


        public sikeres(string sor)
        {
            string[] szet = sor.Split(';');

            this.nyelv = szet[0];
            this.e2009 = int.Parse(szet[1]);
            this.e2010 = int.Parse(szet[2]);
            this.e2011 = int.Parse(szet[3]);
            this.e2012 = int.Parse(szet[4]);
            this.e2013 = int.Parse(szet[5]);
            this.e2014 = int.Parse(szet[6]);
            this.e2015 = int.Parse(szet[7]);
            this.e2016 = int.Parse(szet[8]);
            this.e2017 = int.Parse(szet[9]);
            //this.e2018 = int.Parse(szet[10]);


        }

    }

    class sikeretlen
    {

        public string nyelv;
        public int e2009;
        public int e2010;
        public int e2011;
        public int e2012;
        public int e2013;
        public int e2014;
        public int e2015;
        public int e2016;
        public int e2017;
       // public int e2018;

        public sikeretlen(string sor)
        {
            string[] szet = sor.Split(';');


            this.nyelv = szet[0];
            this.e2009 = int.Parse(szet[1]);
            this.e2010 = int.Parse(szet[2]);
            this.e2011 = int.Parse(szet[3]);
            this.e2012 = int.Parse(szet[4]);
            this.e2013 = int.Parse(szet[5]);
            this.e2014 = int.Parse(szet[6]);
            this.e2015 = int.Parse(szet[7]);
            this.e2016 = int.Parse(szet[8]);
            this.e2017 = int.Parse(szet[9]);
           // this.e2018 = int.Parse(szet[10]);



        }


        internal class Program
        {

            static void Main(string[] args)
            {

     

                List<sikeres> sikeres = new List<sikeres>();
                try
                {
                  

                    StreamReader olvas = new StreamReader("sikeres.csv");

                    olvas.ReadLine();

                    while (!olvas.EndOfStream)
                    {
                        string egysor = olvas.ReadLine();
                        sikeres adatok = new sikeres(egysor);
                        sikeres.Add(adatok);
                    }

               

                    olvas.Close();
                 

              

                }
                catch (Exception)
                {
                    Console.WriteLine("\tA sikeres.csv nevű fájl beolvasása sikeretlen!");
                }


                List<sikeretlen> sikeretlen = new List<sikeretlen>();
                try
                {
                    

                    StreamReader olvas2 = new StreamReader("sikertelen.csv");

                    olvas2.ReadLine();

                    while (!olvas2.EndOfStream)
                    {
                        string egysor = olvas2.ReadLine();
                        sikeretlen adatok2 = new sikeretlen(egysor);
                        sikeretlen.Add(adatok2);
                    }
  

                    olvas2.Close();
             
               
                }
                catch (Exception)
                {
                    Console.WriteLine("\tA sikeretlen.csv nevű fájl beolvasása sikeretlen!");
                }




                Console.WriteLine("2. feladat: A legnépszerűbb nyelvek:");

                List<int>legnepszerubbTemp = new List<int>();
                List<int> legnepszerubb = new List<int>();

                for (int i = 0; i < sikeres.Count; i++)
                {
                    legnepszerubbTemp.Add(
                 sikeres[i].e2009 +
                 sikeres[i].e2010 +
                 sikeres[i].e2011 +
                 sikeres[i].e2012 +
                 sikeres[i].e2013 +
                 sikeres[i].e2014 +
                 sikeres[i].e2015 +
                 sikeres[i].e2016 +
                 sikeres[i].e2017 //+
                /* sikeres[i].e2018*/);

                    legnepszerubb.Add(
                        sikeres[i].e2009 +
                        sikeres[i].e2010 +
                        sikeres[i].e2011 +
                        sikeres[i].e2012 +
                        sikeres[i].e2013 +
                        sikeres[i].e2014 +
                        sikeres[i].e2015 +
                        sikeres[i].e2016 +
                        sikeres[i].e2017 //+
                       /* sikeres[i].e2018*/);
                }
                for (int i = 0; i < sikeretlen.Count; i++)
                {

                    legnepszerubbTemp[i] += (
  sikeres[i].e2009 +
  sikeres[i].e2010 +
  sikeres[i].e2011 +
  sikeres[i].e2012 +
  sikeres[i].e2013 +
  sikeres[i].e2014 +
  sikeres[i].e2015 +
  sikeres[i].e2016 +
  sikeres[i].e2017 //+
  /*sikeres[i].e2018*/);


                    legnepszerubb[i] += (
               sikeres[i].e2009 +
               sikeres[i].e2010 +
               sikeres[i].e2011 +
               sikeres[i].e2012 +
               sikeres[i].e2013 +
               sikeres[i].e2014 +
               sikeres[i].e2015 +
               sikeres[i].e2016 +
               sikeres[i].e2017 //+
               /*sikeres[i].e2018*/);



                }

                
                legnepszerubbTemp.Sort((a, b) => b.CompareTo(a));

                /*foreach (int i in legnepszerubb)
                {
                    Console.WriteLine(i);
                }*/

                List<int> haromleg = legnepszerubbTemp.GetRange(0, 3);


        

                List<int> haromlegIndex = new List<int>();

                for (int i = 0; i < legnepszerubb.Count; i++)
                {
                    if (legnepszerubb[i] == haromleg[0])
                    {
                        haromlegIndex.Add(i);
                    }
                    if (legnepszerubb[i] == haromleg[1])
                    {
                        haromlegIndex.Add(i);
                    }
                    if (legnepszerubb[i] == haromleg[2])
                    {
                        haromlegIndex.Add(i);
                    }

                }

                List<string> haromlegNyelvek = new List<string>();

                for (int i = 0; i < sikeres.Count; i++)
                {
                    {
                        if (i == haromlegIndex[0])
                        {
                            haromlegNyelvek.Add(sikeres[i].nyelv);
                        }
                        if (i == haromlegIndex[1])
                        {
                            haromlegNyelvek.Add(sikeres[i].nyelv);
                        }
                        if (i == haromlegIndex[2])
                        {
                            haromlegNyelvek.Add(sikeres[i].nyelv);
                        }



                    }
                }

                foreach (string i in haromlegNyelvek)
                {
                    Console.WriteLine("\t" + i);
                }


                Console.WriteLine("3. feladat:");
                //Console.Write("\tVizsgálandó év: ");
                //int ev = Convert.ToInt32(Console.ReadLine());


                int ev = -1;
                while (ev <= 2008 || ev > 2017)
                {
                    Console.Write("\tVizsgálandó év: ");
                    var input = Console.ReadLine();
                    int.TryParse(input, out ev);
                }


                Console.WriteLine("5. feladat:");
                for (int i = 0; i < sikeretlen.Count; i++)
                {
                    if (true)
                    {

                    }
                }

                Console.ReadKey();

            }
        }
    }
}
