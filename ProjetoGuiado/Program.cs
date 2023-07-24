namespace ProjetoGuiado;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione alguma tecla para continuar\t");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int divisaoMedia = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        decimal sophiaScore = (decimal)sophiaSum / (decimal)divisaoMedia;
        decimal nicolasScore = (decimal)nicolasSum / (decimal)divisaoMedia;
        decimal zahirahScore = (decimal)zahirahSum / (decimal)divisaoMedia;
        decimal jeongScore = (decimal)jeongSum / (decimal)divisaoMedia;

        Console.WriteLine("Estudante\t\tGrade\n");

        Console.WriteLine("Sophia:\t\t\t" + sophiaScore + "\tA");
        Console.WriteLine("Nicolas:\t\t" + nicolasScore + "\tB");
        Console.WriteLine("Zahirah:\t\t" + zahirahScore + "\tB");
        Console.WriteLine("Jeong:\t\t\t" + jeongScore + " \tA");


        //Tabela de notas de alunos, feita como atividade em um projeto guiado.
        //Classe são a resposábilidade por categorizar a finalidade do código ( Ex: Conolse.WriteLine(""); , o console é uma classe para determinado tipo de projeto). Classe é como se fosse sua utilizade do projeto.
        //método - WriteLine() da classe - Console.
        //Comece digitando o nome da classe. Neste caso, o nome da classe é Console.
        //Adicione o operador de acesso de membro, o símbolo .
        //Adicione o nome do método. Neste caso, o nome do método é WriteLine.
        //Adicione o operador de chamada do método, que é um conjunto de parênteses ().
        //Especifique os argumentos que serão transmitidos ao método,entre os parênteses do operador de invocação de método. 
        //Você especifica o texto que deseja que o método Console.WriteLine() escreva no console (por exemplo, "Hello World!").
        //Para chamar métodos de uma classe na Biblioteca de Classes do .NET, use o formato ClassName.MethodName(), em que o símbolo . É o operador de acesso de membro para acessar um método definido na classe e os símbolos () são os operadores de invocação de método.
        //Estado são os valores armazenados nos métodos.
    }
}
