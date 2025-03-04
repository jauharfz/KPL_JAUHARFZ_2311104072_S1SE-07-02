public class HaloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine($"Halo user {username}");
        Console.ReadKey();
    }
}
class Program
{   public static void Main(string[] args)
    {
        HaloGeneric testing = new HaloGeneric();
        testing.SapaUser("Almighty Jauhar Fajar Zuhair");
    }
}