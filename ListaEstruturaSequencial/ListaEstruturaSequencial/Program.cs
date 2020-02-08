using System;
using System.Globalization;

namespace ListaEstruturaSequencial {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma " +
                  "  mensagem explicativa, conforme exemplos.");
            Console.WriteLine(" ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = n2 + n1;
            Console.WriteLine("Soma = " + n3);

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(" Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro" +
                          "casas decimais conforme exemplos.");

            Console.WriteLine(" ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(" Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto " +
                       "de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)..");

            Console.WriteLine("------");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int E = (A * B) - (C * D);
            Console.WriteLine("Diferenca = " + E);

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(" Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por " +
                       "hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais");
            int funcionario = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            double HH = double.Parse(Console.ReadLine());

            double calculo = horas * HH;
            Console.WriteLine("Numero " + funcionario);
            Console.WriteLine("Salary = U$" + calculo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(" Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o " +
                         "código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.");
            string[] vet = Console.ReadLine().Split(' ');
            int peca = int.Parse(vet[0]);
            int numeropeca = int.Parse(vet[1]);
            double valor = double.Parse(vet[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(vet2[0]);
            int numeropeca2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2]);

            double total = numeropeca * valor + numeropeca2 * valor2;

            Console.WriteLine("Valor a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(" Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e " +
                             "mostre: a) a área do triângulo retângulo que tem A por base e C por altura. " +
                             "b) a área do círculo de raio C. (pi = 3.14159) c) a área do trapézio que tem A e B por bases e C por altura." +
                              "d) a área do quadrado que tem lado B. e) a área do retângulo que tem lados A e B.");

            string[] vet4 = Console.ReadLine().Split(' ');
            double A1 = double.Parse(vet4[0]);
            double B1 = double.Parse(vet4[1]);
            double C1 = double.Parse(vet4[2]);

            double triangulo = (A1 * C1) / 2;
            double circulo = C1 * 3.14159;
            double trapezio = ((A1 + B1) * C1) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A1 * B1;


            Console.WriteLine("TRIANGULO: " + triangulo);
            Console.WriteLine("CIRCULO: " + circulo);
            Console.WriteLine("Trapezio: " + trapezio);
            Console.WriteLine(" Quadrado: " + quadrado);
            Console.WriteLine(" Retangulo:" + retangulo);




        }
    }
}
