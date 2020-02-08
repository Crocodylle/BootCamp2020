using System;
using System.Globalization;


namespace ExerciciosProgramacaoOrientadaObjetosExericios2 {
    class Funcionario {
        public string nome;
        public double SalarioBruto;
        public double imposto;
      

        public double SalarioLiquido() {
            return SalarioBruto - imposto; 
        }
        public double AumentarSalario(double porcentagem) {
            return SalarioBruto += SalarioBruto * (porcentagem / 100);
                
        }

        public override string ToString() {
            return + nome
                   + " , $ "
                   + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
