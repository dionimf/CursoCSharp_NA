using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            Console.WriteLine("Informe o primeiro Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade: ");
            p1.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o segundo Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade: ");
            p2.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("O " + p1.Nome + " é o mais velho!!");
            }
            else if (p1.Idade < p2.Idade)
            {
                Console.WriteLine("O " + p2.Nome + " é o mais velho!!");
            }
            else
            {
                Console.WriteLine("O " + p1.Nome + " e o " + p2.Nome + " Possuem a Mesma Idade!!");
            }


            Console.Read();
        }
    }
}