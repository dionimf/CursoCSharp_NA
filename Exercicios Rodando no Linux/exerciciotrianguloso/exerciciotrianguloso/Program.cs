﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace exerciciotrianguloso
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");
            x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p- x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            double areaX = x.Area();
            double areaY = y.Area();
            Console.WriteLine("Área de x: " + areaX.ToString("F4", CultureInfo.InvariantCulture) );
            Console.WriteLine("Área de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if( areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }

            Console.ReadKey();
            ///double xA, xB, xC, yA, yB, yC;

            ///Console.WriteLine("Entre com as medidas do triângulo X");
            ///xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ///xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ///xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ///Console.WriteLine("Entre com as medidas do triângulo Y");
            ///yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ///yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ///yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            ///double p = (xA + xB + xC) / 2.0;
            ///double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            ///p = (yA + yB + yC) / 2.0;
            ///double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            ///Console.WriteLine("Área de x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            ///Console.WriteLine("Área de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            ///if (areaX > areaY)
            ///{
            ///    Console.WriteLine("Maior Área: X");
            ///}
            ///else
            ///{
             ///   Console.WriteLine("Maior Área: Y");
            ///}

            ///Console.ReadKey();
        }
    }
}
