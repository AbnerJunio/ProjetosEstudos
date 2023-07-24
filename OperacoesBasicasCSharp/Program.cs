namespace OperacoesBasicasCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int soma = 7 + 5;
        int subtracao = 7 - 5;
        int multiplicacao = 7 * 5;
        decimal divisao = 7.0m / 5.6m;

        Console.WriteLine("A soma é: " + soma);
        Console.WriteLine("A subrtração é: " + subtracao);
        Console.WriteLine("A multiplicação é: " + multiplicacao);
        Console.WriteLine("A divisão é: " + divisao);

        //Variável decimal para armazenar valores com casas depois do  " . " e inserir " m " depois dos numeros.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int primeiro = 10;
        int segundo = 2;

        decimal calculo = (decimal)primeiro / (decimal)segundo;
        Console.WriteLine("O resultado é: " + calculo);

        //Inserir (decimal) em frente a uma varialvel para converter ela.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine($"Modulus of 200/5 : {200 % 5}");
        Console.WriteLine($"Modulos of 7/5 : {7 % 5}");

        //Use o operador % para capturar o resto após a divisão (Ira pegar o resto da divisão).

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int valor11 = 3 + 4 * 5;
        int valor22 = (3 + 4) * 5;
        Console.WriteLine(valor11);
        Console.WriteLine(valor22);

        //O resultado sai diferente!.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int valor0 = 0;

        valor0 = valor0 + 5;

        valor0 += 5;

        valor0++;
        valor0++;
        valor0++;
        valor0++;

        Console.WriteLine(valor0);

        //utilizar ++ para somar mais um numero na variável. 
        //utilizar += para acrescentar mais o numero na frente do = na variável.
        //Essas mesmas tecnicas podem ser utilizadas para ( += / *= / -= ) e ( ++ / -- ).

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int valor1 = 1;

        valor1 = valor1 + 1;
        Console.WriteLine("Primeiro incremento: " + valor1);

        valor1 += 1;
        Console.WriteLine("Segundo incremento: " + valor1);

        valor1++;
        Console.WriteLine("Terceiro incremento: " + valor1);

        //Agora o decremento (-)

        valor1 = valor1 - 1;
        Console.WriteLine("Primeiro decremento: " + valor1);

        valor1 -= 1;
        Console.WriteLine("Segundo decremento: " + valor1);

        valor1--;
        Console.WriteLine("Terceiro decremento: " + valor1);

        valor1--;
        Console.WriteLine("Quarto decremento: " + valor1);

        valor1--;
        Console.WriteLine("Quinto decremento: " + valor1);


        //Decremento chega a valores negativo.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int valor2 = 1;

        valor2++;

        Console.WriteLine("Primeiro: " + valor2);
        Console.WriteLine("Segundo: " + valor2++);
        Console.WriteLine("Terceiro: " + valor2);
        Console.WriteLine("Terceiro: " + ++valor2);

        //Pode-se utilizar o ++ antes ou depois do valor, se for depois ele vai para proxima linha, conforme o exemplo acima.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int fahrenheit = 94;

        fahrenheit = fahrenheit - 32;

        decimal result = fahrenheit * (decimal)5 / 9m;

        Console.WriteLine("A temperatura é: " + result + " Celsius");

        //ou

        int fahrenheit1 = 94;

        decimal result1 = (fahrenheit1 - 32) * (decimal)5 / 9m;

        Console.WriteLine("A temperatura é: " + result1 + " Celsius");

        //Prova final de operações basicas, conversão de fahrenheit para Celsius.

        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para sair\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    }
}
