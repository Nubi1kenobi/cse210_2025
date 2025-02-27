using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning04 World!\n");
        Assignment ichi = new Assignment("Samual Bennett", "Multiplication");
        Console.WriteLine($"{ichi.GetSummary()}");
        
        MathAssignment ni = new MathAssignment("Robert Rodrigez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"\n{ni.GetSummary()}");
        Console.WriteLine($"\n{ni.GetHomeworkList()}");

        WritingAssignment san = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"\n{san.GetSummary()}");
        Console.WriteLine($"\n{san.GetWritingInformation()}");
    }
}