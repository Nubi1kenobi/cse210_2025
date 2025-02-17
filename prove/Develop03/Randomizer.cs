using System;

class Randomizer 
{
    static public int RandomInt(int limit)
    {
        int _randomNumber;
        int _limit = limit;
        Random _randoCommando = new Random();
        _randomNumber = _randoCommando.Next(1,_limit);
        return _randomNumber;
    }
    public static ConsoleColor RandomConsoleColor()
    {
        Random randomColor = new Random();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomColor.Next(consoleColors.Length));
    }
    
}