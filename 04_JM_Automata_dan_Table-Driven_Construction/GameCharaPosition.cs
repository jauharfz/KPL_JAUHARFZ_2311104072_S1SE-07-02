namespace _04_Automata_dan_Table_Driven_Construction;
public enum CharaState{
    Berdiri,
    Jongkok,
    Tengkurap,
    Terbang
}
public class GameCharaPosition
{
    public CharaState _currentState;
    public GameCharaPosition()
    {
        _currentState = CharaState.Berdiri;
    }
    public void PressTheSKey()
    {
        Console.WriteLine("Down Direction Key Pressed");
        switch (_currentState)
        {
            case CharaState.Berdiri:
                _currentState = CharaState.Jongkok;
                break;
            case CharaState.Jongkok:
                _currentState = CharaState.Tengkurap;
                break;
            case CharaState.Terbang:
                _currentState = CharaState.Berdiri;
                break;
        };
    }
    public void PressTheWKey()
    {
        Console.WriteLine("Up Direction Key Pressed");
        switch (_currentState)
        {
            case CharaState.Berdiri:
                _currentState = CharaState.Terbang;
                break;
            case CharaState.Jongkok:
                _currentState = CharaState.Berdiri;
                break;
            case CharaState.Tengkurap:
                _currentState = CharaState.Jongkok;
                break;
        }
    }
    public void PressTheXKey()
    {
        Console.WriteLine("X Key Pressed");
        switch (_currentState)
        {
            case CharaState.Terbang:
                _currentState = CharaState.Jongkok;
                break;
        }
    }
    public void ShowState()
    {
        Console.WriteLine($"Current State is {_currentState}");
    }
}