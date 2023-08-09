namespace Loop_DoWhile;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("Um herói e um monstro começam com a mesma pontuação, de forma aleatória eles perdem pontos, quem cehgar a 0 primeiro perde.\n");        
        Random aleatorio = new Random();
        int vidaheroi = 10;
        int dano = 0;
        int vidamonstro = 10;

        do
        {
            dano = aleatorio.Next(1, 11);
            vidamonstro = vidamonstro - dano;
            Console.WriteLine("Dano ao Monstro: " + dano + " pontos, vida restante: " + vidamonstro);
            if (vidamonstro < 1)
            {
                Console.WriteLine("Mostro morreu, Vitória do herói!");
                break;
            }

            dano = aleatorio.Next(1, 11);
            vidaheroi = vidaheroi - dano;
            Console.WriteLine("Dano ao herói:   " + dano + " pontos, vida restante: " + vidaheroi);
            if (vidaheroi < 1)
            {
                Console.Write("Herói morreu - Vitória do monstro!");
                break;
            }
            Thread.Sleep(1000);

        } while (vidaheroi > 0);

    }

}
