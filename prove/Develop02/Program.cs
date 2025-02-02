using System;
using System.Drawing;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string menu = "-1";
        Console.WriteLine("Hello Develop02 World!");
        Welcome();  //I added a little flare.
        Journal myJournal = new Journal();  //creates new object that is a journal.
        Console.Clear();
        while (menu != "I QUIT")    //loop that keeps program rolling until it is time to quit
        {
            Console.Clear();    //refreshs the screen
            string userInput = myJournal.JournalMenu();   
            menu = myJournal.JournalMenuChoice(userInput);
        }
        Quit(); //I added a little more flare.
    }
    static void Welcome()
    {  
        int _mySleepTimer = 65;
        List<string> _welcomeMessage = new List<string>()
        {
            "W","e","l","c","o","m","e"," ","t","o"," ","Y","o","u","r"," ","P","e","r","s","o","n","a","l"," ","J","o","u","r","n","a","l"," ","A","p","p",","," ","I"," ","h","o","p","e"," ","y","o","u"," ","e","n","j","o","y"," ","i","t","!" 
        };
        Console.CursorVisible = false;
        Console.Clear();
        int i = 0;
        Console.ForegroundColor = Utility.GetRandomColor(); 
        foreach (string count in _welcomeMessage) 
        {  
            Console.ForegroundColor = Utility.GetRandomColor(); 
            if (i == 38) {Console.WriteLine(""); Console.WriteLine(""); _mySleepTimer = 0;Console. ForegroundColor = ConsoleColor.White;}
            Console.Write($"{_welcomeMessage[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Utility.PressAnyKey();
        Console.Clear();
        Console.CursorVisible = true;
    }
    static void Quit()
    {    
        int _mySleepTimer = 500;
        Random randomNumber2 = new Random();
        List<string> _iQuit = new List<string>()
        {
            "Goodbye", "Au revoir","Auf Wiedersehen","Yasou", "L'hitraot", "Namaste", "Viszlát!", "Vertu Saeill!", "Atsiprasau", "Zài jiàn", "Ha det bra","Khodaa haafez", "Żegnaj", "Adeus","Adiós","Chao","Dasvidaniya","Poka", "Bài bài","Zàijiàn", "Arrivederci","Ciao","Sayonara","Ja nee","Farvel","Kwaheri","Baadaye",
            "Goodbye", "Au revoir","Auf Wiedersehen","Yasou", "L'hitraot", "Namaste", "Viszlát!", "Vertu Saeill!", "Atsiprasau", "Zài jiàn", "Ha det bra","Khodaa haafez", "Żegnaj", "Adeus","Adiós","Chao","Dasvidaniya","Poka", "Bài bài","Zàijiàn", "Arrivederci","Ciao","Sayonara","Ja nee","Farvel","Kwaheri","Baadaye" 
        };
        Console.CursorVisible = false;
        Console.Clear();
        foreach (string count in _iQuit) 
        {
            Console.ForegroundColor = Utility.GetRandomColor(); 
            int _magicKey2 = randomNumber2.Next(_iQuit.Count); 
            Console.Write($"<{_iQuit[_magicKey2]}> ");
            Thread.Sleep(_mySleepTimer);
            _mySleepTimer = _mySleepTimer - 25;
            if (_mySleepTimer <= 0){_mySleepTimer = 25;}
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Utility.PressAnyKey();
        Console.Clear();
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
class Utility
{
    public static ConsoleColor GetRandomColor()
    {
        Random randomColor = new Random();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomColor.Next(consoleColors.Length));
    }
    public static void PressAnyKey()
    {
        List<string> _pressanykey = new List<string>()
        {
            "<","p","r","e","s","s"," ","a","n","y"," ","k","e","y",">"
        };
        Console. ForegroundColor = GetRandomColor();
        Console.CursorVisible = false;
        int _i = 0;
        foreach (string count in _pressanykey) 
        {  
            int _mySleepTimer = 10;
            Console.CursorVisible = false;
            Console.ForegroundColor = GetRandomColor(); 
            Console.Write($"{_pressanykey[_i]}");
            _i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.ReadKey();
        Console.CursorVisible = true;
        Console. ForegroundColor = GetRandomColor();;
    }
}
