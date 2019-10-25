using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<int> _lista = new List<int>();

            while (i <= 2){
                Console.WriteLine("Digite seu " + (i + 1) + "º numero");
                _lista.Add(int.Parse(Console.ReadLine()));

                i++;
            }
                _lista.Sort();

                Console.WriteLine();
                Console.WriteLine("Os numeros digitados são: ");

                foreach(int termo in _lista)
                {
                    Console.WriteLine(termo);
                }
                Console.ReadKey();
        }
    }
}
