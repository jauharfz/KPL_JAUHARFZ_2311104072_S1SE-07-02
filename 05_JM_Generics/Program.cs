class SimpleDatabse
{
    private List<float> _storedData;
    private List<DateTime> _inputDates = new List<DateTime>();
    
    public SimpleDatabse()
    {
        _storedData = new List<float>();
    }
    
    public void AddNewData(float x)
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
    public void SumOfThreeNumbers(float x, float y, float z)
    {
        Console.WriteLine($"Hasil penjumlahan dari {x}, {y}, {z} adalah {x+y+z}");
    }
}
class Program
{
    static void Main()
    {
        SimpleDatabse db = new SimpleDatabse();
        db.AddNewData(23);
        db.AddNewData(11);
        db.AddNewData(10);
        db.PrintAllData();
        db.SumOfThreeNumbers(23, 11, 10);
    }
}
