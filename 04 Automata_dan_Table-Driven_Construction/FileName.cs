using System;

namespace tpmodul4_2311104072
{
    public enum GameState
    {
        Menu,
        Bermain,
        GameOver
    }

    public class GameAutomata
    {
        public GameState currentState;

        public void run()
        {
            // Mengatur state awal ke Menu
            currentState = GameState.Menu;

            while (true)
            {
                switch (currentState)
                {
                    case GameState.Menu:
                        Console.WriteLine("Di menu pertama pilih start untuk bermain");
                        Console.WriteLine("Tekan S untuk start, dan Q untuk keluar");
                        var menuChoice = Console.ReadKey(true).Key;
                        if (menuChoice == ConsoleKey.S)
                        {
                            ChangeState(GameState.Bermain);
                        }
                        else if (menuChoice == ConsoleKey.Q)
                        {
                            return;
                        }
                        break;

                    case GameState.Bermain:
                        Console.WriteLine("Bermain... Tekan G untuk Game Over, dan Q untuk keluar");
                        var gameChoice = Console.ReadKey(true).Key;
                        if (gameChoice == ConsoleKey.G)
                        {
                            ChangeState(GameState.GameOver);
                        }
                        else if (gameChoice == ConsoleKey.Q)
                        {
                            return;
                        }
                        break;

                    case GameState.GameOver:
                        Console.WriteLine("Game Over! Tekan R untuk kembali ke menu atau Q untuk keluar");
                        var gameOverChoice = Console.ReadKey(true).Key;
                        if (gameOverChoice == ConsoleKey.R)
                        {
                            ChangeState(GameState.Menu);
                        }
                        else if (gameOverChoice == ConsoleKey.Q)
                        {
                            return;
                        }
                        break;
                }
            }
        }

        // Memperbarui state permainan sesuai dengan parameter yang diberikan
        private void ChangeState(GameState newState)
        {
            currentState = newState;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GameAutomata game = new GameAutomata();
            game.run();
        }
    }
}
