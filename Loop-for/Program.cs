namespace Loop_for;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("Desafio FizzBuzz");
        for (int i = 0; i < 101; i++)
        {
            int divisorTres = (i % 3);
            int divisorCinco = (i % 5);

            Console.Write(i);

            if (divisorTres == 0 && divisorCinco == 0)
                Console.Write(" - FizzBuzz");
            else if (divisorTres == 0)
                Console.Write(" - Fizz");
            else if (divisorCinco == 0)
                Console.Write(" - Buzz");

            Console.WriteLine();
            Thread.Sleep(100);
        }

    }
}
