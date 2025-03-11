namespace _04_Automata_dan_Table_Driven_Construction;

public class FruitCodes
{
    private Dictionary<string, string> _fruitTable = new Dictionary<string, string>()
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };
    public string GetFruitCode(string fruitName)
    {
        if (_fruitTable.ContainsKey(fruitName))
        {
            return _fruitTable[fruitName];
        }
        else
        {
            return "Mff kode tidak ditemukan";
        }
    }
}