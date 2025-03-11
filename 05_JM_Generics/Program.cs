class SimpleDatabse
{
    private List<float> storedData;
    private List<DateTime> inputDates = new List<DateTime>();
    
    public SimpleDatabse()
    {
        storedData = new List<float>();
    }
    public void AddNewData(float x)
    {
        storedData.Add(x);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (var i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]} yang disimpan pada waktu {inputDates[i]}");
        }
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
    }
}