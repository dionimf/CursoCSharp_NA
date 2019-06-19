using System;
using System.Globalization;

namespace ExercicioS4E1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            
            //raiz de largura ao quadrado + altura ao quadrado
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }


    }

}
