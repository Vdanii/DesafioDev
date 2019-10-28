using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string Nome = (Console.ReadLine());

            Console.WriteLine("Digite o peso: ");
            double Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altuira: ");
            double Altura = double.Parse(Console.ReadLine());

            double imc = Peso/(Altura*Altura);

            if(imc < 20)
            {
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Abaixo do peso");
            }else if (imc < 25)
            {
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Normal ");
            }else if (imc < 30)
            {
                System.Console.WriteLine($"Paciente{Nome}");
                System.Console.WriteLine("Excesso de peso");
            }else if (imc < 35)
            {
                System.Console.WriteLine($"Paiente {Nome}");
                System.Console.WriteLine("Obesidade");
            }else if (imc > 35)
            {
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Obesidade mórbida");
            }
        }
    }
}
