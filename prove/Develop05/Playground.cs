using System;
using System.Net.NetworkInformation;
//This class was created for me to play around with things, and it stuck. 
//I used it for doing weird things and having an intro and an exit. 
//I didnt get around to a proper intro for this program, but the exit works.
class Playground
{   
    static public void Quit()
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