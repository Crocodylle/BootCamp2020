using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMembrosEstaticos {
    class ConversorDeMoeda {

        public static double IOF = 6;  

        public static double valor(double val, double cot) {
            return val * cot + (val * cot)*(IOF/100); 
        }
    }
}
