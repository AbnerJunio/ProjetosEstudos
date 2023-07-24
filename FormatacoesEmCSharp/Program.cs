namespace FormatacoesEmCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Hello\nWorld!");
        Console.WriteLine("Hello\tEarth!");
        Console.WriteLine("Hello \"World\"!");
        Console.WriteLine("c:\\source\\repos");
        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        Console.WriteLine(@"c:\invoices\app.exe -j");

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Concatenar frases");
        string segundoNome = "Junio";
        string primeiroNome = "Abner";
        Console.WriteLine(primeiroNome + " " + segundoNome + "!");

        //[Coloca \n linha de baixo]
        //[De um \t para dar um espaço entre as palavras]
        //[Utilizar \ para ignorar "" dentro de outras ""]
        //[Utilizar \\ para caminhos as pastas de computadores
        //O @ dentro (), pertmite colocar mais () dentro da área de digitação. (Ex: Console.WriteLine( @" texto normal (texto dentro do texto) ");)

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine();

        int version = 11;
        string update = "Update to Windows";
        Console.WriteLine($"{update} {version}");

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        string projectName = "ACME";

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine($@"View English output:
c:\Exercise\{projectName}\data.txt");

        Console.WriteLine($@"{russianMessage}: 
c:\Exercise\{projectName}\ru-RU\data.txt");

        //$ para ignorar os caracteres e utilizar as variáveis no codigo utilizando os { } !
        //O símbolo $ permite que você referencie a variável projectName dentro dos colchetes, enquanto o símbolo @ permite que você use o caractere \ sem escape.

        Console.WriteLine("Pressione alguma tecla para sair");
        Console.ReadKey();

    }
}
