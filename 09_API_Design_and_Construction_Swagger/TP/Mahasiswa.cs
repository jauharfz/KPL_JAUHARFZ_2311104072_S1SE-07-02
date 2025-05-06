namespace tpmodul9_2311104072
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string name, string nim)
        {
            Name = name;
            Nim = nim;
        }
    }
}