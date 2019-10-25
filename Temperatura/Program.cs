using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado;
            double celsus;
            System.Console.WriteLine("Qual a temperatura em celsus ?:");
            celsus = double.Parse(Console.ReadLine());
            Resultado = celsus * 9/5 + 32;

            System.Console.WriteLine("A temperatura em Fahreinhet é " + Resultado);
        }
    }
}
