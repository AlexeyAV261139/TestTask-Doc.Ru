using Tasks.Tasks;

namespace TaskTests;

public class Task1Tests
{
    private readonly Task1 _task1 = new();

    [Theory]
    [InlineData(16, 7)]
    [InlineData(15, 6)]
    [InlineData(999, 9)]
    public void GetOneDigitSumTest(int inputNumber, int expectedResult)
    {
        var sum = _task1.GetOneDigitSum(inputNumber);
        Assert.Equal(sum, expectedResult);
    }
}