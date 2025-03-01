using System;
public class Activity
{
    protected string _introMessage;
    protected string _activityMessage;
    protected string _exitMessage;
    protected int _messageDelay = 1500;
    protected int _textDelay;
    public Activity(string intro, string exit, int messageDelay, int textDelay) 
    {
        _introMessage = intro; 
        _exitMessage = exit; 
        _messageDelay = messageDelay;
        _textDelay = textDelay;
    }
    protected void RunActivity()
    {
        Console.WriteLine("Base Activity Running.");
    }
}