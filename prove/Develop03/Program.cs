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
        Console.Clear();
        if (endingVerse == "") 
        {
            Scripture memorizeThis = new Scripture(book, chapter, beginningVerse, scripture);
            scripture = memorizeThis.GetScripture(scripture);
            wordCounter = memorizeThis.GetScriptureWordCount();
            StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
            Console.ReadLine();
            Console.Clear();
        }
        else if (endingVerse != "") 
        {
            Scripture memorizeThis = new Scripture(book, chapter, beginningVerse, endingVerse, scripture);
            wordCounter = memorizeThis.GetScriptureWordCount();
            scripture = memorizeThis.GetScripture(scripture);
            StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
            Console.ReadLine();
        }
        Scripture memorizeThisAgain = new Scripture(book, chapter, beginningVerse, endingVerse, scripture);
        do
        {
            Console.Clear();
            Console.CursorVisible = false;
            scripture = memorizeThisAgain.GetUpdatedScripture(scripture);
            StringEater memorizeThisInColors = new StringEater($"{memorizeThisAgain.GetReference()} {scripture} ",true);
            Console.WriteLine("\n\n\n\n\n");

            StringEater memorizeThisInColors1 = new StringEater($"Initial Words: {memorizeThisAgain.GetScriptureWordCount()} Hidden Words: {memorizeThisAgain.GetHiddenWordsCount()} {scripture} ",true);
            StringEater memorizeThisInColors2 = new StringEater($"Remaining Words: {memorizeThisAgain.GetScriptureWordCount()-memorizeThisAgain.GetHiddenWordsCount()} {scripture} ",true);
            i++;
            loopExit = Console.ReadLine();
            if (loopExit == "quit" || loopExit == "Quit" || loopExit == "QUIT") {loopInputValidation = true;}
        } while(!loopInputValidation);
        
    } 
}      



