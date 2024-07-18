using ProgrammingTasks.Tasks;

namespace ProgrammingTasksTests.Tests;

public class Task2Tests
{
    private static readonly Task2 _task2 = new();

    public static IEnumerable<object[]> CentsInFloatTestData
       => new[]
       {
           new object[]
           {

               101.1678f,
               new Dictionary<Nominals, int>()
               {
                   {Nominals.Pennies, 1},
                   {Nominals.Nickels, 0 },
                   {Nominals.Dimes, 0 },
                   {Nominals.Quarters, 4 },
               }
           },
           new object[]
           {
               90.5f,
               new Dictionary<Nominals, int>()
               {
                   {Nominals.Pennies, 0},
                   {Nominals.Nickels, 1 },
                   {Nominals.Dimes, 1 },
                   {Nominals.Quarters, 3 },
               }
           },
           new object[]
           {
               19.9f,
               new Dictionary<Nominals, int>()
               {
                   {Nominals.Pennies, 4},
                   {Nominals.Nickels, 1 },
                   {Nominals.Dimes, 1 },
                   {Nominals.Quarters, 0 },
               }
           }
       };

    private Dictionary<Nominals, int> EmptyDictionary
        => new()
            {
                {Nominals.Pennies, 0},
                {Nominals.Nickels, 0 },
                {Nominals.Dimes, 0 },
                {Nominals.Quarters, 0 },
            };

    [Theory]
    [MemberData(nameof(CentsInFloatTestData))]
    public void CentsInFloatTest(float cents, Dictionary<Nominals, int> expectedCoins)
    {
        var coins = _task2.GetCoins(cents);

        Assert.True(CheckTheEqualityNominalDictionaries(expectedCoins, coins));
    }

    [Theory]
    [InlineData(-20)]
    [InlineData(0)]
    public void IncorrectCentsValueTest(int cents)
    {
        var coins = _task2.GetCoins(cents);
        Assert.True(CheckTheEqualityNominalDictionaries(EmptyDictionary, coins));
    }

    private bool CheckTheEqualityNominalDictionaries(
        Dictionary<Nominals, int> dict1,
        Dictionary<Nominals, int> dict2)
            => dict1.Count() == dict2.Count
            && !dict1.Except(dict2).Any();
}
