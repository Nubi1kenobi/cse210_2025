using System;

public class SimpleGoal 
{
    protected string _goalType = "SimpleGoal";
    private string _goal = "";
    private int _value;
    private bool _complete;

    public SimpleGoal(string goal, int value, bool complete)
    {
        _goal = goal;
        _value = value;
        _complete = complete;
    }

    public string GetGoalType(){return _goalType;}
    public string GetGoal(){return _goal;}
    public int GetValue(){return _value;}
    public bool GetComplete(){return _complete;}
    public void SetValue(int value){_value = value;}
    public void SetComplete(){_complete = true;}


}