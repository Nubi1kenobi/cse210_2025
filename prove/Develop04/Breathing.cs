using System;
public class Breathing : Activity 
{

    public Breathing() : base()
    {
        _activity = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nThis breathing pattern is 4-7-8 breathing.\nPlease get yourself in a comfortable sitting position and place the tip of the tongue on the tissue right behind the top front teeth.\n - Each activity is appoximately 19 seconds.\n\nIt is recommended not to do this breathing pattern more than 4 times in a row.";
        _howLong = "How many times would you like to repeat the breathing pattern?";
        WelcomeMsg(); 
        RunBreathing(); //refernce::https://www.medicalnewstoday.com/articles/324417#how-to-do-it
    }   
    public void RunBreathing() 
    {
        Console.Clear();
        int limit = int.Parse(_userPrompt);
        if (limit < 1) {limit = 1;}
        if (limit > 5 ) {limit = 5;}
        Run_4_7_8_Breathing(limit);
    }  

    private void Run_4_7_8_Breathing(int parameter)
    {
        int limit = parameter;
        Console.Clear();
        StringEater introActivity = new StringEater("Please start by emptying your lungs of air.\n\n",0,true);
        introActivity.Vibrance("<Press Any Key to Begin>", 10, 0);
        Console.Clear();
        for (int i = 1; i < limit + 1; i++)
        {  
            StringEater x478 = new StringEater("Breath in thorugh your nose for 4 seconds ==> ",0,true);
            CountTo10 uno = new CountTo10();
            uno.CountDownInPlace(0, 4);
            Console.Clear();
            StringEater y478 = new StringEater("Hold your breath for 7 seconds ==> ",0,true);
            CountTo10 dos = new CountTo10();
            dos.CountDownInPlace(0, 7);
            Console.Clear();
            StringEater z478 = new StringEater("Exhail forcefully for 8 seconds, you might make a 'whoosh' sound ==> ",0,true);
            CountTo10 tres = new CountTo10();
            tres.CountDownInPlace(0, 8);
            Console.Write("\n");
            Console.Clear();
        }
        Console.Clear();
        StringEater endActivity = new StringEater($"Very nice!\n\nThis concludes our activity, I hope you are feeling more relaxed, because you completed {limit * 19} seconds of breathing.\n",_textDelay,true);
        Thread.Sleep(2500);
        StringEater endActivity1 = new StringEater("Remember to ",_textDelay,true);
        StringEater endActivity2 = new StringEater("slow down and breath.",_textDelay+250,true);
        StringEater endActivity3 = new StringEater(" Thank you for sharing your time with us.\n\n",_textDelay,true);
        Utility.PressAnyKey();
    }
}