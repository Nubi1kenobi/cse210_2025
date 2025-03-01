using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        StringEater welcome = new StringEater("Hello Develop04 World!", 45, true);
        Thread.Sleep(1500);
        Menu();
    }
        static public void Menu()
    {
        bool looptyLoop = true;
        do
        {
            int menuDelay = 15;
            string menuSelector;
            Console.Clear();
            StringEater menuMessage = new StringEater("Welcome to your Mindfullness App - We Relax When You Relax\n\n", menuDelay ,true);
            StringEater menu1 = new StringEater("1. Breathing Activity\n", menuDelay ,true);
            StringEater menu2 = new StringEater("2. Reflection Activity\n", menuDelay ,true);
            StringEater menu3 = new StringEater("3. Listing Activity\n", menuDelay ,true);
            StringEater menu0 = new StringEater("0. Quit ==>> ", menuDelay ,true);
            menuSelector = Console.ReadLine();
            MenuOptions(menuSelector);
                if (menuSelector == "0") {looptyLoop = false;}
        } while (looptyLoop);
    }

    static private void MenuOptions(string parameterA)
    {
        string activityA_Intro = "";
        string activityB_Intro = "";
        string activityC_Intro = "";
        string activityA_Exit = "";
        string activityB_Exit = "";
        string activityC_Exit = "";
        int activityA_Delay = 65;
        int activityB_Delay = 65;
        int activityC_Delay = 65;

        string _selector = parameterA;
        switch (_selector)
        {
            case "1":
                Breathing activityA = new Breathing(activityA_Intro, activityA_Exit, activityA_Delay);
                return;
            
            case "2":
                Reflecting activityB = new Reflecting(activityB_Intro, activityB_Exit, activityB_Delay);
                return;
            
            case "3":
                Listing activityC = new Listing(activityC_Intro, activityC_Exit, activityC_Delay);
                return;                                
            
            case "0":
                Playground endItAll = new Playground();
                endItAll.Quit();
                
                return;
            default:
                return;
        }

    }
}