namespace Switch_Case;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Nome do funcionário: ");
        string employeeName = Console.ReadLine().ToUpper();

        string title = "";
        Console.Write("Numero da patente <0 a 600>: ");
        int employeeLevel = int.Parse(Console.ReadLine());
        switch (employeeLevel)
        {
            case >= 400:
                title = "Senior Manager";
                break;
            case >= 300:
                title = "Manager";
                break;
            case >= 200:
                title = "Senior Associate";
                break;
            case >= 100:
                title = "Junior Associate";
                break;
            default:
                title = "Associate";
                break;
        }
        Console.WriteLine($"{employeeName}, {title}");

        Console.WriteLine("\nPrograma para avaliar os componentes de uma SKU de produto.");
        Console.WriteLine("Pressione alguma tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        //Formato do valor SKU : <product #>-<2-letter color code>-<size code>
        string sku = "01-BL-L";
        Console.WriteLine("Product - letter color code - size code: "+sku);

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt"; break;
            case "02":
                type = "T-Shirt"; break;
            case "03":
                type = "Sweat pants"; break;
            default:
                type = "Other"; break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black"; break;
            case "MN":
                color = "Maroon"; break;
            default:
                color = "White"; break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small"; break;
            case "M":
                size = "Medium"; break;
            case "L":
                size = "Large"; break;
            default:
                size = "One Size Fits All"; break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");
    }
}
