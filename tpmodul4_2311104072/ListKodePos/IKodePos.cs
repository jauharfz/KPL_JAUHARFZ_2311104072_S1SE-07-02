namespace tpmodul4_2311104072.ListKodePos
{
    // Interface untuk layanan pencarian kode pos (Dependency Inversion)
    public interface IKodePos
    {
        /// <summary>
        /// Mengembalikan kode pos berdasarkan nama kelurahan.
        /// Jika kelurahan tidak ditemukan, mengembalikan null.
        /// </summary>
        /// <param name="kelurahan">Nama kelurahan</param>
        /// <returns>Kode pos sebagai integer atau null jika tidak ditemukan</returns>
        int? GetKodePos(string kelurahan);
    }
}
