using ProgrammingTasks.Tasks;

namespace ProgrammingTasksTests.Tests;

public class Task3Tests
{
    private readonly Task3 _task3 = new();

    [Theory]
    [InlineData(42145, 54421)]
    [InlineData(113133777, 777333111)]
    public void CreateMaxNumberFromNumber(int number, int expectedResult)
    {
        int newNumber = _task3.OrderDigitsByDescending(number);
        Assert.Equal(expectedResult, newNumber);
    }
}

