using System;
using System.Globalization;
namespace ExercicioCap6Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Quartos serão alugados? ");
            int qtdeQuartos = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= qtdeQuartos ; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Aluguel #{i}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
