namespace OperadoresLogicos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int firstValue = 500;
        int secondValue = 600;
        int largerValue;

        largerValue = (Math.Max(firstValue, secondValue));
        Console.WriteLine(largerValue);

        //Utilizando a classe Math seguido do seu método Max (Que seleciona o valor máximo entre dois números).
        //Para pesquisar na biblioteca de .NET usa-se (CLASSE + MÉTODO + C#).

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (total > 14)
        {
            Console.WriteLine("You Win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose!");
        }

        //Início do if
        //Os caracteres de E comercial duplos && são o operador lógico "AND".
        //Os caracteres de pipe duplo || são o operador lógico "OR" (Qualquer uma das opções sendo verdadeiras todo o conjunto será verdadeiro)
        //Use uma instrução if para ramificar sua lógica de código.
        //Um bloco de código é definido por chaves { }.         

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Random dice1 = new Random();

        int roll11 = dice1.Next(1, 7);
        int roll22 = dice1.Next(1, 7);
        int roll33 = dice1.Next(1, 7);

        int total1 = roll11 + roll22 + roll33;

        Console.WriteLine($"Dice roll: {roll11} + {roll22} + {roll33} = {total1}");

        if ((roll1 == roll22) || (roll1 == roll33) || (roll2 == roll33))
        {
            Console.WriteLine("You rolled doubles! +2 bunus to total!");
            total1 += 2;
        }

        if ((roll11 == roll22) && (roll22 == roll33))
        {
            Console.WriteLine("You rolled triples! +6 bonues to total!");
            total1 += 6;
        }

        if (total1 >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total1 < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }

        //Aninhamento nos permite colocar blocos de código dentro de outros blocos de código, bloco de códigos são as {}.
        //Quando quiser que apenas um resultado aconteça, mas tiver várias condições e resultados possíveis em if, use quantas instruções else if precisar.
        //Use instruções else if para criar várias condições exclusivas.
        //O else é opcional, mas deve sempre ficar por último quando utilizado.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para sair\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("teste github");

    }
}