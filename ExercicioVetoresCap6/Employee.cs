using System;
using System.Globalization;
using System.Collections.Concurrent;
namespace ExercicioListaCap6
{
    class Employee
    {
        public int IDFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public double SalarioFuncionario { get; private set; }

        public Employee(int idFuncionario, string nomeFuncionario, double salarioFuncionario)
        {
            IDFuncionario = idFuncionario;
            NomeFuncionario = nomeFuncionario;
            SalarioFuncionario = salarioFuncionario;
        }

        public void AumentarSalario(double porcent)
        {
            SalarioFuncionario = SalarioFuncionario + (SalarioFuncionario * porcent / 100);
        }

        public override string ToString()
        {
            return IDFuncionario
                + ", "
                + NomeFuncionario
                + ", "
                + SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
