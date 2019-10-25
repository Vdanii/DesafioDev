using System;

namespace parOUimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num != 0 )
            {
                if (num % 2 == 0)
                {
                    System.Console.WriteLine("O numero é PAR: ");
                }else 
                {
                    System.Console.WriteLine("O numero é IMPAR: ");
                }
            }while(num != 0);
        }
    }
}
