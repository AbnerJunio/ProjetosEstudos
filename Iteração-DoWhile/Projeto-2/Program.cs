namespace Projeto_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Informe a função: Administrador, Gerente ou Usuário ");
        string função;

        do
        {
            função = Console.ReadLine().ToLower().Trim();
            if (função != "administrador" && função != "gerente" && função != "usuario") Console.WriteLine("O valor inserido \"" + função + "\" é inválido, tente novamente");
        } while (função != "administrador" && função != "gerente" && função != "usuario");

        Console.WriteLine("o valor de entrada \"" + função + "\" foi aceito.");
    }
}
