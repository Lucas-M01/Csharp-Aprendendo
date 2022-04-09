using System.Globalization;

namespace ExercicioFConta
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string _nome;
        public double Saldo { get; private set; }

        public Conta(int id, string name)
        {
            NumeroConta = id;
            Nome = name;
        }

        public Conta(int id, string name, double deposito)
        {
            NumeroConta = id;
            Nome = name;
            Saldo = deposito;
        }

        public string Nome
        {
            get { return _nome; }
            set { if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            
            }
        }

        public double Depositar(double deposito)
        {
            return Saldo = Saldo + deposito;
        }

        public double Saque(double saque)
        {
            return Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
