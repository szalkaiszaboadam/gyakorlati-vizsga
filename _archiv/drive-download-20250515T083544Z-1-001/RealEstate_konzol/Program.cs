using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace RealEstate_konzol
{
    class Ad {
        public int Area;
        public int Id;
        public int Floors;
        public int Rooms;
        public string Description;
        public string ImageUrl;
        public string LatLong;
        public bool FreeOfCharge;
        public Category Category;
        public Seller Seller;
        public DateTime CreateAt;
        public static List<Ad> LoadFromCsv(string fileName)
        {
            string[] sorok = File.ReadAllLines(fileName, Encoding.UTF8).Skip(1).ToArray();
            List<Ad> ads = new List<Ad>();

            foreach (var item in sorok)
            {
                Ad ad = new Ad();
                var columns = item.Split(';');
                ad.Id = int.Parse(columns[0]);
                ad.Area = int.Parse(columns[4]);
                ad.Floors = int.Parse(columns[3]);
                ad.Rooms = int.Parse(columns[1]);
                ad.Description = columns[5];
                ad.ImageUrl = columns[7];
                ad.LatLong = columns[2];
                ad.FreeOfCharge = columns[6] == "1";
                ad.Category = new Category() 
                {
                    Id = int.Parse(columns[12]),
                    Name = columns[13],
                };
                ad.Seller = new Seller() 
                { 
                Id = int.Parse(columns[9]),
                Name = columns[10],
                Phone = columns[11]
                };
                ad.CreateAt = DateTime.Parse(columns[8]);


                ads.Add(ad);
            }
            return ads;
        }

        public double DistanceTo(string coord)
        {
            double a = double.Parse(coord.Split(',')[0]);
            double b = double.Parse(coord.Split(',')[1]);

            var x = Math.Abs(a - double.Parse(LatLong.Split(',')[0]));
            var y = Math.Abs(b - double.Parse(LatLong.Split(',')[1]));

            return Math.Sqrt(x * x + y * y);

        }
        public override string ToString()
        {
            return ($"\tEladó neve\t: {Seller.Name}\n\tEladó telefonja: {Seller.Phone}\n\tAlapterület\t:{Area}\n\tSzobák száma\n: {Rooms}"); 
        }

    }

    class Seller {
        public int Id;
        public string Name;
        public string Phone;
    }
    
    class Category
    {
        public int Id;
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {



            List<Ad> ads =  Ad.LoadFromCsv("realestates.csv");

            var average = ads.Where(x => x.Floors == 0).Average(x => x.Area);

            var closest = ads.Where(x => x.FreeOfCharge).Min(x => x.DistanceTo("1, 2"));


            Console.WriteLine(average);
            Console.WriteLine(closest);

            Console.ReadKey();
        }
    }
}
