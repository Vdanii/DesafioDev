﻿using System;

namespace ABCnomes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreva o primeiro nome: ");
            string Nome = (Console.ReadLine());
            System.Console.WriteLine("Escreva o segundo nome: ");
            string Nome2 = (Console.ReadLine());
            int Compare = string.Compare (Nome,Nome2);
            
            if (Compare < 0)
            {
            System.Console.WriteLine($"primeiro {Nome} segundo {Nome2}");
            
            }else 
            {
            
            System.Console.WriteLine($"primeiro {Nome2} segundo {Nome}");
            }
        }
    }
}
