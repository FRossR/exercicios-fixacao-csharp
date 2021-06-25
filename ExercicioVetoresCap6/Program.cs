using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListaCap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Empregado número #{i}");

                Console.Write("ID do Empregado: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome do Empregado: ");
                string nome = Console.ReadLine();

                Console.Write("Salário do Empregado: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee(id, nome, salario));

            }

            Console.Write("Entre com o ID do empregado que deseja aumentar o salário : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.IDFuncionario == searchId);

            if (emp != null)
            {
                Console.Write("Entre a porcentagem: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcent);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Funcionário não cadastrado! ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
