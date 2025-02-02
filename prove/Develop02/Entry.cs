using System;

class Entry
{
    static string _userPrompt = "";
    static string _userEntry = "";
    static string _combinedEntry = "";
    public string CombinedPromptUserEntry()
    {
        PromptGenerator _userRandomPrompt = new PromptGenerator();
        _userPrompt = _userRandomPrompt.Prompt();
        Console.Write($"{_userPrompt}\n> ");
        Console.ForegroundColor = Utility.GetRandomColor(); 
        _userEntry = Console.ReadLine();
        _combinedEntry = Serialize();
        return _combinedEntry;
    }
    public string Serialize()
    {
        string _dateTime = DateTime.Now.ToString("dd/MM/yyyy @ HH:mm:ss");
        return $"{_dateTime}-|-{_userPrompt}-|-{_userEntry}";
    }
 public static void Deserialize(string journalEntry)
            {
                string _dateTime = "";
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
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"Date/Time Stamp: ");
                Console.ForegroundColor = Utility.GetRandomColor();
                Console.Write(_dateTime);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" - Prompt: "); 
                Console.ForegroundColor = Utility.GetRandomColor();
                Console.WriteLine(_userPrompt);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Your Entry: ");
                Console.ForegroundColor = Utility.GetRandomColor();
                Console.WriteLine($"{_userEntry}\n");
                Console.ForegroundColor = Utility.GetRandomColor(); 
 
 }
}