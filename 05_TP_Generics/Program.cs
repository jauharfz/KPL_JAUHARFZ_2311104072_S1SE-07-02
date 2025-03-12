public class DataGeneric<T>
{
    private readonly T data;
    public DataGeneric(T _data)
    {
        data = _data;
    }
    public void SapaUser(T username)
    {
        Console.WriteLine($"Halo user {username}");
    }
    public void PrintData()
    {
        Console.WriteLine($"Daya yang disimpan adalah: {data}");
        Console.ReadKey();
    }
}
class Program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            var testing = new DataGeneric<string>(userInput);
            testing.SapaUser("Almighty Jauhar Fajar Zuhair");
            testing.PrintData();
        }
    }
