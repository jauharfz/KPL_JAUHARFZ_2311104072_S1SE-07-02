namespace tpmodul2_2311104072.AnalyzeLetter
{
    // Kelas yang bertanggung jawab untuk menganalisis huruf
    public class LetterAnalyzer : ILetterAnalyzer
    {
        private readonly char[] vowels = { 'A', 'I', 'U', 'E', 'O' };

        public string AnalyzeLetter(char letter)
        {
            // Pastikan huruf berupa huruf kapital
            letter = char.ToUpper(letter);
            if (Array.Exists(vowels, v => v == letter))
            {
                return $"Huruf {letter} merupakan huruf vokal";
            }
            else
            {
                return $"Huruf {letter} merupakan huruf konsonan";
            }
        }
    }
}
