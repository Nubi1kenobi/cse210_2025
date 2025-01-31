using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Xml.Serialization;

class Journal
{
    private string _journalName;
    public static List<string> _journalEntries = new List<string>();
    public string JournalMenu()
    {
        string _userInput = "";
         Console. ForegroundColor = ConsoleColor. DarkRed;
        Console.WriteLine("1. Write ");
         Console. ForegroundColor = ConsoleColor. White;
        Console.WriteLine("2. Display ");
         Console. ForegroundColor = ConsoleColor. DarkBlue;
        Console.WriteLine("3. Load ");
         Console. ForegroundColor = ConsoleColor. DarkRed;
        Console.WriteLine("4. Save ");
         Console. ForegroundColor = ConsoleColor. White;
        Console.WriteLine("5. Quit ");
        Console. ForegroundColor = ConsoleColor. DarkBlue;
        Console.Write("What would you like to do? ");
        Console. ForegroundColor = ConsoleColor. White;
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
        Console.Clear();
        Console.WriteLine("Stub: Journal/Write()");
        Entry _newEntry = new Entry();
        string _combinedNewEntry = _newEntry.CombinedPromptUserEntry();
        _journalEntries.Add(_combinedNewEntry);
        PressAnyKey();
    } 
    void Load()
    {
        Journal myJournal = new Journal();  
        Console.Clear();
        Console.WriteLine("Stub: Journal/Load()");
  
        Console.Write("Please type a filename for the journal you would like to load, without the extension.\n> ");
        _journalName = Console.ReadLine() + ".txt";
        
        string[] fileLines = File.ReadAllLines(_journalName);              
        
        foreach (string fileLine in fileLines) 
            {
                Entry newEntry = new Entry();
                _journalEntries.Add(fileLine);
            } 

        Console.Clear();    //above and beyond, makes it cleaner.
        Console.WriteLine($"{_journalName} has been loaded.");
        PressAnyKey();
    } 
    
    void Save()
    {
        Console.Clear();
        Console.WriteLine("Stub: Journal/Save()");
        Console.Write("Please declare a filename to use for this journal (without the extension): ");
        _journalName = Console.ReadLine() + ".txt";
        using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
            {                     
                foreach (string journalEntry in _journalEntries)
                    {
                        _outputFile.WriteLine(journalEntry);
                    }
            }

        Console.Clear();    
        Console.WriteLine($"{_journalName} has been saved.");  
        PressAnyKey();
    } 

    static void Display()
    {
        Console.Clear();
        Console.WriteLine("Stub: Journal/Display()");
        foreach (string _entry in _journalEntries)
        {
            Console.WriteLine(Entry.Deserialize(_entry));
        }
        Console.WriteLine("");
        PressAnyKey();
    } 

    static string Quit()
    {
        Console.WriteLine("Stub: Journal/Quit()");
        PressAnyKey();
        return "I QUIT";
    } 

    public static void PressAnyKey()
    {
        Console. ForegroundColor = ConsoleColor. DarkYellow;
        Console.CursorVisible = false;
        Console.Write("<press any key>");
        Console.ReadKey();
        Console.CursorVisible = true;
        Console. ForegroundColor = ConsoleColor. White;
    }


}