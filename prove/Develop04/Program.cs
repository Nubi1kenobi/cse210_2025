using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        StringEater welcome = new StringEater("Hello Develop04 World!", 35, true);
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
            string menu = "Welcome to your Mindfullness App - We Relax When You Relax\n\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n0. Quit ==>> ";
            Console.Clear();
            CountTo10 yes = new CountTo10(1,10,false,false); 
            Utility.PressAnyKey();  
            StringEater menuMessage = new StringEater(menu, menuDelay ,true);
            menuSelector = Console.ReadLine();
            MenuOptions(menuSelector);
                if (menuSelector == "0") {looptyLoop = false;}
        } while (looptyLoop);
    }

    static private void MenuOptions(string parameterA)
    {
        string activityA_Intro = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
        string activityB_Intro = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
        string activityC_Intro = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
        string activityA_Exit = "Remember to slow down and breath. Thank you for sharing your time with us.\n";
        string activityB_Exit = "We must always remember to take a pause and reflect on our blessings every day.\n";
        string activityC_Exit = "Sometimes it takes listing things out to see how truly blessed we are!\n";
        int activityA_Delay = 45;
        int activityB_Delay = 45;
        int activityC_Delay = 45;

        string _selector = parameterA;
        switch (_selector)
        {
            case "1":
                Console.Clear();
                Breathing activityA = new Breathing(activityA_Intro, activityA_Exit, activityA_Delay);
                return;
            
            case "2":
                Console.Clear();
                Reflecting activityB = new Reflecting(activityB_Intro, activityB_Exit, activityB_Delay);
                return;
            
            case "3":
                Console.Clear();
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