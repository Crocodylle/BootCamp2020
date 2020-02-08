using System;
using System.Globalization; 
namespace V_etorParte2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produtc[] vect = new Produtc[n];
              
            for (int i = 0 ; i < n; i++) {
                string name = Console.ReadLine(); 
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produtc { Name = name, Price = price }; 
            }

            double sum = 0.0; 
            for (int i = 0 ; i < n; i ++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
