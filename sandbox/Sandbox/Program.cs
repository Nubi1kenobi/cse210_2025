using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World! - take 2");
        RunWaitingForKeyPressedSample();
    }

 
private static void RunWaitingForKeyPressedSample()
{
    int counter = 0;
    while (!Console.KeyAvailable)
    {
        Thread.Sleep(1000);
        counter++;
        Console.WriteLine("I've been waiting for you to press a key for {0} seconds...", counter);
    }
    Console.WriteLine("Finally...");
}
 
}