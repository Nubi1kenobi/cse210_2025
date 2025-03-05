using System;
public class Activity
{
    protected string _activity = "Base";
    protected string _activityDescription = "";
    protected string _howLong = "How long, in seconds, would you like for your session?";
    protected int _messageDelay = 1500;
    public int _textDelay = 10;    
    protected string _userPrompt;
    public Activity() 
    {    }
    protected void WelcomeMsg()
    {
        StringEater welcomeMessage = new StringEater($"Welcome to the {_activity} Activity\n", _textDelay, true);
        Thread.Sleep(1500);
        StringEater activityDesctription = new StringEater($"{_activityDescription}\n\n", _textDelay, true);
        Thread.Sleep(1500);
        StringEater howLong = new StringEater($"{_howLong} ", _textDelay, true);
        _userPrompt = Console.ReadLine();
    }
}