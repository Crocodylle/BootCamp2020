using System;
using System.Globalization; 
namespace Datetime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d10 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d4 = new DateTime.Now; 
            DateTime d5 = new DateTime.Today;
            DateTime d6 = new DateTime.UtcNow;

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d10);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine("-------------------------------------------");
            DateTime a1 = DateTime.Parse("2000-08-15");
            DateTime a2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime a3 = DateTime.Parse("15/08/2000");
            DateTime a4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Console.WriteLine("-------------------------------------");

            DateTime c1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime c2 = DateTime.ParseExact("18/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(c1);
            Console.WriteLine(c2);


        }
    }
}
