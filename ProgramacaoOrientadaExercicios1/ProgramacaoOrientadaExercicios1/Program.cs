using System;

namespace ProgramacaoOrientadaExercicios1 {
    class Program {
        static void Main(string[] args) {

            Pessoa primeiro, segundo;

             primeiro  = new Pessoa();
             segundo = new Pessoa(); 

             Console.WriteLine("Dados da primeira Pessoa: ");
             Console.WriteLine("Nome : ");
             primeiro.nome = Console.ReadLine();
            Console.WriteLine("idade : ");
            primeiro.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa: ");
            Console.WriteLine("Nome : ");
            segundo.nome = Console.ReadLine();
            Console.WriteLine("idade : ");
            segundo.idade = int.Parse(Console.ReadLine());

            if ( primeiro.idade > segundo.idade) {
                Console.WriteLine("Pessoa mais velha:" + primeiro.nome); 
            }
            else Console.WriteLine("Pessoa mais velha:" + segundo.nome);
        }   
    }
}
