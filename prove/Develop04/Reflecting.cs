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
    
        List<string> thinkOfATime = new List<string> 
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless."
        };
        List<String> questions = new List<string>
        {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?", 
            "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
        };
        CountTo10 countDown = new CountTo10();
        int random1 = Randomizer.RandomInt((thinkOfATime.Count()));
        Console.Clear();
        StringEater thinkOfATimePrompt = new StringEater($" ==> {thinkOfATime[random1]} <== \n\n When you have something in mind...\n\n",_textDelay,true); 
        Utility.PressAnyKey();
        Console.Clear();
        StringEater reflectingActivity = new StringEater("Prepare Yourself to Reflect! ==> ", 15, true);
        countDown.CountDownInPlace(0, 3);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(_userPrompt));
        while (DateTime.Now < endTime)
        {
            int random2 = Randomizer.RandomInt(questions.Count()-1);
            StringEater questionsAsking = new StringEater($"{questions[random2]} ==> ", 0, true);
            countDown.CountDownInPlace(0,10);
            Console.Clear();
        }

        Console.Clear();
        StringEater concludeActivity = new StringEater($"Fantastico!\n\nThis concludes our activity, you have completed {_userPrompt} seconds of the {_activity} Activity.\n",_textDelay,true);
        Thread.Sleep(_messageDelay);
        StringEater concludeActivity1 = new StringEater("We must always remember to take a pause and reflect on our blessings every day.\n",_textDelay,true);
        Utility.PressAnyKey();
    }  
}