using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.Clear();
        
        WelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userNumberSquared = SquareNumber(userNumber);
        DisplayResult(userName, userNumberSquared);
        ExitProgram();

        

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string localUserName = Console.ReadLine();
            Console.Clear();
            return localUserName;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string localUserString = Console.ReadLine();
            int localUserNumber = int.Parse(localUserString);
            Console.Clear();
            return localUserNumber;
        }
        
        static int SquareNumber(int number)
        {
            Console.Clear();
            return number * number;
        }
        
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {number}");
        }

        static void ExitProgram()
        {
            for (int i = 0; i < 6; i++ ) {Console.WriteLine("");}
            Console.WriteLine("<press any key>");
            Console.ReadKey();
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}