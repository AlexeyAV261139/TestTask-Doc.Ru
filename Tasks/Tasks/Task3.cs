namespace Tasks.Tasks;

public class Task3
{
    public int OrderDigitsByDescending(int number)
    {
        var digits = GetDigitsListFromNumber(number)
                        .OrderDescending()
                        .ToArray();

        var newNumber = CreateNumberFromDigits(digits);

        return newNumber;
    }

    private IEnumerable<int> GetDigitsListFromNumber(int number)
    {
        while (number > 0)
        {
            var lastDigit = number % 10;
            yield return lastDigit;
            number /= 10;
        }
    }

    private int CreateNumberFromDigits(int[] digits)
    {
        int orderedNumber = 0;

        for (int i = digits.Count(), j = 0; i > 0; i--, j++)
        {
            int modifier = (int)Math.Pow(10, i - 1);

            orderedNumber += digits[j] * modifier;
        }

        return orderedNumber;
    }
}