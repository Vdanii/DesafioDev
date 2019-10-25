using System;

namespace Asteristico
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt = 0;
            string ast = "*";

            System.Console.WriteLine("Escolha a altura do seu triângulo: ");
            alt = int.Parse(Console.ReadLine());
                for(int i = alt; i != 0; i--)
                {
                    for(int k = 0; k <=i;k++)
                    {
                        System.Console.Write(ast);
                    }
                    System.Console.WriteLine("");
                }
        }
    }
}