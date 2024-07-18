using ProgrammingTasks.Tasks;

namespace ProgrammingTasksTests.Tests;

public class Task4Tests
{
    private readonly Task4 _task4 = new();

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void IncorrectIndexTest(int index)
    {
        var sum = _task4.GetPyramidRowSum(index);
        Assert.Equal(0, sum);
    }

    [Fact]
    public void GetBigIndexSumTest()
    {
        var sum = _task4.GetPyramidRowSum(10000);
        Assert.True(0 <= sum);
    }
}