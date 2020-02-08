using System;

namespace EstruturaRepetitivaWhile {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha " +
             "incorreta informada, escrever a mensagem Senha Invalida .Quando a senha for informada corretamente deve ser impressa a mensagem " +
              "Acesso Permitido e o algoritmo encerrado.Considere que a senha correta é o valor 2002. ");

            Console.WriteLine("Digite a senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite a senha");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");
        }


        Console.WriteLine("-----------------------------");
            Console.WriteLine("Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema" + 
            "cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo " + 
             "menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).  ");

               string[] vet4 = Console.ReadLine().Split(' ');
               int x = int.Parse(vet4[0]);
               int y = int.Parse(vet4[1]);

               while ((x != 0) || (y != 0)) {

                if (x > 0 && y > 0) { Console.WriteLine("primeiro"); }
                else if (x< 0 && y> 0) { Console.WriteLine("segundo"); }
                else if (x< 0 && y< 0) { Console.WriteLine("terceiro"); }
                else if (x > 0 && y< 0) { Console.WriteLine("quarto"); }

                vet4 = Console.ReadLine().Split(' ');
                x = int.Parse(vet4[0]);
                y = int.Parse(vet4[1]);
            }
     
     
   
           Console.WriteLine("-----------------------------");
           Console.WriteLine("Digite 1 para alcool, 2 para gasolina, 3 diesel e 4 Fim ");
            int comb = int.Parse(Console.ReadLine());

             int alc, diesel, gaso;
             alc = 0; diesel = 0; gaso = 0; 

            while (comb != 4 ) {

                if (comb == 1 ) {
                    alc = alc + 1;  
                }
                else if (comb == 2 ) {
                    gaso = gaso + 1; 
                }
                else if (comb == 3 ) {
                    diesel = diesel + 1;
                }
                comb = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(" Muito Obrigado ");
            Console.WriteLine("Alcool: " + alc);
            Console.WriteLine("Gasolina: " + gaso);
            Console.WriteLine("Diesel: " + diesel);
        }
} 

    }
}