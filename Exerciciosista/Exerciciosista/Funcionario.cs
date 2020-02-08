using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; 

namespace Exerciciosista {
    class Funcionario {
        public int Id;
        public string name;
        public double salary;

        public Funcionario() {

        }

        public Funcionario(string name, double salary) {
            this.name = name;
            this.salary = salary;
        }

      public Funcionario(int id, string name, double salary) {
           Id = id;
            this.name = name;
            this.salary = salary;
        }
    
        public void IncreaseSalary(double perc ) {
           salary += salary*(perc/100) ; 
        }

        public override string ToString() {
            return  "  "
                    + Id 
                    +  "  " 
                    + name
                    +  "   "
                    + salary.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
