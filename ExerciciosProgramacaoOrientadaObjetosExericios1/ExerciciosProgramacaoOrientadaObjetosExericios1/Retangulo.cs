using System;

namespace ExerciciosProgramacaoOrientadaObjetosExericios1 {
    class Retangulo {
        public double Largura;
        public double Altura; 

        public double Area() {
               return Largura * Altura; 
        }
        public double Perimetro() {

            return  (Altura + Largura) * 2; 
         
        }        
        public double Diagonal() {
            double diagonal = Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
            return diagonal; 
        }
    }
}
