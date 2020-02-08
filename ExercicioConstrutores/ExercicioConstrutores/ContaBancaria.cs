using System.Globalization;

namespace ExercicioConstrutores {
    class ContaBancaria {

        public int _numero { get; private set; }
        public string _titular { get; set; }
        public double Saldo { get; private set; }
       
        public ContaBancaria(int numero, string titular) : this() {
            _numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            FazerDeposito(depositoInicial); 
        }

        public double FazerSaque (double saldo) {
            return Saldo -= saldo + 5; 
        }

        public double FazerDeposito(double saldo) {
            return Saldo += saldo; 
        }

        public override string ToString() {
         return + _numero
                + ", Titular "
                + _titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
         } 
    }
}


