using System;

namespace ListaEstruturadeDadosIfElse {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");


            int n1 = int.Parse(Console.ReadLine());
            if (n1 < 0) Console.WriteLine("NEGATIVO");
            else Console.WriteLine("POSITIVO");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 % 2 == 0) Console.WriteLine("Par");
            else Console.WriteLine("Impar");


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem Sao Multiplos ou Nao sao " +
                "Multiplos, indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em " +
                              " ordem crescente ou decrescente.");
            string[] vet = Console.ReadLine().Split(' ');
            int n3 = int.Parse(vet[0]);
            int n4 = int.Parse(vet[1]);

            if (n3 % 2 == 0 && n4 % 2 == 0) { Console.WriteLine("Sao Multiplos"); } 
            else {  Console.WriteLine("Nao sao Multiplos"); 
            } 




            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode " +
             "começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");

            string[] vet2 = Console.ReadLine().Split(' ');
            int n5 = int.Parse(vet2[0]);
            int n6 = int.Parse(vet2[1]);

            int durou;
            if (n5 < n6) { durou = n5 - n6; }
            else if (n5 > n6) { durou = ((n5 - 24) + n6)}
            else if (n5 == n6) { durou = 24; }

            Console.WriteLine("O jogo durou {durou} horas(s)");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A" +
                            "seguir, calcule e mostre o valor da conta a pagar. ");

            string[] vet3 = Console.ReadLine().Split(' ');
            int Codigo = int.Parse(vet3[0]);
            int Quanti = int.Parse(vet3[1]);
            double total;

            if (Codigo == 1) {
                total = Quanti * 4.00;
                Console.WriteLine("Total: R$ " + total);
            }
            else if (Codigo == 2) {
                total = (Quanti * 4.50);
                Console.WriteLine("Total: R$ " + total);
            }
            else if (Codigo == 3) {
                total = Quanti * 5.00;
                Console.WriteLine("Total: R$ " + total);
            }
            else if (Codigo == 4) {
                total = Quanti * 2.00;
                Console.WriteLine("Total: R$ " + total);
            }
            else if (Codigo == 5) {
                total = Quanti * 1.50;
                Console.WriteLine("Total: R$ " + total);
            }


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos" + 
      "seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em " + 
      " nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.");

            double num = double.Parse(Console.ReadLine());

            if (num > 0 && num <= 25) {
                Console.WriteLine("Intevalo (0,50]");
            }
            else if (num > 25 && num <= 50) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (num > 50 && num <= 75) {
                Console.WriteLine("Intevalo [50,75]");
            }
            else if (num > 75 && num <= 100) {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else
                Console.WriteLine("Fora do intervalo");
        }


        Console.WriteLine("---------------------------------------");
            Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas" +  
                  "de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o " + 
                    "ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).  ");

        string[] vet4 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(vet4[0]);
        double y1 = double.Parse(vet4[1]);

            if (x1 > 0 && y1 > 0) {
                Console.WriteLine("Q1");
            }
            else if (x1< 0 && y1> 0) {
                Console.WriteLine("Q2");
            }
            else if (x1< 0 && y1< 0) {
                Console.WriteLine("Q3");
            }
            else if (x1 > 0 && y1< 0) {
                Console.WriteLine("Q4");
            }
            else Console.WriteLine("origem");
        }



    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem " + 
      "que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem  qualquer desvio." + 
      " A moeda deste país é o Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb.
      "Em seguida, calcule eostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.");
    
     double salario = double.Parse(Console.ReadLine());
           
            if (salario >=0  && salario <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario <= 3000.00) {
              double total1 = (salario - 2000.00) * 0.08;
              Console.WriteLine("RS " + total1.ToString("F2", CultureInfo.InvariantCulture));
                    } 
            else if (salario >= 3000.01 && salario <= 4500.00) {
                double x = salario - 3000.01;
                double total1 = x * 0.18 + 80;
                Console.WriteLine("R$ " + total1.ToString("F2", CultureInfo.InvariantCulture));
                   }
              else if (salario > 4500.00) {
                 double total1 = ((salario - 4500.00) * 0.28) + 80 + 270;
             Console.WriteLine("R$ " + total1.ToString("F2", CultureInfo.InvariantCulture));
                    } 
    }



        }
    }
