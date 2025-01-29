using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Xml.Serialization;

class Journal
{
    string journalName;
    public static List<string> _journalEntries = new List<string>();
    public static string JournalMenu()
    {
        string _userInput = "";
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        Console.Write("What would you like to do? ");
        _userInput = Console.ReadLine();
        return _userInput;
    }

   public static string JournalMenuChoice(string userSelection)
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
    static void Load()
    {
        Console.Clear();
        Console.WriteLine("Stub: Journal/Load()");
        PressAnyKey();
    } 
    
    static void Save()
    {
        Console.Clear();
        Console.WriteLine("Stub: Journal/Save()");
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
        Console.WriteLine("<press any key>");
        Console.ReadKey();
    }


}