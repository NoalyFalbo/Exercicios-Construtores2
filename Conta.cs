using System.Globalization;

namespace exercicioConstrutores2

{
  public class Conta
  {
    public int NumeroConta { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public Conta(int numeroConta, string titular)
    {
      NumeroConta = numeroConta;
      Titular = titular;
      Saldo = 0.0;
    }

    public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
    {
      Saldo = saldo;
    }
    public void Deposito(double quantia)
    {
      Saldo += quantia;
    }
    public void Saque(double quantia)
    {
      Saldo -= quantia + 5.0;
      // ou  Saldo -= 5.0;
    }

    public override string ToString()
    {
      return "Conta: "
      + NumeroConta
      + "\nTitular: "
      + Titular
      + "\nSaldo: R$ "
      + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}