using System;
//I created this Utility class last semester. I developed the <Press Any Key> further with 
//some of the StringEater class. I use this to debug. It has actually been a lot of help.
//It will also generate a log file, I deleted it a moment ago. 
//This class derived from my struggles last semester of constantly using Console.ReadKey to 
//pause the program with a Console.Writeline() mapping things out for me. I love this class. 
//I cannot remember the term, but I used a feature where it auto detects my parameter and matches 
//it up with the proper constructor, I love that C# can figure that out. This was very cool to
//learn.
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
        StringEater pressAnyKey = new StringEater();
        pressAnyKey.Vibrance("<Press Any Key>",10,0); //(string,chardelay,curserposition)

    }
}
    