using System;

namespace AlgoritmosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double altura;
            double Perimetro;
            double area;
            double diagonal;
            double dois = 2;
            Console.WriteLine("Coloque a altura de retângulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a base do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            area = Base*dois + altura*dois;
            Console.WriteLine($"o resultado da área é "+ area);

            Console.WriteLine("Coloque a altura do perimetro: ");
            Base = double.Parse (Console.ReadLine());
            Console.WriteLine("Coloque a base do perimetro: ");
            altura = double.Parse(Console.ReadLine());
            Perimetro = Base* altura;
            Console.WriteLine($" o resultado perimetro é: " + Perimetro);

            Console.WriteLine("Coloque a altura do diametro: ");
            Base = double.Parse (Console.ReadLine());
            Console.WriteLine("Coloque a base do diametro: ");
            altura = double.Parse(Console.ReadLine());

            diagonal = Math.Sqrt((Base * Base) + (altura * altura));
            System.Console.WriteLine($" o resultado diametro é " + diagonal);


        }
    }
}
