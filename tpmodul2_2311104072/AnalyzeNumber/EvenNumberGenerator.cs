namespace tpmodul2_2311104072.AnalyzeNumber
{
    // Kelas yang bertanggung jawab untuk menghasilkan array bilangan genap
    public class EvenNumberGenerator : IEvenNumberGenerator
    {
        public int[] GenerateEvenNumbers(int start, int count)
        {
            int[] evenNumbers = new int[count];
            int currentEven = start;
            for (int i = 0; i < count; i++)
            {
                evenNumbers[i] = currentEven;
                currentEven += 2;
            }
            return evenNumbers;
        }
    }
}
