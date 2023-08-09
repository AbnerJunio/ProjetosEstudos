namespace Projeto_3;

class Program
{
    static void Main(string[] args)
    {
        string[] myStringss = new string[4] { "I like pizza", "I like roast chicken", "I like salad", "I like all three of the menu choices" };
        int periodLocation;

        foreach (string myString in myStringss)
        {
            Console.WriteLine(myString);
        }

    }
}
