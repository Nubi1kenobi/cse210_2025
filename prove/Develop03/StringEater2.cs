using System;
public class StringEater2
{
    private string _eatenString;
    private int _digestiveDelay;
    
    public StringEater2(string eatenString)
    {
        _eatenString = eatenString;
        _digestiveDelay = 25;
        DisplayRandomColoredChar();
    }  
    private static ConsoleColor GetRandomColor()
    {
        Random randomColor = new Random();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomColor.Next(consoleColors.Length));
    }
    public void DisplayVertical()
    {
        List<char> digestedString = _eatenString.ToList();
        foreach (char c in digestedString)
        {
            Console.WriteLine(c);
        }
    }
    public void DisplayRandomColoredChar()
    {
        List<char> digestedString = _eatenString.ToList();
        foreach (Char c in digestedString)
        {
            Console.ForegroundColor = GetRandomColor();    
            Thread.Sleep(_digestiveDelay);
            Console.Write(c);
        }
    }
}