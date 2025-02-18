using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        string beginningVerse = "13";
        string book = "Articles of Faith";
        string chapter = "1";
        string endingVerse = "";
        string loopExit  = "";
        string scripture = "We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men; indeed, we may say that we follow the admonition of Paul—We believe all things, we hope all things, we have endured many things, and hope to be able to endure all things. If there is anything virtuous, lovely, or of good report or praiseworthy, we seek after these things.";
        int i = 0;
        int wordCounter = 0;
        bool loopInputValidation = false;
        Console.CursorVisible = false;
        Playground dsjkfgd = new Playground();
        dsjkfgd.Intro();
        dsjkfgd.PlayingAround();
        dsjkfgd.ProgramPlanner();
        dsjkfgd.Quit();
        Console.Clear();

        Scripture memorizeThis = new Scripture(book, chapter, beginningVerse, scripture);
        //scripture = memorizeThis.GetScripture(scripture);
        if (endingVerse == "") 
        {
            scripture = memorizeThis.GetScripture(scripture);
            wordCounter = memorizeThis.GetScriptureWordCount();
            StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
            Console.ReadLine();
            Console.Clear();
        }
        else if (endingVerse != "") 
        {
            scripture = memorizeThis.GetScripture(scripture);
            StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
            Console.ReadLine();
            Console.Clear();
        }
        do
        {
            Console.Clear();
            Console.CursorVisible = false;
            scripture = memorizeThis.GetUpdatedScripture(scripture);
            StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture}\n\n",true);
            StringEater memorizeThisInColors1 = new StringEater($"Initial Words: {memorizeThis.GetScriptureWordCount()} Current Hidden Count: {memorizeThis.GetHiddenWordsCount()}\n",true);
            StringEater memorizeThisInColors2 = new StringEater($"Remaining Words to Hide: {memorizeThis.GetScriptureWordCount()-memorizeThis.GetHiddenWordsCount()}\n",true);
            memorizeThis.GetHiddenWordList();
            i++;
            loopExit = Console.ReadLine();
            if (loopExit == "quit" || loopExit == "Quit" || loopExit == "QUIT") {loopInputValidation = true;}
        } while(!loopInputValidation);
        
    } 
}      



