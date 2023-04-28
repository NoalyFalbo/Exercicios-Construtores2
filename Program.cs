using System;
using System.Globalization;

namespace exercicioConstrutores2
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Conta DadosConta;

      Console.WriteLine("Digite o número da conta: ");
      int numeroConta = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o nome do titular da conta: ");
      string titular = Console.ReadLine();
      Console.WriteLine("Haverá depósito inicial: ");
      char resp = char.Parse(Console.ReadLine());
      if (resp == 's')
      {
        Console.WriteLine("Digite o valor do depósito: ");
        double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        DadosConta = new Conta(numeroConta, titular, depositoInicial);
      }
      else
      {
        DadosConta = new Conta(numeroConta, titular);
      }
      Console.WriteLine();
      Console.WriteLine("Dados da conta: ");
      Console.WriteLine(DadosConta);

      Console.WriteLine();
      Console.WriteLine("Digite um valor para depósito: ");
      double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      DadosConta.Deposito(deposito);
      Console.WriteLine("Dados da conta atualizado: ");
      Console.WriteLine(DadosConta);

      Console.WriteLine();
      Console.WriteLine("Digite um valor para saque: ");
      double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      DadosConta.Saque(deposito);
      Console.WriteLine("Dados da conta atualizado: ");
      Console.WriteLine(DadosConta);
    }
  }
}