using System;
using System.Linq;
using System.Security.Cryptography;

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
        string scripture2 = scripture;
        string endItAll = "";
        int i = 0;
        int wordCounter = 0;
        bool innerLoopInputValidation = false;
        bool outerLoopInputValidation = false;
        Console.CursorVisible = false;
        Playground BeginningAndEnding = new Playground();
        BeginningAndEnding.Intro();
        BeginningAndEnding.ProgramPlanner();
         do
         {   
            Console.Clear();
            innerLoopInputValidation = false;
            outerLoopInputValidation = false; 
            Scripture memorizeThis = new Scripture(book, chapter, beginningVerse, scripture);
            if (endingVerse == "") 
            {
                memorizeThis.InitializeScripture(scripture);
                wordCounter = memorizeThis.GetScriptureWordCount();
                StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
                loopExit = Console.ReadLine();
                if (loopExit?.Trim().ToLower() == "cheat" ) {memorizeThis.GetHiddenWordList(); Console.WriteLine("\n"); Utility.PressAnyKey();}
                if (memorizeThis.GetScriptureWordCount()-memorizeThis.GetHiddenWordsCount() == 0) {innerLoopInputValidation = true;}
                if (loopExit?.Trim().ToLower() == "quit" ) {innerLoopInputValidation = true; Console.Clear(); StringEater quiter = new StringEater("Thank you, please try again later.",35,true);return;}
                Console.Clear();
            }
            else if (endingVerse != "") 
            {
                memorizeThis.InitializeScripture(scripture);
                StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture} ",true);
                loopExit = Console.ReadLine();
                if (loopExit?.Trim().ToLower() == "cheat" ) {memorizeThis.GetHiddenWordList(); Console.WriteLine("\n"); Utility.PressAnyKey();}
                if (memorizeThis.GetScriptureWordCount()-memorizeThis.GetHiddenWordsCount() == 0) {innerLoopInputValidation = true;}
                if (loopExit?.Trim().ToLower() == "quit" ) {innerLoopInputValidation = true; Console.Clear(); StringEater quiter = new StringEater("Thank you, please try again later.",35,true);return;}
                Console.Clear();
            }
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                scripture = memorizeThis.GetUpdatedScripture(scripture);
                StringEater memorizeThisInColors = new StringEater($"{memorizeThis.GetReference()} {scripture}\n\n",true);
                StringEater memorizeThisInColors1 = new StringEater($"Initial Words: {memorizeThis.GetScriptureWordCount()} \nCurrent Hidden Count: {memorizeThis.GetHiddenWordsCount()}\n",true);
                StringEater memorizeThisInColors2 = new StringEater($"Remaining Words to Hide: {memorizeThis.GetScriptureWordCount()-memorizeThis.GetHiddenWordsCount()}\n",true);
                i++;
                loopExit = Console.ReadLine();
                if (loopExit?.Trim().ToLower() == "cheat" ) {memorizeThis.GetHiddenWordList(); Console.WriteLine("\n"); Utility.PressAnyKey();}
                if (memorizeThis.GetScriptureWordCount()-memorizeThis.GetHiddenWordsCount() == 0) {innerLoopInputValidation = true;}
                if (loopExit?.Trim().ToLower() == "quit" ) {innerLoopInputValidation = true; Console.Clear(); StringEater quiter = new StringEater("Thank you, please try again later.",35,true);return;}
            } while(!innerLoopInputValidation);
            Console.Clear();
            StringEater programReset = new StringEater("Would you like to try again? Please type NO to quit? ",true);
            endItAll = Console.ReadLine();
            if (endItAll?.Trim().ToLower() == "no") {outerLoopInputValidation = true;}
            if (!outerLoopInputValidation) {Console.Clear(); StringEater reset = new StringEater("Resetting Your Scripture.....     ",100,true); scripture = scripture2;}
         } while(!outerLoopInputValidation);
        BeginningAndEnding.Quit();
        Console.Clear();
    }
}      



