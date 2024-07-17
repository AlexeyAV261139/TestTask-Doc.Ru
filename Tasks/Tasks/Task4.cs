using System;

namespace Tasks.Tasks;

public class Task4
{
    private readonly Pyramid _pyramid = new();

    public int GetPyramidRowSum(int rowIndex)
        => _pyramid.GetRow(rowIndex).Sum();
}

public class Pyramid
{
    private const int _basePyramidSize = 100;
    private List<int[]> _rows = [];

    public Pyramid(int countRows = _basePyramidSize)
    {
        CreatePyramid(countRows);
    }

    private void CreatePyramid(int countRows)
    {
        for (int rowIndex = 0; rowIndex < countRows; rowIndex++)
        {
            var row = GetRandomValueArray(rowIndex);
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

    public int[] GetRow(int rowIndex)
    {
        if (rowIndex < 1)
            return [];

        if (rowIndex > _rows.Count())
            ExpandPyramidToIndex(rowIndex);

        return _rows[rowIndex - 1];
    }

    private void ExpandPyramidToIndex(int index)
    {
        for (int rowIndex = _rows.Count(); rowIndex < index; rowIndex++)
        {
            var row = GetRandomValueArray(rowIndex);
            _rows.Add(row);
        }
    }

}