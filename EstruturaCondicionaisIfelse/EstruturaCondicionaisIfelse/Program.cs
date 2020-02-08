using System;

namespace EstruturaCondicionaisIfelse {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com o numero inteiro");
            int x = int.Parse(Console.ReadLine()); 

            if ( x%2 == 0 ) {
                Console.WriteLine("PAR");
            }
            else
                Console.WriteLine("IMPAR"); 
        }
    }
}
