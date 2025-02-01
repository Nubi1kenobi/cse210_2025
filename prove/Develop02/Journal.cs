using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Security.Principal;
class Journal
{
    static private string _journalName;
    public static List<string> _journalEntries = new List<string>();
    public string JournalMenu()
    {
        string _userInput = "";
        int _mySleepTimer = 10;
        List<string> _write = new List<string>()
        {
            "1","."," ","W","r","i","t","e"
        };
        int i = 0;
        foreach (string count in _write) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_write[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        List<string> _display = new List<string>()
        {
            "2","."," ","D","i","s","p","l","a","y"
        };
        i = 0;
        foreach (string count in _display) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_display[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        List<string> _load = new List<string>()
        {
            "3","."," ","L","o","a","d"
        };
        i = 0;
        foreach (string count in _load) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_load[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        List<string> _save = new List<string>()
        {
            "4","."," ","S","a","v","e"
        };
        i = 0;
        foreach (string count in _save) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_save[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        List<string> _quit = new List<string>()
        {
            "5","."," ","Q","u","i","t"
        };
        i = 0;
        foreach (string count in _quit) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_quit[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        List<string> _prompt = new List<string>()
        {
            "W","h","a","t"," ","w","o","u","l","d"," ","y","o","u"," ","l","i","k","e"," ","t","o"," ","d","o","?","¿","?","¿",">",">","> "
        };
        i = 0;
        foreach (string count in _prompt) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_prompt[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.CursorVisible = true;
        /*
        List<string> _menu = new List<string>()                        //need to fix this when I have more time
        {                                                              //to figure out the list in a list with
            "_write", "_save", "_load", "_save", "_quit", "_prompt"    //nested loops
        };
        int _mySleepTimer = 25;
        for (int _i = 0; _i <= _menu.Count(); _i++)
        {
            for (int _ii = 0; _ii <= _menu[_i].Count(); _ii++)
            {
                Console.ForegroundColor = Journal.GetRandomColor(); 
                Console.Write($"{_menu[_i][_ii]}");
                Thread.Sleep(_mySleepTimer);
            }
        }
        */
        _userInput = Console.ReadLine();
        return _userInput;
    }
   public string JournalMenuChoice(string userSelection)
   {
        string _loopExit = "0";
        if (userSelection == "1") { Write(); return _loopExit = "no";}         
        else if (userSelection == "2") {Display(); return _loopExit = "no";}         
        else if (userSelection == "3") {Load(); return _loopExit = "no";}         
        else if (userSelection == "4") {Save(); return _loopExit = "no";}         
        else if (userSelection == "5") {return _loopExit = "I QUIT";}         
        return _loopExit;                  
    }
    static void Write()
    {
        Console.ForegroundColor = Journal.GetRandomColor(); 
        Console.Clear();
        Entry _newEntry = new Entry();
        string _combinedNewEntry = _newEntry.CombinedPromptUserEntry();
        _journalEntries.Add(_combinedNewEntry);
    } 
    void Load()
    {
        Console.ForegroundColor = Journal.GetRandomColor(); 
        Console.Clear();
        Console.Write("Please type a filename for the journal you would like to load, without the extension.\n> ");
        _journalName = Console.ReadLine() + ".txt";
        string[] fileLines = File.ReadAllLines(_journalName);     
        _journalEntries.Clear();
        foreach (string fileLine in fileLines) 
        {
            Entry newEntry = new Entry();
            _journalEntries.Add(fileLine);
        } 
        Console.Clear();    //above and beyond, makes it cleaner.
        Console.WriteLine("");
        Console.ForegroundColor = Journal.GetRandomColor(); 
        Console.Write($"{_journalName}");
        int _mySleepTimer = 10;
        List<string> _loaded = new List<string>()
        {
            " ","h","a","s"," ","b","e","e","n"," ","l","o","a","d","e","d"
        };
        int i = 0;
        foreach (string count in _loaded) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_loaded[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        PressAnyKey();
    } 
    void Save()
    {
        Console.Clear();
        Console.ForegroundColor = Journal.GetRandomColor(); 
        int _mySleepTimer = 10;
        int _i = 0;
        List<string> _savedfile = new List<string>()
        {
            "P","l","e","a","s","e"," ","d","e","c","l","a","r","e"," ","a"," ","f","i","l","e","n","a","m","e"," ","f","o","r"," ","t","h","i","s"," ","j","o","u","r","n","a","l"," ","(","w","i","t","h","o","u","t"," ","t","h","e"," ",".","e","x","t",")",": "
        };
        foreach (string counfilet in _savedfile) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_savedfile[_i]}");
            _i++;
            Thread.Sleep(_mySleepTimer);
        }
        _journalName = Console.ReadLine() + ".txt";
        using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
            {                     
                foreach (string journalEntry in _journalEntries)
                    {
                        _outputFile.WriteLine(journalEntry);
                    }
            }
        Console.Clear();
        Console.ForegroundColor = Journal.GetRandomColor();     
        Console.Write(_journalName);  
        List<string> _saved = new List<string>()
        {
            " ","h","a","s"," ","b","e","e","n"," ","s","a","v","e","d","."
        };
        int i = 0;
        foreach (string count in _saved) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_saved[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        Console.WriteLine("");
        PressAnyKey();
    } 
    static void Display()
    {
        Console.Clear();
        foreach (string _entry in _journalEntries)
        {
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Entry.Deserialize(_entry);
        }
        Console.WriteLine("");
        PressAnyKey();
    } 
    static string Quit()
    {
        PressAnyKey();
        return "I QUIT";
    } 
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
            Console.ForegroundColor = Journal.GetRandomColor(); 
            Console.Write($"{_pressanykey[_i]}");
            _i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.ReadKey();
        Console.CursorVisible = true;
        Console. ForegroundColor = Journal.GetRandomColor();;
    }


}