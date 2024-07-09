namespace Tasks;

public class Program
{
    private static Task2 task2 = new();
    static void Main(string[] args)
    {

        var result = task2.GetMinimalCoinCount(101);
        var nominals = Enum.GetValues(typeof(Nominals))
            .Cast<Nominals>();

        foreach( var nominal in nominals )
        {
            Console.WriteLine($"{nominal} {result[nominal]}");
        }
    }
}
