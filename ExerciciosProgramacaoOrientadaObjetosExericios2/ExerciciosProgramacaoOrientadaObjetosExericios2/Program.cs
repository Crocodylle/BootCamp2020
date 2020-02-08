using System;
using System.Globalization;

namespace ExerciciosProgramacaoOrientadaObjetosExericios2 {
    class Program {
        static void Main(string[] args) {

            Funcionario Func = new Funcionario();

            Console.Write("Nome: ");
            Func.nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            Func.imposto = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Funcionario: " + Func);

            Console.WriteLine("Digite a Porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine());
            Func.AumentarSalario(porcent);

            Console.WriteLine("Dados Atualizados: " + Func); 
        }
    }
}
