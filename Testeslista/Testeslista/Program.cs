using System;
using System.Globalization;

namespace Testeslista {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite numeros para saber o fatorial ");

            int v5 = int.Parse(Console.ReadLine());


            for (int i = 1; i <= v5; i++) {

                double quad = Math.Pow(i,2);
                double cubo = Math.Pow(i,3);
                Console.WriteLine( i + " " + quad + " " + cubo);
            
            }
        }
    }
}
