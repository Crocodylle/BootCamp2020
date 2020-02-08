using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerciciosista {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("How many employess will registered? ");
            int EmployeeNumber = int.Parse(Console.ReadLine());

            List<Funcionario> List = new List<Funcionario>();
            Funcionario Func = new Funcionario(); 

            for (int n = 1; n <= EmployeeNumber; n++) {

                Console.WriteLine("Employee #" + n, ":");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                List.Add(new Funcionario(Id, name, salary));
            }

            Console.WriteLine("Enter the Employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario Func1 = List.Find(x => x.Id == searchId); 
            if (Func1 == null) 
            {
                Console.WriteLine("This id does not exist!");
            }
            else 
            {
                Console.WriteLine("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine());
                Func1.IncreaseSalary(perc);
            }



            Console.WriteLine("Updated list of employees: ");
            foreach (Funcionario obj in List) {
                Console.WriteLine();
                Console.WriteLine(obj);
            }
        }
    }
}         
