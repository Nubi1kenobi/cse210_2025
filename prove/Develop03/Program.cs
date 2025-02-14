using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string bookRef = "Articles of Faith";
        string chapterRef = "1";
        string beginningVerseRef = "13";
        string endingVerseRef = "";
        string scriptureText = "We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men; indeed, we may say that we follow the admonition of Paul—We believe all things, we hope all things, we have endured many things, and hope to be able to endure all things. If there is anything virtuous, lovely, or of good report or praiseworthy, we seek after these things.";
        
        //Intro();
        //Utility.PressAnyKey();
        //PlayingAround();
        //Utility.PressAnyKey();
        //ProgramPlanner();
        //Utility.PressAnyKey();
        ScriptureMem(bookRef, chapterRef, beginningVerseRef, endingVerseRef, scriptureText);
        
 
    }

    static void ScriptureMem(string book, string chapter, string begin, string ending, string scripture)
    {
        bool programLoop = true;
        string loopTest = "";
        string _book = book;
        string _chapter = chapter;
        string _beginningVerse = begin;
        string _endingVerse = ending;
        string _scripture = scripture;
        int _wordCount1;
        
        do
        {
            Console.CursorVisible = false;
            Console.Clear();
            if (ending == "") 
            {
                Scripture memorizeThis = new Scripture(_book, _chapter, _beginningVerse, _scripture);
                _wordCount1 = memorizeThis.GetScriptureWords();
            }
            else if (ending != "") 
            {
                Scripture memorizeThis = new Scripture(_book, _chapter, _beginningVerse, _endingVerse, _scripture);
                _wordCount1 = memorizeThis.GetScriptureWords();
            }
            else
            //_scripture = memorizeThis.GetSripture(_scripture);
            int _initialRando = Randomizer(3);
            StringEater randomColoredChar = new StringEater(_scripture,0,true,0,false,0,true);
            Console.WriteLine($"\n\n");


            loopTest = Console.ReadLine();
            if (loopTest == "quit" || loopTest == "Quit" || loopTest == "QUIT" ) { programLoop = false;} 
            
        }
        while (programLoop);
        Console.CursorVisible = true;
    }       
    static void Intro()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        string welcomeMessage = "<Let's Memorize a Scripture Together!> ";
        for (int i = 0; i < 100; i++)
        {
           for (int ii = 0; ii < 4; ii++)
           {
              StringEater randomColoredChar = new StringEater(welcomeMessage, true);
              Console.Write(" ");
           }
            Console.WriteLine("");
        }
    }
    static void ProgramPlanner()
    {
        string fileName = "Planning.txt";
        List<string> readingAllLines = File.ReadAllLines(fileName).ToList(); 
        foreach (string line in readingAllLines)
        {
            StringEater somethingNew = new StringEater(line);
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
    }
    static private int Randomizer(int wordCount)
    {
        int _randomNumber;
        int _wordCount = wordCount;
        Random _randoCommando = new Random();
        _randomNumber = _randoCommando.Next(1,_wordCount);
        return _randomNumber;
    }
    
}


