using System;
public class Reflecting : Activity 
{
   public Reflecting() : base()
    {
        _activity = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        WelcomeMsg();
        RunReflecting(); 
    }   
    public void RunReflecting() 
    {
        Console.Clear();
        StringEater reflectingActivity = new StringEater("Commence your Reflecting!\n", 15, true);
        Thread.Sleep(_messageDelay);
        //We must always remember to take a pause and reflect on our blessings every day.
    }  
}