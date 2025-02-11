using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

class Program
{
    //(string eatenString, int digestiveDelay, bool horizontalMovement, bool verticalMovement,int horizontalMoveUnits, int verticalMoveUnits, bool randoColorChar)
    static void Main(string[] args)
    {
        Intro();
        Utility.PressAnyKey();
        PlayingAround();
 
    }
    static void Intro()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        string welcomeMessage = "Hello Develop03 World!";
        Console.WriteLine(welcomeMessage, true);
        for (int i = 0; i < 100; i++)
        {
           for (int ii = 0; ii < 7; ii++)
           {
              StringEater randomColoredChar = new StringEater(welcomeMessage, true);
              Console.Write(" ");
           }
            Console.WriteLine("");
        }
    }
    static void PlayingAround() 
    {
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
        string fileName = "Planning.txt";
        List<string> readingAllLines = File.ReadAllLines(fileName).ToList(); 
        foreach (string line in readingAllLines)
        {
            StringEater3 somethingNew = new StringEater3(line);
            Console.WriteLine("");
        }

    }
    class Utility
    {
        public static void PressAnyKey()
        {
            string pressanykey = "<press any key>";
            StringEater randomColoredChar = new StringEater(pressanykey, 35, true, 0, false, 0, true);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

