using System;

namespace Numeros_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro número: ");
            double numero3 = double.Parse(Console.ReadLine());

            if(numero1 == numero2 && numero1 == numero2 && numero2 == numero3)
            {
                System.Console.WriteLine("Isso é um triângulo! ");
            }else 
            {
                System.Console.WriteLine("Isso não é um triângullo! ");
            }
        }
    }
}
