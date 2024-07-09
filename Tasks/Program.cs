namespace Tasks;

public class Program
{
    private static Task1 task1 = new();
    static void Main(string[] args)
    {
        while (true)
        {
            var inputNumber = int.Parse(Console.ReadLine() ?? "");
            int sum = task1.GetOneDigitSum(inputNumber);
        }
    }
}

public class Task1
{
    public int GetOneDigitSum(int number)
    {
        int sum = SumOfTheDigitsInTheNumber(number);
        Console.WriteLine(sum);

        return (sum / 10 == 0)
            ? sum
            : GetOneDigitSum(sum);
    }

    public int SumOfTheDigitsInTheNumber(int number)
        => number == 0
        ? 0
        : number % 10 + SumOfTheDigitsInTheNumber(number / 10);
}
