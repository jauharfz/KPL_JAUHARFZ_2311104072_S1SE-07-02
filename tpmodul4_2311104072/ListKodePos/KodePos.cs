namespace tpmodul4_2311104072.ListKodePos
{
    // Kelas KodePos: bertanggung jawab untuk lookup kode pos (Single Responsibility)
    public class KodePos : IKodePos
    {
        // Tabel kelurahan dan kode pos (table-driven approach)
        private readonly Dictionary<string, int> kodePosTable;

        public KodePos()
        {
            // Menggunakan StringComparer.OrdinalIgnoreCase agar lookup tidak case-sensitive
            kodePosTable = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
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

        // Method lookup kode pos menggunakan table-driven approach
        public int? GetKodePos(string kelurahan)
        {
            if (kodePosTable.TryGetValue(kelurahan, out int kodePos))
            {
                return kodePos;
            }
            return null;
        }
    }
}
