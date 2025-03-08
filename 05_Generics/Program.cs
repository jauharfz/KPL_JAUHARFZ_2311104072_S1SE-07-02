public class DataGeneric
{
    private readonly string data;
    public DataGeneric(string _data)
    {
        data = _data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Daya yang disimpan adalah: {data}");
        Console.ReadKey();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        string userInput = Console.ReadLine();
        DataGeneric testing = new DataGeneric(userInput);
        testing.PrintData();
    }
}