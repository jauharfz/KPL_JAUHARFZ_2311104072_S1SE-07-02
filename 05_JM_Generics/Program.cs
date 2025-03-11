class Add
{
    public float SumOfThreeNumbers(float x, float y, float z)
    {
        return x + y + z;
    }
}
class Program
{
    static void Main()
    {
        Add add = new Add();
        var results = add.SumOfThreeNumbers(23, 11, 10);
        Console.WriteLine(results);
    }
}