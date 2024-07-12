using System.Text;

namespace Tasks;

public class Program
{
    private static Task5 task5 = new();
    static void Main(string[] args)
    {
        var pyr = new Pyramid(40);
        pyr.PrintOnConsole();
        Console.WriteLine(pyr.GetRowSum(3));
        Console.ReadKey();

    }
}

public class Task4
{

}

public class Pyramid
{
    private List<int[]> _rows;

    public Pyramid(int countRows = 100)
    {
        CreateRows(countRows);
    }

    public int GetRowSum(int rowIndex)
        => _rows[rowIndex].Sum();

    private void CreateRows(int countRows)
    {
        _rows = new List<int[]>();
        for (int elementIndex = 0; elementIndex < countRows; elementIndex++)
        {
            var row = GetRandomValueArray(elementIndex);
            _rows.Add(row);
        }
    }

    private int[] GetRandomValueArray(int arrayLength)
    {
        Random rnd = new Random();
        var row = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            row[i] = rnd.Next(99);
        }
        return row;
    }


    public void PrintOnConsole()
    {
        foreach (var row in _rows)
        {
            foreach (var el in row)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void UpdateRow(int rowIndex, ICollection<int> values)
    {
        _rows[rowIndex] = values.ToArray();
    }
}