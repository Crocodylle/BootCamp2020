using System;

namespace ExerciciosVetores {
    class Program {
        static void Main(string[] args) {

            Estudantes[] vect = new Estudantes[10];
            Console.WriteLine("How many rooms will be rented");
            int n = int.Parse(Console.ReadLine());
                       
             for (int i = 1; i <= n; i++) {
                Console.WriteLine("Rent #" + i);
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++) {
                if(vect[i] != null) {
                     Console.WriteLine(i + ":" + vect[i]);
            }
            }
        }
    }
} 
