using System;

namespace ExerciciosMatrizes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Linhas:");
            int linha = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Colunas");
            int coluna = int.Parse(Console.ReadLine());

            int[,] mat = new int[linha, coluna];
           
            for (int i = 0; i < linha; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++) {
                for (int j = 0; j < coluna; j++) {
                    if (mat[i, j] == number) {
                      
                        Console.WriteLine("Position " + i + "," + j +" :");
                    }
                    
                    if (j > 0 ) {
                        Console.WriteLine("Left:" + mat[i,j - 1]);
                    }
                    if (i > 0) {
                        Console.WriteLine("up :" + mat[i- 1, j]);
                    }
                    if (j < coluna - 1) {
                        Console.WriteLine("right:" + mat[i, j + 1]);
                     } 
                    if (i < linha - 1) {
                        Console.WriteLine("Down " + mat[i + 1 ,j]);
                    }    
                }
            }
        }
    }
}
