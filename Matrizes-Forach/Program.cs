namespace Metrizes_Forach;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

        string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //fraudulentOrderIDs[3] = "D000";


        Console.WriteLine($"First:  {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Trird: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";
        Console.WriteLine();
        Console.WriteLine("Reatribuindo o primeiro valor: " + fraudulentOrderIDs[0]);

        Console.WriteLine("Existem: " + fraudulentOrderIDs.Length + " numeros de elemento na matriz\n");

        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        //O runtime do .NET executa um loop em cada elemento da matriz
        //Foreach processa os elementos da matriz em ordem crescente, ele coleta todos os valores da matriz é armazena em uma variável temporária, o .NET executa um loop em cada varrável e as exibe na tela.
        //Foreach atribui temporariamente o valor do elemento da matriz atual a uma variável.
        //O uso do [] na frente da classe indica que é uma matriz.


        string[] names = { "Rowena", "Robin", "Bao" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //A variável "NAME" ela é temporária, criada para armazenar os valores da matriz.
        //O bloco de código que contém Console.WriteLine(name); será executado uma vez para cada elemento da matriz names

        //Foreach é um loop, e contém um bloco de comandos, dentro das {}
        //A instrução foreach define o valor do elemento atual na matriz como uma variável temporária, que pode ser usada no corpo do bloco de código.
        //Use o operador de incremento ++ para adicionar 1 ao valor atual de uma variável.

        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("Intens no inventário e seu total:\n");

        int[] inventorio = { 200, 450, 700, 175, 250 };

        int soma = 0;

        int bin = 0;

        foreach (int items in inventorio)
        {
            soma += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {soma})");
        }

        Console.WriteLine("Temos " + soma + " no inventório.\n");

        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");


        //Em uma Matriz utilizar o {} para inserir os valores.
        //No Foreach ( String + ValoresUnicosDaMatriz + in + ValoresDaMatriz  )
        //O loop if / Elseif / Else contém os requisitos entre () e não utiliza do ; no final da linha.
        //O metódo StartsWith é utilizado para identificar se a palavra inicia com a letra dentro, Ex:("A").
        //O metódo StartsWith é acompanhado da variável (ValoresUnicosDaMatriz) string.

        string[] idss = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        int linha = 0;

        foreach (string id in idss)
        {

            linha++;

            Console.WriteLine("Linha:" + linha + " | o ID é: " + id);

            if (id.StartsWith("B"))
            {

                Console.WriteLine("O ID: " + id + " começa coma a letra B");

            }


        }
        Console.WriteLine();
        Console.WriteLine("Atividade realizada, identificar todos os valores na matriz que contém a letra B\n");

        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("Atividade gerar valores aleatórios dentro de uma matriz\n");

        //Nomes de variável não podem ser uma palavra-chave do C#. 
        //Os nomes de variável diferenciam maiúsculas de minúsculas, o que significa que string MyValue; e string myValue; são duas variáveis diferentes.

        /*
          The following code creates five random OrderIDs
          to test the fraud detection process.  OrderIDs 
          consist of a letter from A to E, and a three
          digit number. Ex. A123.
        */
        Random aleatorio = new Random();
        string[] ordemIDS = new string[15];

        for (int i = 0; i < ordemIDS.Length; i++)
        {

            int prefixValue = aleatorio.Next(65, 70);

            string prefix = Convert.ToChar(prefixValue).ToString();

            //string suffix = aleatorio.Next(1, 1000).ToString("000");

            ordemIDS[i] = prefix + prefixValue;
        }

        foreach (var orderID in ordemIDS)
        {
            Console.WriteLine(orderID);
        }

        Console.WriteLine();
    }
}


//Pode usar um comentário de várias linhas (/* ... */)DICA MUITO BOA.
/*
utiliza-se o propriedade "VARIAVEL.Length" para saber a quantidade de elementos da matriz em um valor inteiro, para retornar o número de elementos da sua matriz.
Uma matriz é uma variável especial que contém uma sequência de elementos de dados relacionados.
A propriedade Length é uma maneira programática de determinar o número de elementos em uma matriz.
*/
