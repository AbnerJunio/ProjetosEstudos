namespace JogoDosDados;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~JOGO DA SORTE~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Jogo da sorte, são 3 dados com números e os premios conforme a pontuação abaixo:  ");
        Console.WriteLine("Se a pontuação do jogador for maior ou igual a 16, ganha um carro novo.");
        Console.WriteLine("Se a pontuação do jogador for maior ou igual a 10, ganha um laptop novo.");
        Console.WriteLine("Se a pontuação do jogador for exatamente 7, ganha uma viagem.");
        Console.WriteLine("Caso contrário, ganhará um gatinho.");

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); 

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);


        roll1 = 1;
        roll2 = 2;
        roll3 = 2;


        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                total += 6;
                Console.WriteLine("Acertou 3 números iguais!  +6 pontos de bônus!");
                Console.WriteLine("Total: " + total);


            }
            else
            {
                total += 2;
                Console.WriteLine("Acertou 3 números iguais!  +2 pontos de bônus!");
                Console.WriteLine("Total: " + total);
            }
        }

        if (total >= 16)
        {
            Console.WriteLine("Você ganhou um carro, Parabéns!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("Você ganhou um laptop, Parabéns!");
        }
        else if (total == 7)
        {
            Console.WriteLine("Você ganhou uma viagem para dois, Parabéns!");
        }
        else
        {
            Console.WriteLine("Você ganhou um gatinho, Parabéns!");
        }

    }
}


//Primeiro código completo com if, else if e else.
