using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomNumber = new Random();
        int magicNumber = 0;
        int lowerLimit = 1;
        int upperLimit = 100;
        int magicKey = randomNumber.Next(lowerLimit,upperLimit + 1);

        Console.Clear();
        while (magicNumber != magicKey)
        {
            Console.Write("What is the magic number? ");
            string magicString = Console.ReadLine();
            magicNumber = int.Parse(magicString);  //unser string input parsed to an integer
            if (magicNumber > upperLimit) 
            {
                Console.WriteLine("Out of bounds!");
                Console.WriteLine("Prest anykey to continue.");
                Console.ReadKey();
                Console.Clear();    
            }
            else if (magicNumber < lowerLimit) 
            {
                Console.WriteLine("Out of bounds!");
                Console.WriteLine("Prest anykey to continue.");
                Console.ReadKey();
                Console.Clear();    
            }
            else if (magicNumber < magicKey) 
            {
                Console.WriteLine("HIGHER!");
                Console.WriteLine("Prest anykey to continue.");
                Console.ReadKey();
                Console.Clear();    
            }
            
            else if (magicNumber > magicKey) 
            {
                Console.WriteLine("LOWER!");
                Console.WriteLine("Prest anykey to continue.");
                Console.ReadKey();
                Console.Clear();    
            }            
        
        }
        Console.Clear();
        Console.Write("Winner Winner Chicken Dinner!");


    }
}