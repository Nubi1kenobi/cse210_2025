using System;
public class Listing : Activity 
{    
    public Listing(string intro, string exit, int messageDelay, int textDelay) : base(intro, exit, messageDelay, textDelay)
    {
        StringEater breathingIntro = new StringEater(intro, textDelay, true);
        Thread.Sleep(messageDelay);
        Console.Clear();
        RunListing();
        Thread.Sleep(messageDelay);
        Console.Clear();
        StringEater listingExit = new StringEater(exit, textDelay, true);
        Thread.Sleep(messageDelay);
    }   
    public void RunListing() 
    {
        Console.Clear();
        StringEater listingActivity = new StringEater("Commence your Listing!\n", _textDelay, true);
        Thread.Sleep(_messageDelay);
    }  
}