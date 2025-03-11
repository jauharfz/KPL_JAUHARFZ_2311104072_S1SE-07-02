class Program
{
    static bool isPrimeNumber(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine($"bilangan tersebut habis dibagi {i}");
                Console.WriteLine("dan bukan merupakan bilangan prima");
                return false;
            }
        }

        Console.WriteLine($"{number} merupakan bilangan prima");
        return true;
    }

    static void Main(string[] args)
    {
        // TASK I
        Console.WriteLine("Masukkan nama Anda:");
        string userInput = Console.ReadLine();
        Console.WriteLine($"Selamat Datang, {userInput}");

        // TASK II
        int[] numbers = new int[50];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{i} ##");
            }else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} $$");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        //TASK III
        while (true)
        {
            Console.WriteLine("Masukan bilangan 1 sampai 10000: ");
            var userInput2 = Console.ReadLine();
            int.TryParse(userInput2, out int intUserInput2);
            if (intUserInput2 <= 1 || intUserInput2 >= 10000)
            {
                Console.WriteLine("Input tidak valid");
                continue;
            }
            isPrimeNumber(intUserInput2);
            break;
        }
    }
}