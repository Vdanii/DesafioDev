using System;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            double Distancia;
            double Resultado;

            System.Console.WriteLine("Digite o tempo: ");
            double Tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade: ");
            double velocidade = double.Parse(Console.ReadLine());
            Distancia = Tempo * velocidade;
            Resultado = Distancia / 12;
            System.Console.WriteLine("A quantidade gasta de litros em combustivel é " + Resultado);
        }
    }
}
