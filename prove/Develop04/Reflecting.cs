using System;
public class Reflecting : Activity 
{
    private int _delay1;

    //public Reflecting(string intro, string exit, string title) : base(intro, exit)
    public Reflecting(string intro, string exit, int delay) : base(intro, exit, delay)
    {
        _delay1 = delay;
        StringEater reflectingIntro = new StringEater(intro, delay, true);
        RunRefelcting();
        StringEater reflectingExit = new StringEater(intro, delay, true);
    }   
    public void RunRefelcting() 
    {
        Console.Clear();
        StringEater reflectingActivity = new StringEater("Commence your Reflecting!\n", _delay1, true);
        Utility.PressAnyKey();
    }
}