using System.Reflection;

namespace TaskTests;

public class Task5Tests
{
    private static Task5 _task5 = new();

    public static IEnumerable<object[]> FunctionsReturnFiveTestData()
    {
        var methods = typeof(Task5).GetMethods(BindingFlags.DeclaredOnly |
                        BindingFlags.Public |
                        BindingFlags.Instance);

        return methods
            .Where(x => x != null)
            .Select(x => new[] {x});
    }

    [Theory]
    [MemberData(nameof(FunctionsReturnFiveTestData))]
    public void FunctionsReturnFive(MethodInfo methodInfo)
    {
        var methodResult = methodInfo.Invoke(_task5, parameters: null);
        int? result = methodResult == null
            ? null
            : (int)methodResult;
        Assert.Equal(5, result);
    }
}
