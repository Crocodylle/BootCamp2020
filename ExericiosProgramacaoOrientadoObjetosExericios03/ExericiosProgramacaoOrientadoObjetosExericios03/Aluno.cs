using System;
using System.Collections.Generic;
using System.Text;

namespace ExericiosProgramacaoOrientadoObjetosExericios03 {
    class Aluno {
            public string nome; 
            public double nota1;
            public double nota2;
            public double nota3;
            double Soma = 0;

        public double Somatoria() {
            Soma = (nota1 + nota2 + nota3);
            return Soma;

        }
        public bool Aprovado() {
            
          if (Somatoria() >= 60.00) {
                return true; 
            }
            else { return false;
            } 
            
           } 
        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0; 
            }
            else {
                return 60.00 - Somatoria();
                    }
        } 

        }

        
}
