using System;

class Entry
{
    string _dateTime = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
    string _userPrompt = "";
    string _userEntry = "";
    string _combinedEntry = "";
    public string CombinedPromptUserEntry()
    {
        Console.WriteLine("Stub: CombinedPromptUserEntry()");
        PromptGenerator _userRandomPrompt = new PromptGenerator();
        _userPrompt = _userRandomPrompt.Prompt();
        Console.Write($"{_userPrompt}\n> ");
        _userEntry = Console.ReadLine();
        _combinedEntry = Serialize();
        //Console.WriteLine(_combinedEntry); //this was to test for the date/time stamped & serialized _combinedEntry
        return _combinedEntry;
    }

    public string Serialize()
    {
        Console.WriteLine("Stub: Entry/Serialize()");
        return $"{_dateTime}-|-{_userPrompt}-|-{_userEntry}";
    }

    static string Deserialize()
    {
        return "Stub: Entry/Deserialize()";
    }

     static void Display()
    {
        Console.WriteLine("Stub: Entry/Display()");
    }
    
}