using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            sbyte x = 100;
            Console.WriteLine(x);

            byte n1 = 255;
            n1++;
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            int n3 = 2147483647;
            Console.WriteLine(n3);

            long n4 = 2147483648L;
            Console.WriteLine(n4);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);

            char letra = '\u0041';
            Console.WriteLine(letra);

            float n5 = 4.5f;
            Console.WriteLine(n5);

            double n6 = 4.5;
            Console.WriteLine(n6);

            string nome = "Maria Green";
            Console.WriteLine(nome);

             object obj1 = "Alex Brown";
            Console.WriteLine(obj1);

            object obj2 = 4.5f;
            Console.WriteLine(obj2);
        }
    }
}

