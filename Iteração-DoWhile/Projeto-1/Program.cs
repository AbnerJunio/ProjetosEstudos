namespace Projeto_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        int numero = 0;

        do
        {
            Console.Write("Insira um numero inteiro entre 5 e 10: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 10 || numero < 5) Console.WriteLine("Você inseriu um numero errado, tente novamente.");
        } while (numero < 5 || numero > 10);
        Console.WriteLine("Valor de entrada aceito!");
    }
}
