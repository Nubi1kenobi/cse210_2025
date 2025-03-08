using System;
public class Listing : Activity 
{    
    public Listing() : base()
    {
        _activity = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        WelcomeMsg();
        RunListing();
    }   
    public void RunListing() 
    {
        string userResponse = "_";
        Console.Clear();
        List<string> whoAre = new List<string> 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?."
        };
        List<String> userResponseList = new List<string>{};
        CountTo10 countDown = new CountTo10();
        int random1 = Randomizer.RandomInt((whoAre.Count()));
        StringEater reflectingActivity = new StringEater("Prepare Yourself to to List! ==> ", 15, true);
        countDown.CountDownInPlace(0, 3);
        Console.Clear();
        StringEater thinkOfATimePrompt = new StringEater($" ==> {whoAre[random1]} <== \n",_textDelay,true); 
        Console.Write("\n");
        StringEater arrow = new StringEater("==> ", true);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(_userPrompt));
        while (DateTime.Now < endTime)
        {
            userResponse = Console.ReadLine();
            userResponseList.Add(userResponse);
            StringEater arrow1 = new StringEater("==> ", true);           
        }
        Console.Clear();
        StringEater concludeActivity = new StringEater($"¡Qué chingón!\n\nThis concludes our activity, you have completed {_userPrompt} seconds of the {_activity} Activity.\n",_textDelay,true);
        Thread.Sleep(_messageDelay);
        StringEater concludeActivity1 = new StringEater("Sometimes it takes listing things out to see how truly blessed we are!\n\nPlease review your listing items and then press any key to go back to the main menu.\n",_textDelay,true);
        foreach (string lineItem in userResponseList) {StringEater UserList = new StringEater($"{lineItem} \n", true);} 
        Console.Write("\n");
        Utility.PressAnyKey();
    }
}