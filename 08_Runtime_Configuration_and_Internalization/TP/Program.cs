using tpmodul8_2311104072;

var covidConfig = CovidConfig.ReadJSON("covid_config.json");
covidConfig.UbahSatuan();
Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {covidConfig.SatuanSuhu}");
var userInput = Console.ReadLine();
float.TryParse(userInput, out float result);
Console.WriteLine("Berapa hari yang lalu(perkiraan) anda terakhir memiliki gejala demam");
var userInput2 = Console.ReadLine();
int.TryParse(userInput2, out int result2);
int.TryParse(covidConfig.BatasHariDemam, out int batasHariDemam);

if (result2 > batasHariDemam)
{
    Console.WriteLine(covidConfig.PesanDitolak);
    return;
}

if (covidConfig.SatuanSuhu.ToLower() == "celcius")
{
    if (result < 36.5 || result > 37.5)
    {
        Console.WriteLine(covidConfig.PesanDitolak);
        return;
    }

    Console.WriteLine(covidConfig.PesanDiterima);
}
else if (covidConfig.SatuanSuhu.ToLower() == "fahrenheit")
{
    if (result < 97.7 || result > 99.5)
    {
        Console.WriteLine(covidConfig.PesanDitolak);
        return;
    }

    Console.WriteLine(covidConfig.PesanDiterima);
}


Console.ReadKey();