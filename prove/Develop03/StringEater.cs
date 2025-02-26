using System;
public class StringEater
{
    private string _eatenString;
    private int _digestiveDelay = 0;
    private bool _randoColorChar = false;
    private bool _hMove = true;
    private bool _vMove = false;
    private int _hMoveUnits = 0;
    private int _vMoveUnits = 0;

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
    private void DisplayVertical()
    {
        List<char> digestedString = _eatenString.ToList();
        foreach (char c in digestedString)
        {
            Console.WriteLine(c);
        }
    }
    private void StandardDisplay()
    {
        if (_hMove == true && _vMove != true) {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Char c in _eatenString)
            {
                if (_randoColorChar == true) 
                {
                    Console.ForegroundColor = Randomizer.RandomConsoleColor();
                    //Console.BackgroundColor = Randomizer.RandomConsoleColor();
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
                    //Console.BackgroundColor = Randomizer.RandomConsoleColor();
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
                    //Console.BackgroundColor = Randomizer.RandomConsoleColor(); 
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