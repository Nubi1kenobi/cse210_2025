using System;
public class Breathing : Activity 
{
    
    public Breathing(string intro, string exit, int messageDelay, int textDelay) : base(intro, exit, messageDelay, textDelay)
    {
        StringEater breathingIntro = new StringEater(intro, textDelay, true);
        Thread.Sleep(messageDelay);
        Console.Clear();
        RunBreathing();
        Thread.Sleep(messageDelay);
        Console.Clear();
        StringEater breathingExit = new StringEater(exit, textDelay, true);
        Thread.Sleep(messageDelay);
    }   
    public void RunBreathing() 
    {
        Console.Clear();
        //refernce::https://www.medicalnewstoday.com/articles/324417#how-to-do-it
        StringEater breathingActivity = new StringEater("This breathing pattern is 4-7-8 breathing.\nPlease get yourself in a comfortable sitting position and place the tip of the tongue on the tissue right behind the top front teeth.\nWe will do this excercise 3 times.\n\n", _textDelay, true);
        Utility.PressAnyKey();
        Run_4_7_8_Breathing();
    }  

    private void Run_4_7_8_Breathing()
    {
        Console.Clear();     
        StringEater introActivity = new StringEater("Please start by emptying your lungs of air.\n\n",0,true);
        introActivity.Vibrance("<Press Any Key to Begin>");
        for (int i = 1; i < 4; i++)
        {   
            StringEater x478 = new StringEater("Breath in thorugh your nose for 4 seconds.\n",0,true);
            CountTo10 uno = new CountTo10(1, 5, false, false);
            StringEater y478 = new StringEater("Hold your breath for 7 seconds.\n",0,true);
            CountTo10 dos = new CountTo10(1, 8, false, false);
            StringEater z478 = new StringEater("Exhail forcefully for 8 seconds, you might make a 'whoosh' sound.\n",0,true);
            CountTo10 tres = new CountTo10(1, 9, false, false);
            Console.Clear();
        }
        StringEater endActivity = new StringEater("This concludes our activity, I hope you are feeling more relaxed.\n",0,true);
        Utility.PressAnyKey();
    }
}