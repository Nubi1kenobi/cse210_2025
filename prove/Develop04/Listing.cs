using System;
public class Listing : Activity 
{
    private int _delay1;

    public Listing(string intro, string exit, int delay) : base(intro, exit, delay)
    {
        _delay = delay;
        StringEater reflectingIntro = new StringEater(intro, delay, true);
        Utility.PressAnyKey();
        RunListing();
        StringEater reflectingExit = new StringEater(exit, delay, true);
        Utility.PressAnyKey();
    }   
    public void RunListing() 
    {
        Console.Clear();
        StringEater reflectingActivity = new StringEater("Commence your Listing!\n", _delay, true);
        Utility.PressAnyKey();
    }
}