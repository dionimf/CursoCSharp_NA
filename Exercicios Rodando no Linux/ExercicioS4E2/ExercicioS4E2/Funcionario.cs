using System;
using System.Globalization;

namespace ExercicioS4E2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {


            return SalarioBruto-Imposto;
        }
        public void AumentarSalario(double aumento)
        {
            SalarioBruto += (SalarioBruto * aumento) / 100;
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
