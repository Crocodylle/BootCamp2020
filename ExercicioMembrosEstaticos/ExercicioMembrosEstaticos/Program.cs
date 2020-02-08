using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual a Cotacao do Dolar ?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai Comprar ?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double val = ConversorDeMoeda.valor(cotacao, dolar);
            

            Console.WriteLine("O valor a ser pago em reais = " + val.ToString("F2", CultureInfo.InvariantCulture ));
        }
    }
}
