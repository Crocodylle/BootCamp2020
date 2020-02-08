using System;
using System.Globalization;

namespace ExericiosProgramacaoOrientadoObjetosExericios03 {
    class Program {
        static void Main(string[] args) {


            Aluno Al = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            Al.nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            Al.nota1 = double.Parse(Console.ReadLine());
            Al.nota2 = double.Parse(Console.ReadLine());
            Al.nota3 = double.Parse(Console.ReadLine());


            Console.WriteLine("Nota Final = " + Al.Somatoria().ToString("F2", CultureInfo.InvariantCulture));

            if (Al.Aprovado() ){
                Console.WriteLine("Aprovado");
            }

            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + Al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture + " Pontos"));
            }

        }

    } 
} 
