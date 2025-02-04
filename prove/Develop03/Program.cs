using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string welcomeMessage = "Hello Develop03 World!";
        Console.WriteLine(welcomeMessage);
        for (int i = 0; i < 5000; i++)
        {
           //for (int ii = 0; ii < 7; ii++)
           //{
              StringEater randomColoredChar = new StringEater(welcomeMessage);
              //Console.Write(" ");
              Console.Clear();
           //}

            //Console.WriteLine("");
        }
        Console.Clear();

        //randomColoredChar.DisplayRandomColoredChar();
        

        //RandomColorChar uno = new RandomColorChar(welcomeMessage);    
        //uno.GetDigestedString();

    }
}

