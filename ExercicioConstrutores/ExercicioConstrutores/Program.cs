using System;
using System.Globalization;

namespace ExercicioConstrutores {
    class Program {
        static void Main(string[] args) {
                     

            Console.WriteLine("Entre o Numero da Conta:");
            Console.Write("Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do titular da conta: ");
            Console.Write("nome: ");
            string nome = Console.ReadLine(); 

            Console.WriteLine("Havera deposito inicial s/n?");
            Char depositoInicial = char.Parse(Console.ReadLine());
            
            double saldo = 0; 
            if (depositoInicial == 'S' || depositoInicial == 's' ) {
                Console.WriteLine("Entre com o valor de deposito inicial: ");
                 saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } 
                    
            ContaBancaria Conta = new ContaBancaria(numero, nome, saldo);
   

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta " + Conta);
            Console.WriteLine();
       
            Console.WriteLine("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.FazerDeposito(deposito); 
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write("Conta " + Conta);
            Console.WriteLine();
            
            Console.WriteLine("Entre um valor para Saque: ");
            Double  saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.FazerSaque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write("Conta :" + Conta);
                                
        }
    }
}
