using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int magicNumber;
        int magicKey = -1;
        int iterationSum = 0;
        int largestNumber = 0;
        int smallestPositiveInt = 0;

        Console.Clear();
        List<int> intList = new List<int>();
        
        while (magicKey != 0)
        {
            Console.WriteLine("Please enter a list of numbers, type 0 when finished.");
            string magicString = Console.ReadLine();
            magicNumber = int.Parse(magicString);  //unser string input parsed to an integer
            if (magicNumber == 0) 
            {
                int i = 0;
                foreach (int sumIntegers in intList)
                {
                    iterationSum = sumIntegers + iterationSum;
                    if (i == 0) {largestNumber = sumIntegers; smallestPositiveInt = sumIntegers;}
                    else if (i > 1) 
                    {
                        if (sumIntegers > largestNumber) { largestNumber = sumIntegers;}
                        if (sumIntegers > 0 && sumIntegers < smallestPositiveInt) {smallestPositiveInt = sumIntegers;}
                    }
                    i++;
                }
                Console.Clear();
                Console.WriteLine($"The sum is {iterationSum}");
                Console.WriteLine($"The average is {intList.Average()}");
                Console.WriteLine($"The largest number is {largestNumber}");
                Console.WriteLine($"The smallest positive number is {smallestPositiveInt}");
                intList.Sort();
                foreach (int sumIntegers in intList)
                {
                    Console.WriteLine(sumIntegers);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("<press any key to exit>");
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(0);
            }
            intList.Add(magicNumber);
            Console.Clear();
        }
                       
        foreach (int sumIntegers in intList)
        {
            iterationSum = sumIntegers + iterationSum;
        }
        
        
    }
}