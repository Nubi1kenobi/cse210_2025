using System;
public class Activity
{
    protected string _introMessage;
    protected string _exitMessage;
    protected int _delay;
    public Activity(string intro, string exit, int delay) {_introMessage = intro; _exitMessage = exit; _delay = delay;}
    public string GetInro() {return $"{_introMessage}" ;}
    public string GetExit() {return $"{_exitMessage}" ;}
}