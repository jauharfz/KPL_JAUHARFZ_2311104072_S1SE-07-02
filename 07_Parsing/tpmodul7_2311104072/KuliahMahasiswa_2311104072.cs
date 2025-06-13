using System.Text.Json;

namespace  tpmodul7_2311104072;
public class KuliahMahasiswa_2311104072
{
    public JSONFormat2 ReadJSON(string filename)
    {
        return JsonSerializer.Deserialize<JSONFormat2>(File.ReadAllText(filename));
    }
}

public class JSONFormat2
{
    public List<CodeName> courses { get; set; }
}

public class CodeName
{
    public string code { get; set; }
    public string name { get; set; }
}