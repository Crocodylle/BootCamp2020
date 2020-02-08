using System;
using System.Globalization;

namespace EntradaDeDadosExercicio {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Fazer um programa para executar a seguinte interacao com o usuario, lendo os valores  " +
                "   destacados em vermelho, e depois mostrar os dados na tela");
            
            
            Console.WriteLine("Entre com o seu nome completo");
            string nome = Console.ReadLine(); 
           
            Console.WriteLine("Quantos quartos tem na sua casa");
            int quartos = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Entre com o preco de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);



        } 

    }
}
