using System;
using System.Globalization;

namespace ExercicioS4E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (a.NotaFinal() >= 60)
            {
                Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reprovado");
                
                Console.WriteLine("Faltam " 
                    + (60.00 - a.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)
                    + " Pontos");
            }
        }
    }
}
