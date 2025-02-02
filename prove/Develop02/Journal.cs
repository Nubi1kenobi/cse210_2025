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
        int _mySleepTimer = 20;
        List<string> _write = new List<string>()
        {
            "1","."," ","W","r","i","t","e"
        };
        int i = 0;
        foreach (string count in _write) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Utility.GetRandomColor(); 
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
            Console.ForegroundColor = Utility.GetRandomColor(); 
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
            Console.ForegroundColor = Utility.GetRandomColor(); 
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
            Console.ForegroundColor = Utility.GetRandomColor(); 
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
            Console.ForegroundColor = Utility.GetRandomColor(); 
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
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Console.Write($"{_prompt[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.CursorVisible = true;
        _userInput = Console.ReadLine();
        return _userInput;
    }
   public string JournalMenuChoice(string userSelection)
   {
        string _loopExit = "0";
        if (userSelection == "1") { Write(); return _loopExit = "no"; }         
        else if (userSelection == "2") {Display(); return _loopExit = "no";}         
        else if (userSelection == "3") {Load(); return _loopExit = "no";}         
        else if (userSelection == "4") {Save(); return _loopExit = "no";}         
        else if (userSelection == "5") {return _loopExit = "I QUIT";}  
        Console.ForegroundColor = Utility.GetRandomColor();        
        return _loopExit;                  
    }
    static void Write()
    {
        Console.ForegroundColor = Utility.GetRandomColor(); 
        Console.Clear();
        Entry _newEntry = new Entry();
        string _combinedNewEntry = _newEntry.CombinedPromptUserEntry();
        _journalEntries.Add(_combinedNewEntry);
    } 
    void Load()
    {
        int _mySleepTimer = 10;
        Console.Clear();
        List<string> _preload = new List<string>()
        {
            "P","l","e","a","s","e"," ","t","y","p","e"," ","a"," ","f","i","l","e","n","a","m","e"," ","f","o","r"," ","t","h","e"," ","j","o","u","r","n","a","l"," ","y","o","u"," ","w","o","u","l","d"," ","l","i","k","e"," ","t","o"," ","l","o","a","d",","," ","w","i","t","h","o","u","t"," ","t","h","e"," ","e","x","t","e","n","s","i","o","n","."
        };
        int i = 0;
        foreach (string count in _preload) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Console.Write($"{_preload[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.Write("\n> ");
        Console.ForegroundColor = Utility.GetRandomColor(); 
        _journalName = Console.ReadLine() + ".txt";
        string[] fileLines = File.ReadAllLines(_journalName);     
        _journalEntries.Clear();
        foreach (string fileLine in fileLines) 
        {
            Entry newEntry = new Entry();
            _journalEntries.Add(fileLine);
        } 
        Console.Clear();    
        Console.ForegroundColor = Utility.GetRandomColor(); 
        Console.Write($"{_journalName}");
        List<string> _loaded = new List<string>()
        {
            " ","h","a","s"," ","b","e","e","n"," ","l","o","a","d","e","d","."
        };
        int ii = 0;
        //Console.WriteLine("");
        foreach (string counted in _loaded) 

        {  
            Console.CursorVisible = true;
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Console.Write($"{_loaded[ii]}");
            ii++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Utility.PressAnyKey();
    } 
    void Save()
    {
        Console.Clear();
        Console.ForegroundColor = Utility.GetRandomColor(); 
        int _mySleepTimer = 10;
        int _i = 0;
        List<string> _savedfile = new List<string>()
        {
            "P","l","e","a","s","e"," ","d","e","c","l","a","r","e"," ","a"," ","f","i","l","e","n","a","m","e"," ","f","o","r"," ","t","h","i","s"," ","j","o","u","r","n","a","l"," ","(","w","i","t","h","o","u","t"," ","t","h","e"," ",".","e","x","t",")",": "
        };
        foreach (string countfileline in _savedfile) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Console.Write($"{_savedfile[_i]}");
            _i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.ForegroundColor = Utility.GetRandomColor(); 
        _journalName = Console.ReadLine() + ".txt";
        using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
            {                     
                foreach (string journalEntry in _journalEntries)
                    {
                        _outputFile.WriteLine(journalEntry);
                    }
            }
        Console.Clear();
        Console.ForegroundColor = Utility.GetRandomColor();     
        Console.Write(_journalName);  
        List<string> _saved = new List<string>()
        {
            " ","h","a","s"," ","b","e","e","n"," ","s","a","v","e","d","."
        };
        int i = 0;
        foreach (string count in _saved) 
        {  
            Console.CursorVisible = false;
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Console.Write($"{_saved[i]}");
            i++;
            Thread.Sleep(_mySleepTimer);
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Utility.PressAnyKey();
    } 
    static void Display()
    {
        Console.Clear();
        foreach (string _entry in _journalEntries)
        {
            Console.ForegroundColor = Utility.GetRandomColor(); 
            Entry.Deserialize(_entry);
        }
        Console.WriteLine("");
        Utility.PressAnyKey();
    } 
    static string Quit()
    {
        Utility.PressAnyKey();
        return "I QUIT";
    } 


}