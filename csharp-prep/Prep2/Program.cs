using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string sign = "";
        string endStatementAcedClass = "WOW, what a FANTASTIC grade!";
        string endStatementFailedClass = "Better luck next time when you retake the class, kiddo.";
        string endStatementExtraFailedClass = "WOW, mistakes were made. I wish you the best of luck if you retake the class, kiddo.";
        int lastDigit;

            Console.Clear();
            Console.WriteLine("Hello Prep2 World!");
            Console.Write("What is your grade percentage? ");
            string gradePercentageUserInput = Console.ReadLine();
            int gradePercentage = int.Parse(gradePercentageUserInput);  //unser string input parsed to an integer
            Console.Clear();
            
//for the letter grade sign
            lastDigit = gradePercentage % 10;   //isolating the second digit 
            switch(lastDigit)
            {
                case < 3:
                    sign = "-";
                break;
                
                case >= 7:
                    sign = "+";
                break;
                
            }

//stepping through the conditional so we can assign a letter grade
            if (gradePercentage >= 94) 
            {
                letter = "A"; 
                sign = ""; 
                Console.WriteLine(endStatementAcedClass);
            }
            else if (gradePercentage >= 90) 
            {
                letter = "A";
            }
            else if (gradePercentage >= 80) 
            {
                letter = "B";
            }
            else if (gradePercentage >= 70) 
            {
                letter = "C";
            }
            else if (gradePercentage >= 60) 
            {
                letter = "D"; 
                Console.WriteLine(endStatementFailedClass);
            }
            else 
            {
                letter = "F"; Console.WriteLine(endStatementExtraFailedClass);
                sign = ""; 
            }

//this is the end, states grade percentage with the appropriate letter grade
            Console.WriteLine($"Your grade of {gradePercentage}%, equals a(n) {letter}{sign}. ");

    }
}