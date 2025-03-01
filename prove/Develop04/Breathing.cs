using System;
public class Breathing : Activity 
{
    private string _textbooksection;
    private int _delay1;
    //private int _delay;
    //public Breathing(string intro, string exit, string section, string problems) : base(intro, exit)
    public Breathing(string intro, string exit, int delay) : base(intro, exit, delay)
    {
        _delay1 = delay;
        StringEater breathingIntro = new StringEater(intro, delay, true);
        RunBreathing();
        StringEater breathingExit = new StringEater(intro, delay, true);
    }   
    public void RunBreathing() 
    {
        Console.Clear();
        StringEater breathingActivity = new StringEater("Commence your Breathing!\n", _delay1, true);
        Utility.PressAnyKey();
    }
    
    
    //{Console.Write($"{_introMessage}\nSection {_exitMessage} Problems {_delay}");}
}