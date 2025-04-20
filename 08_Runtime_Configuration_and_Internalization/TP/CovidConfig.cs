using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul8_2311104072;

public class CovidConfig
{
    [JsonPropertyName("satuan_suhu")] public string SatuanSuhu { get; set; } = "celcius";
    [JsonPropertyName("batas_hari_demam")] public string BatasHariDemam { get; set; } = "14";

    [JsonPropertyName("pesan_ditolak")]
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";

    [JsonPropertyName("pesan_diterima")]
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk kedalam gedung ini";

    public static CovidConfig ReadJSON(string filePath = "covid_config.json")
    {
        CovidConfig config = new CovidConfig();
        try
        {
            string jsonString = File.ReadAllText(filePath);
            var configFromJson = JsonSerializer.Deserialize<CovidConfig>(jsonString);
            if (configFromJson != null)
            {
                if (configFromJson.SatuanSuhu != "CONFIG1") config.SatuanSuhu = configFromJson.SatuanSuhu;
                if (configFromJson.BatasHariDemam != "CONFIG2") config.BatasHariDemam = configFromJson.BatasHariDemam;
                if (configFromJson.PesanDitolak != "CONFIG3") config.PesanDitolak = configFromJson.PesanDitolak;
                if (configFromJson.PesanDiterima != "CONFIG4") config.PesanDiterima = configFromJson.PesanDiterima;
            }
        }
        catch
        {

        }
        return config;


    }

    public void UbahSatuan()
    {
        if (SatuanSuhu == "celcius")
        {
            SatuanSuhu = "fahrenheit";
        }
        else
        {
            SatuanSuhu = "celcius";
        }
    }


}
