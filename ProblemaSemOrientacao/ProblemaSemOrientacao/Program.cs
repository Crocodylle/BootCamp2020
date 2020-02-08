﻿using System;
using System.Globalization;

namespace ProblemaSemOrientacao {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo(); 

            Console.WriteLine("Enre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com duas medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area(); 

            double areaY = y.Area(); 


            Console.WriteLine("area do triangulo x " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area do triangulo y " + areaY.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}