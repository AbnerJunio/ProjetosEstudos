namespace Projeto_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        
        string[] myStringss = new string[4] { "I like pizza", "I like roast chicken", "I like salad", "I like all three of the menu choices" };
        int periodLocation;

        foreach (string myString in myStringss)
        {
            Console.WriteLine(myString);
        }

    }
}
