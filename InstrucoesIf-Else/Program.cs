namespace InstrucoesIf_Else;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Os dias são gerados aleatórios");
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Random aleatorio = new Random();
        Random aleatorio2 = new Random();

        int diasateexpirar = aleatorio.Next(12);
        int porcentagemdesconto = aleatorio2.Next(25);



        if (diasateexpirar <= 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }

        else if (diasateexpirar == 1)
        {
            Console.WriteLine("Your subscription expires in " + diasateexpirar + " days.");
            Console.WriteLine("Renew now and save 20%!");
        }

        else if (diasateexpirar <= 5)
        {
            Console.WriteLine("Your subscription expires in " + diasateexpirar + " days.");
            Console.WriteLine("Renew now and save 10%!");
        }

        else if (diasateexpirar <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        else
        {
            Console.WriteLine();
        }



        if (porcentagemdesconto > 0)
        {
            Console.WriteLine("Você recebeu: " + porcentagemdesconto + "% de desconto.");
        }

        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    }
}

//Os if devem ter uma ordem, para que o programa faça uma leiuta de cima para baixo, caso contrário ele vai entrar no primero if que parecer compatível.

