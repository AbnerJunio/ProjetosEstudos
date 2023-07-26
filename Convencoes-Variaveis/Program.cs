namespace Convencoes_Variaveis;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");


        //Mude a frase e veja o que aconteçe...

        string message = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(message);
        Console.WriteLine("Is there a dog in the sentence above?");
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }


        //o método string.Contains() é avaliar se uma cadeia de caracteres contém outra.


        /*
        ==, o operador "igual" para testar a igualdade
        >, o operador "maior que", para testar se o valor à esquerda é maior que o valor à direita
        <, o operador "menor que", para testar se o valor à esquerda é menor que o valor à direita
        >=, o operador "maior ou igual a"
        <=, o operador "menor ou igual a"
        */

        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("Concatenação de palavras.");

        // Example 1:
        Console
        .
        WriteLine
        (
        "Hello Example 1!"
        )
        ;

        // Example 2:
        string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");


    }
}
