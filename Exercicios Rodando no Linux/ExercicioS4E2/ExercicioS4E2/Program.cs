using System;
using System.Globalization;

namespace ExercicioS4E2
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento;
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(f);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);
            Console.WriteLine("Dados Atualizados: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
