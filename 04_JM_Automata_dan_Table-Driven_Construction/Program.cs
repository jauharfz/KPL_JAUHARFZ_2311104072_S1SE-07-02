using _04_Automata_dan_Table_Driven_Construction;
class Program
{
    static void Main()
    {
        GameCharaPosition gameCharaPosition = new GameCharaPosition();
        gameCharaPosition.ShowState();

        while (true)
        {
            var exit = "or Input key E for Exit";
            if (gameCharaPosition._currentState == CharaState.Terbang)
            {
                Console.WriteLine($"Input key S/X {exit}");
            }
            else if(gameCharaPosition._currentState == CharaState.Tengkurap)
            {
                Console.WriteLine($"Input key W {exit}");
            }
            else
            {
                Console.WriteLine($"input key S/W {exit}");
            }
            
            var userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Field tidak boleh kosong");
                continue;
            }else if (userInput.Equals("E", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("terimakasih dan sampai jumpa");
                break;
            }
            else if (userInput.Equals("S", StringComparison.OrdinalIgnoreCase) && gameCharaPosition._currentState != CharaState.Tengkurap)
            {
                gameCharaPosition.PressTheSKey();
                gameCharaPosition.ShowState();
            }else if (userInput.Equals("W", StringComparison.OrdinalIgnoreCase) &&
                      gameCharaPosition._currentState != CharaState.Terbang)
            {
                gameCharaPosition.PressTheWKey();
                gameCharaPosition.ShowState();
            }else if (userInput.Equals("X", StringComparison.OrdinalIgnoreCase) && gameCharaPosition._currentState == CharaState.Terbang)
            {
                gameCharaPosition.PressTheXKey();
                gameCharaPosition.ShowState();
            }
            else
            {
                Console.WriteLine("Invalid Input, kys");
            }
        }
        Console.ReadKey();
        //this for main fruit
        /*FruitCodes fruitCodes = new FruitCodes();
        Console.WriteLine("Enter fruit name:");
        var userInput = Console.ReadLine();
        Console.WriteLine(fruitCodes.GetFruitCode(userInput));
        Console.ReadKey();*/
    }
}
