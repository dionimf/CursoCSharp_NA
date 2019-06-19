using System;
using System.Globalization;

namespace ExercicioS4E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            double area;
            double perimetro;
            double diagonal;
            Console.WriteLine("Entre com a largura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = r.Area();
            perimetro = r.Perimetro();
            diagonal = r.Diagonal();
            Console.WriteLine("Area: " + area.ToString("F2",CultureInfo.InvariantCulture) + "\nPerimetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture) + "\nDiagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
