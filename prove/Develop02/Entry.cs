using System;

class Entry
{
    static string _dateTime = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
    static string _userPrompt = "";
    static string _userEntry = "";
    static string _combinedEntry = "";
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
  
     public static string Deserialize(string journalEntry)
            {
                Console.WriteLine("Stub: Entry/Deserialize()");
                string[] segment = journalEntry.Split("-|-");
                
                if (journalEntry.Length < 3)
                    {
                        Console.WriteLine("ERROR - Missing line segments, in Entry.Deserialize.");
                    }
                else
                    {
                        _dateTime = segment[0];
                        _userPrompt = segment[1];    
                        _userEntry = segment[2];
                    }
                return $"DateTime: {_dateTime} - Prompt: {_userPrompt}\n{_userEntry}";
            }

     static void Display()
    {
        Console.WriteLine("Stub: Entry/Display()");
    }
    
}