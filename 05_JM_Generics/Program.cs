using System.Numerics;

class SimpleDatabse<T>
{
    private List<T> _storedData;
    private List<DateTime> _inputDates = new List<DateTime>();
    
    public SimpleDatabse()
    {
        _storedData = new List<T>();
    }
    
    public void AddNewData(T x)
    {
        _storedData.Add(x);
        _inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (var i = 0; i < _storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {_storedData[i]} yang disimpan pada waktu {_inputDates[i]}");
        }
    }
    public void SumOfThreeNumbers<T>(T x, T y, T z) where T: IAdditionOperators<T,T,T>
    {
        Console.WriteLine($"results penjumlahan dari {x}, {y}, {z} adalah {x+y+z}");
    }
}
class Program
{
    static void Main()
    {
        SimpleDatabse<int> db = new SimpleDatabse<int>();
        db.AddNewData(23);
        db.AddNewData(11);
        db.AddNewData(10);
        db.PrintAllData();
        db.SumOfThreeNumbers(23,11,10);
    }
}
