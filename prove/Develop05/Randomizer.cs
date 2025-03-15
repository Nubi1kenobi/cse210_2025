using System;

class Randomizer 
{
    static public int RandomInt(int parameter)
    {
        int _randomNumber;
        int _limit = parameter;
        Random _randoCommando = new Random();
        if (_randoCommando is not null) {_randomNumber = 0;}
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