using System;
using System.Globalization;

namespace ExercicioFinalCap5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Digite o número da sua conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {
                contaBancaria = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantiaDeposito);
            Console.Write("Dados atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantiaSaque);
            Console.Write("Dados atualizados: ");
            Console.WriteLine(contaBancaria);



        }
    }
}
