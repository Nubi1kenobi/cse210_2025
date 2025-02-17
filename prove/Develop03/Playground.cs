using System;
class Playground
{

    public void PlayingAround() 
    {
        Console.CursorVisible = false;
        StringEater randomColoredChar = new StringEater("Muahahahahah!!!!");
        Console.WriteLine("");
        StringEater randomColoredChar1 = new StringEater("Muahahahahah!!!!",0,true,0,false,0,true);
        Console.WriteLine("");
        StringEater randomColoredChar2 = new StringEater("Muahahahahah!!!!",25,true,1,false,0,true);
        Console.WriteLine("");
        StringEater randomColoredChar3 = new StringEater("Muahahahahah!!!!",50,true,2,false,0,true);
        Console.WriteLine("");
        StringEater randomColoredChar4 = new StringEater("Muahahahahah!!!!",100,true,3,true,2,true);
        Console.WriteLine("");
        StringEater randomColoredChar5 = new StringEater("Muahahahahah!!!!",250,false,0,false,0,true);
        Console.WriteLine("");
    }
    public void Intro()
    {
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        string welcomeMessage = "<Let's Memorize a Scripture Together!> ";
        for (int i = 0; i < 60; i++)
        {
           for (int ii = 0; ii < 4; ii++)
           {
              StringEater randomColoredChar = new StringEater(welcomeMessage, true);
              Console.Write(" ");
           }
            Console.WriteLine("");
        }
        Thread.Sleep(2000);
        Console.Clear();
        ProgramPlanner();  
        Utility.PressAnyKey();
        Console.CursorVisible = true;
    }
    private static void ProgramPlanner()
    {
        string fileName = "Planning.txt";
        List<string> readingAllLines = File.ReadAllLines(fileName).ToList(); 
        foreach (string line in readingAllLines)
        {
            StringEater somethingNew = new StringEater(line);
            Console.WriteLine("");
        }
    }
    public void Quit()
    {    
        Console.CursorVisible = false;
        int _mySleepTimer = 500;
        Random randomNumber2 = new Random();
        List<string> _iQuit = new List<string>()
        {
            "Goodbye", "Au revoir","Auf Wiedersehen","Yasou", "L'hitraot", "Namaste", "Viszlát!", "Vertu Saeill!", "Atsiprasau", "Zài jiàn", "Ha det bra","Khodaa haafez", "Żegnaj", "Adeus","Adiós","Chao","Dasvidaniya","Poka", "Bài bài","Zàijiàn", "Arrivederci","Ciao","Sayonara","Ja nee","Farvel","Kwaheri","Baadaye",
        };
        Console.CursorVisible = false;
        Console.Clear();
        foreach (string count in _iQuit) 
        {
            Console.ForegroundColor = Randomizer.RandomConsoleColor(); 
            int _magicKey2 = randomNumber2.Next(_iQuit.Count); 
            //Console.Write($"<{_iQuit[_magicKey2]}> ");
            StringEater randomColoredChar1 = new StringEater($"<{_iQuit[_magicKey2]}> ",0,true,0,false,0,true);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(_mySleepTimer);
            _mySleepTimer = _mySleepTimer - 25;
            if (_mySleepTimer <= 0){_mySleepTimer = 25;}
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Utility.PressAnyKey();
        Console.Clear();
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}