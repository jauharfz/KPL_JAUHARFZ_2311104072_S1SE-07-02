namespace tpmodul4_2311104072.PostalCodeList
{
    public class KodePos : IKodePos
    {
        private readonly Dictionary<string, int> _kodePosTable;

        public KodePos()
        {
            _kodePosTable = new Dictionary<string, int>()
            {
                { "Batununggal", 40266 },
                { "A. Kujangsari", 40287 },
                { "Mengger", 40267 },
                { "Wates", 40256 },
                { "Cijaura", 40287 },
                { "Jatisari", 40286 },
                { "Margasari", 40286 },
                { "Sekejati", 40286 },
                { "Kebonwaru", 40272 },
                { "Maleer", 40274 },
                { "Samoja", 40273 }
            };
        }

        public int GetKodePos(string kelurahan)
        {
            if (string.IsNullOrEmpty(kelurahan))
            {
                throw new ArgumentNullException("TOLONG DIISI DENGAN BENAR!");
            }

            if (!_kodePosTable.TryGetValue(kelurahan, out int kodepos))
            {
                throw new KeyNotFoundException($"mff kelurahan {kelurahan} yang anda maksud tidak ditemukan");
            }

            return kodepos;
        }
    }
}