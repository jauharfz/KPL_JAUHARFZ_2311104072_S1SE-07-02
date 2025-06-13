namespace tpmodul7_2311104072;
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_2311104072 dataMahasiswa2311104072 = new DataMahasiswa_2311104072();
        var data = dataMahasiswa2311104072.ReadJSON("tp7_1_2311104072.json");

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} " +
                          $"dengan nim {data.nim} " +
                          $"dari fakultas {data.fakultas}");
        
        KuliahMahasiswa_2311104072 kuliahMahasiswa2311104072 = new KuliahMahasiswa_2311104072();
        var data1 = kuliahMahasiswa2311104072.ReadJSON("tp7_2_2311104072.json");
        int index = 1;
        foreach (var course in data1.courses)
        {
            Console.WriteLine($"MK{index} {course.code} {course.name}");
            index++;
        }
    }
}
// namespace jmmodul7_2311104072; // (Asumsi namespace)


