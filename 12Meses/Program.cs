using System;

namespace _12Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 12:");
            int opção = int.Parse(Console.ReadLine());

            if( opção < 13)
            {
                switch(opção)
                {
                    case 1:
                    System.Console.WriteLine("Janeiro");
                    break;

                    case 2:
                    System.Console.WriteLine("Fevereiro");
                    break;

                    case 3:
                    System.Console.WriteLine("Março");
                    break;

                    case 4:
                    System.Console.WriteLine("Abril");
                    break;

                    case 5:
                    System.Console.WriteLine("Maio");
                    break;

                    case 6:
                    System.Console.WriteLine("Junho");
                    break;

                    case 7:
                    System.Console.WriteLine("Julho");
                    break;

                    case 8:
                    System.Console.WriteLine("Agosto");
                    break;

                    case 9:
                    System.Console.WriteLine("Setembro");
                    break;

                    case 10:
                    System.Console.WriteLine("Outubro");
                    break;

                    case 11:
                    System.Console.WriteLine("Novembro");
                    break;

                    case 12:
                    System.Console.WriteLine("Dezembro");
                    break;
                    } 
            
            }else
            {
                System.Console.WriteLine("Este mês não existe.");
            }
        }
    }
}


