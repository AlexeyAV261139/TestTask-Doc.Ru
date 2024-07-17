namespace Tasks.Tasks;

public class Task5
{
    public int ReturnFiveVariantA()
    {
        char[] array =
        [
            'A',
            'B',
            'C',
            'D',
            'E'
        ];
        return array.Length;
    }

    public int ReturnFiveVariantB()
        => typeof(VariantBClass).GetProperties().Count();


    public int ReturnFiveVariantC()
        => (int)EnumVariantC.f;


    public int ReturnFiveVariantD()
    {
        string str = "abcdefgh";
        return str.IndexOf("f");
    }
}

public enum EnumVariantC
{
    a, b, c, d, e, f
}

class VariantBClass
{
    public int FieldA { get; set; }
    public int FieldB { get; set; }
    public int FieldC { get; set; }
    public int FieldD { get; set; }
    public int FieldE { get; set; }
}
