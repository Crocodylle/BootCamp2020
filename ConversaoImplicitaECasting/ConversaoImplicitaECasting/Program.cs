using System;

namespace ConversaoImplicitaECasting {
    class Program {
        static void Main(string[] args) {


            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            double c;
            int d;
            c = 5.1;
            d = (int)a;
            Console.WriteLine(d);

            int l = 5;
            int w = 2;

            double resultado = (double)l / w;
            Console.WriteLine(resultado);




        }
    }
}
