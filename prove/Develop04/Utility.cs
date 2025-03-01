using System;
class Utility
{ 
private static readonly string logFilePath = "debug.log"; // Example log file path

public static void Debug()
    {
        Console.WriteLine("Debug();");
        Log("Debug();");
        PressAnyKey();
    }

public static void Debug(bool parameter)
    {
        Console.WriteLine($"Debug(bool parameter); {parameter}");
        Log($"Debug(bool parameter); {parameter}");
        PressAnyKey();
    }

public static void Debug(string parameter)
    {
        Console.WriteLine($"Debug(string parameter); {parameter}");
        Log($"Debug(string parameter); {parameter}");
        PressAnyKey();
    }

public static void Debug(int parameter)
    {
        Console.WriteLine($"Debug(int parameter); {parameter}");
        Log($"Debug(int parameter); {parameter}");
        PressAnyKey();
    }

private static void Log(string message)
    {
        try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                    {
                        writer.WriteLine($"[{DateTime.Now}] {message}");
                    }
            }
        catch (Exception ex)
            {
                Console.WriteLine($"Error while logging: {ex.Message}");
            }
    }
    public static void PressAnyKey()
    {
        Console.CursorVisible = false;
        string pressanykey = "<Press Any Key>";
        bool hasToEnd = false;
        while (!hasToEnd)
        {
            foreach (char c in pressanykey) 
                {
                    if (Console.KeyAvailable) {hasToEnd = true; Console.ReadKey(true); break;}
                    StringEater beep = new StringEater(c.ToString(), 10, true);
                };
            if (Console.CursorLeft + 1 >= 15) {Console.SetCursorPosition(0, Console.CursorTop);}
            if (hasToEnd) {break;}
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("                    ");
        Console.SetCursorPosition(0, Console.CursorTop);

    }
    
}
    