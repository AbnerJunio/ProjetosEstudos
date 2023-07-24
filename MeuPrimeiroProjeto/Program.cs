namespace MeuPrimeiroProjeto;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        var nome = ("bob");
        var numero = ("3");
        var nFracionado = ("34.4");

        Console.Write("Helo, ");
        Console.Write(nome);
        Console.Write("! You have ");
        Console.Write(numero);
        Console.Write(" in your inbox. The temperature is ");
        Console.Write(nFracionado);
        Console.WriteLine(" celsius.");

        Console.WriteLine("Pressione alguma tecla para sair");
        Console.ReadKey();

    }
}
