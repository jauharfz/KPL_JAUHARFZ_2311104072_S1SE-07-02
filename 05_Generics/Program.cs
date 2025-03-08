public class DataGeneric
{
    {
        Console.WriteLine($"Halo user {username}");
=========
﻿public class DataGeneric
{
   public void SapaUser(string username)
    {
        Console.WriteLine($"Halo user {username}");
    }
    private readonly string data;
    public DataGeneric(string _data)
    {
    }
    public void PrintData()
    {
        Console.WriteLine($"Daya yang disimpan adalah: {data}");
>>>>>>>>> Temporary merge branch 2
        Console.ReadKey();
        Console.ReadKey();
        Console.ReadKey();
        Console.ReadKey();
    }
    
class Program
{
    public static void Main(string[] args)
    {
        string userInput = Console.ReadLine();
        DataGeneric testing = new DataGeneric(userInput);
        testing.SapaUser("Almighty Jauhar Fajar Zuhair");
        testing.PrintData();
    }
}