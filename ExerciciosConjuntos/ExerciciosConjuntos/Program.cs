using System;
using System.Collections.Generic;
namespace ExerciciosConjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> Curso_A = new HashSet<int>();
            HashSet<int> Curso_B = new HashSet<int>();
            HashSet<int> Curso_C = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos ?");
            int alunos_A = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alunos_A; i++) {

                    Curso_A.Add(int.Parse(Console.ReadLine()));
            }
        
            Console.WriteLine ( " O curso B possui quantos alunos ?" );
            int alunos_B = int.Parse(Console.ReadLine());    

           for (int i = 1; i <= alunos_B; i++) {

               Curso_B.Add(int.Parse(Console.ReadLine()));
            }


            Console.WriteLine(" O curso C possui quantos alunos ?");
            int alunos_C = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alunos_C; i++) {

                Curso_C.Add(int.Parse(Console.ReadLine()));
            }


            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(Curso_A);
            Novo.UnionWith(Curso_B);
            Novo.UnionWith(Curso_C);
            
            Console.WriteLine("Total de alunos: " + Novo.Count );
            Console.ReadLine();
           
        }

        }

    }

