using System;
public class Reflecting : Activity 
{
   public Reflecting(string intro, string exit, int messageDelay, int textDelay) : base(intro, exit, messageDelay, textDelay)
    {
        StringEater breathingIntro = new StringEater(intro, textDelay, true);
        Thread.Sleep(messageDelay);
        Console.Clear();
        RunReflecting();
        Thread.Sleep(messageDelay);
        Console.Clear();
        StringEater reflectingExit = new StringEater(exit, textDelay, true);
        Thread.Sleep(messageDelay);
    }   
    public void RunReflecting() 
    {
        Console.Clear();
        StringEater reflectingActivity = new StringEater("Commence your Reflecting!\n", _textDelay, true);
        Thread.Sleep(_messageDelay);
    }  
}