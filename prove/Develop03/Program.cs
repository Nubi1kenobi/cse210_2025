using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Intro();
        StringEater2 randomColoredChar = new StringEater2("Muahahahahah!!!!");
        Console.WriteLine("");
        StringEater2 randomColoredChar1 = new StringEater2("Muahahahahah!!!!");
        Console.WriteLine("");
        StringEater2 randomColoredChar2 = new StringEater2("Muahahahahah!!!!");
        Console.WriteLine("");
        StringEater2 randomColoredChar3 = new StringEater2("Muahahahahah!!!!");
        Console.WriteLine("");
        StringEater2 randomColoredChar4 = new StringEater2("Muahahahahah!!!!");
        Console.WriteLine("");
        string fileName = "Planning.txt";
        List<string> readingAllLines = File.ReadAllLines(fileName).ToList(); 
        foreach (string line in readingAllLines)
        {
            StringEater3 somethingNew = new StringEater3(line);
            Console.WriteLine("");
        }

       //C# - List<string> gettingAllLines = File.ReadAllLines(Planning.txt).ToList;  generates an error with "Planning", error CS0103 - how do I fix this?

    }
    static void Intro()
    {
        Console.Clear();
        string welcomeMessage = "Hello Develop03 World!";
        Console.WriteLine(welcomeMessage);
        for (int i = 0; i < 100; i++)
        {
           for (int ii = 0; ii < 7; ii++)
           {
              StringEater randomColoredChar = new StringEater(welcomeMessage);
              Console.Write(" ");
           }
            Console.WriteLine("");
        }
        Console.Clear();
    }
}

