using System;
using System.Reflection;
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
            int menuDelay = 10;
            string menuSelector;
            string menu = "Welcome to your Mindfullness App - We Relax When You Relax\n\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n0. Quit ==>> ";
            Console.Clear();
            StringEater menuMessage = new StringEater(menu, menuDelay ,true);
            menuSelector =  menuMessage.MenuVibrance("==>>", 65, 8); //(string, character delay, charactor position resets to...)
            MenuOptions(menuSelector);
                if (menuSelector == "0") {looptyLoop = false;}
        } while (looptyLoop);
    }

    static private void MenuOptions(string parameterA)
    {
        string _selector = parameterA;
        
        switch (_selector)
        {
            case "1":
                Console.Clear();
                Breathing activityA = new Breathing();
                return;
            
            case "2":
                Console.Clear();
                Reflecting activityB = new Reflecting();
                return;
            
            case "3":
                Console.Clear();
                Listing activityC = new Listing();
                return;                                
            
            case "0":
                Playground.Quit();
                
                return;
            default:
                return;
        }

    }
}