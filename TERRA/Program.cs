using System;

namespace TERRA
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double Resultado;

            System.Console.WriteLine("Escolha uma opção: ");
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            opcao = Console.ReadLine();

            System.Console.WriteLine("Escreva o seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            switch(opcao)
            {
                case "1":
                Resultado = peso * 0.37;
                System.Console.WriteLine("O seu peso em Mercúrio é: "+ Resultado);
                break;
                
                case "2":
                Resultado = peso * 0.88;
                System.Console.WriteLine("O seu peso em Vênus é: " + Resultado);
                break;
                
                case "3":
                Resultado = peso * 0.38;
                System.Console.WriteLine("O seu peso em Marte é: " + Resultado);
                break;
                
                case "4":
                Resultado = peso * 2.64;
                System.Console.WriteLine("O seu peso em Júpter é: " + Resultado);
                break;
                
                case "5":
                Resultado = peso * 1.15;
                System.Console.WriteLine("O seu peso em Saturno é: " + Resultado);
                break;
                
                case "6":
                Resultado = peso * 1.17;
                System.Console.WriteLine("O seu peso em Urano é: " + Resultado);
                break;
            }     
        }
    }
}
