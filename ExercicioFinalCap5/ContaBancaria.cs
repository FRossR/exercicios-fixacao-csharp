using System.Globalization;

namespace ExercicioFinalCap5
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double saldoConta) : this(numeroConta, titular)
        {
            SaldoConta = saldoConta;
        }

        public void Deposito(double quantia)
        {
            SaldoConta = SaldoConta + quantia;
        }

        public void Saque(double quantia)
        {
            SaldoConta = SaldoConta - (quantia + 5.0);
        }

        public override string ToString()
        {
            return "Conta "
            + NumeroConta
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
