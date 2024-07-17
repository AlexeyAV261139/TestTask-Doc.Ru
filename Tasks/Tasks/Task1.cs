namespace ProgrammingTasks.Tasks;

public class Task1
{
    public int GetOneDigitSum(int number)
    {
        int sum = SumOfTheDigitsInTheNumber(number);
        Console.WriteLine(sum);

        return sum / 10 == 0
            ? sum
            : GetOneDigitSum(sum);
    }

    private int SumOfTheDigitsInTheNumber(int number)
        => number == 0
        ? 0
        : number % 10 + SumOfTheDigitsInTheNumber(number / 10);
}