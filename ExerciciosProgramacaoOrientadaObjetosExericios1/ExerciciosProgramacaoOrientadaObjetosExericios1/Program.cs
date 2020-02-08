﻿using System;
using System.Globalization;

namespace ExerciciosProgramacaoOrientadaObjetosExericios1 {
    class Program {
        static void Main(string[] args) {

            Retangulo R = new Retangulo(); 
                
                                   
            Console.WriteLine("Enrte a Largura e Altura do retangulo: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine( "Area = " + R.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
