using System;
using System.Drawing;
using System.Text;
//this is probably my favorite creation this semester. 
//It helps me with random colors for text charactors being displayed instead of using Console.Write()
//This class has been further deveoloped at each project except for this project. 
public class StringEater
{
    private string _eatenString;
    private int _digestiveDelay = 0;
    private bool _randoColorChar = false;
    private bool _hMove = true;
    private bool _vMove = false;
    private int _hMoveUnits = 0;
    private int _vMoveUnits = 0;
    //StringEater constructors...pretty self-explanitory.
    public StringEater(){} 
    public StringEater(string eatenString)
    {
        _eatenString = eatenString;
        _digestiveDelay = 0;
        StandardDisplay();
    } 
    public StringEater(string eatenString, bool randoColorChar)
    {
        _randoColorChar = randoColorChar;
        _eatenString = eatenString;
        _digestiveDelay = 0;
        StandardDisplay();
    } 
    public StringEater(string eatenString, int digestiveDelay, bool randoColorChar)
    {
        _eatenString = eatenString;
        _digestiveDelay = digestiveDelay;
        _randoColorChar = randoColorChar;
        StandardDisplay();
    }  
    //this one below does not work right, neeed to play around with it.
    public StringEater(string eatenString, int digestiveDelay, bool horizontalMovement,int horizontalMoveUnits, bool verticalMovement, int verticalMoveUnits, bool randoColorChar)
    {
        _eatenString = eatenString;
        _digestiveDelay = digestiveDelay;
        _hMove = horizontalMovement;
        _vMove = verticalMovement;
        _hMoveUnits = horizontalMoveUnits;
        _vMoveUnits = verticalMoveUnits;
        _randoColorChar = randoColorChar;
        StandardDisplay();
    }  
    //Vibrance() and Vibrance2() - I am playing with a few things, have not decided which way to go yet.
    public void Vibrance(string chewedUpString, int charDelay, int curserPos)
    {
        Console.CursorVisible = false;
        string _functionInput = chewedUpString;
        bool hasToEnd = false;
        int _lineBuffer = _functionInput.Length;
        while (!hasToEnd)
        {
            foreach (char c in _functionInput) 
                {
                    if (Console.KeyAvailable) {hasToEnd = true; Console.ReadKey(true); break;}
                    StringEater beep = new StringEater(c.ToString(), charDelay, true);
                };
            if (Console.CursorLeft + 1 >= _lineBuffer ) {Console.SetCursorPosition(curserPos, Console.CursorTop);}
            if (hasToEnd) {break;}
        }
        Console.ForegroundColor = ConsoleColor.White;
        foreach (char c in _functionInput) {Console.Write(" ");}
        Console.SetCursorPosition(curserPos, Console.CursorTop);
    }
    public void Vibrance2(string chewedUpString, int charDelay, int curserPos)
    {
        Console.CursorVisible = false;
        string _functionInput = chewedUpString;
        bool hasToEnd = false;
        int lineBuffer = _functionInput.Length;
        (int left, int top) = Console.GetCursorPosition();      
        while (!hasToEnd)
        {
            Console.SetCursorPosition(left - 5, top);
            foreach (char c in _functionInput) 
                {
                    if (Console.KeyAvailable) {hasToEnd = true; Console.ReadKey(true); break;}
                    StringEater beep = new StringEater(c.ToString(), charDelay, true);                    
                };
            if (hasToEnd) {break;}
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    //MenuVibrance is awesome! it basically shows me how to do a loop with a string with multiple colors, 
    //never stopping and it is an animation. This is my FAVORITE creation of this class. 
    public string MenuVibrance(string chewedUpString, int charDelay, int curserPos, string menuOptions)
    {
        Console.CursorVisible = false;
        string functionInput = chewedUpString;
        bool hasToEnd = false;
        int lineBuffer = functionInput.Length;
        string keyPressed = "A";
        (int left, int top) = Console.GetCursorPosition();      
        while (!hasToEnd)
        {
            Console.SetCursorPosition(left, top);
            foreach (char c in functionInput) 
            {
                StringEater beep = new StringEater(c.ToString(), charDelay, true);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(intercept: true); 
                    keyPressed = key.KeyChar.ToString();
                    if (menuOptions.Contains(keyPressed)) //if any if the characters in the string are in keyPressed, will break the loop.
                    {
                        hasToEnd = true;
                        break;
                    }
                }
            }
            if (hasToEnd) break;
        }
        return keyPressed;
    }
    //I need to further develop this method, it does what I need 99% of the time, but I want to break it 
    //down and do some other stuff with it. I just have not had much time with it, I know I can do the same
    //and more if I dragged my knucles through it again.
    public void StandardDisplay()
    {
        if (_hMove == true && _vMove != true) {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Char c in _eatenString)
            {
                if (_randoColorChar == true) 
                {
                    Console.ForegroundColor = Randomizer.RandomConsoleColor();
                }
                Thread.Sleep(_digestiveDelay);
                for (int i = 0; i < _hMoveUnits; i++) {Console.Write(" "); }
                Console.Write(c);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        if (_hMove == true && _vMove == true) {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Char c in _eatenString)
            {
                if (_randoColorChar == true) 
                {
                    Console.ForegroundColor = Randomizer.RandomConsoleColor();
                }
                Thread.Sleep(_digestiveDelay);
                for (int i = 0; i < _hMoveUnits; i++) {Console.Write(" "); }
                Console.WriteLine(c);
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < _vMoveUnits; i++) {Console.WriteLine(""); }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        if (_hMove != true && _vMove != true) {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Char c in _eatenString)
            {
                {
                if (_randoColorChar == true) 
                {
                    Console.ForegroundColor = Randomizer.RandomConsoleColor();
                }
                Thread.Sleep(_digestiveDelay);
                Console.Clear();
                Console.Write(c);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
         }
    }
}