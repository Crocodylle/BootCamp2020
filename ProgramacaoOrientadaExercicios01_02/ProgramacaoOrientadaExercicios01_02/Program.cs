using System;
using System.Globalization;

namespace ProgramacaoOrientadaExercicios01_02 {
    class Program {
        static void Main(string[] args) {

            Funcionario primeiro, segundo;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Dados da primeira Funcionario: ");
            Console.WriteLine("Nome : ");
            primeiro.nome = Console.ReadLine();
            Console.WriteLine("salario : ");
            primeiro.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segundo Funcionario: ");
            Console.WriteLine("Nome : ");
            segundo.nome = Console.ReadLine();
            Console.WriteLine("salario : ");
            segundo.salario = double.Parse(Console.ReadLine());

            double media = (primeiro.salario + segundo.salario) / 2;
            Console.WriteLine("Salario medio "+ media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
