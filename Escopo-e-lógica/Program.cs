using System;

namespace Escopo_e_lógica;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        bool found = false;
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
            if (number == 42)
            {
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine("Set contains 42");
        }
        Console.WriteLine($"Total: {total}");
    }
}

