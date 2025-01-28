using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Xml.Serialization;

class Journal
{
    string journalName;
    List <string> _journalEntries = new List<string>();
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
        else if (userSelection == "5") {return _loopExit = "yes";}         
        return "I QUIT";                  
    }
    static void Write()
    {
        Console.WriteLine("Stub: Journal/Write()");
        PressAnyKey();
    } 
    static void Load()
    {
        Console.WriteLine("Stub: Journal/Load()");
        PressAnyKey();
    } 
    
    static void Save()
    {
        Console.WriteLine("Stub: Journal/Save()");
        PressAnyKey();
    } 


    static void Display()
    {
        Console.WriteLine("Stub: Journal/Display()");
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