using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1;
            Funcionario f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Informe o nome do primeiro Funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o nome do segundo Funcionario: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("O salário medio é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.Read();
        }
    }
}
