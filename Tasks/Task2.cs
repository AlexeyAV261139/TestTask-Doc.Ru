namespace Tasks;

public class Task2
{
    public Dictionary<Nominals, int> GetCoins(float cents)    
        => GetCoins((int)cents);

    public Dictionary<Nominals, int> GetCoins(int cents)
    {
        var coins = new Dictionary<Nominals, int>();
        
        var nominals = Enum.GetValues(typeof(Nominals))
            .Cast<Nominals>()
            .Reverse();

        foreach(var nominal in nominals)
        {
            coins.Add(nominal, 0);
            while(cents - (int)nominal >= 0)
            {
                cents -= (int)nominal;
                coins[nominal]++;
            }            
        }
        return coins;        
    }
}

public enum Nominals
{
    Pennies = 1,
    Nickels = 5,
    Dimes = 10,
    Quarters = 25
}
