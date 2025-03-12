using System;
using System.Runtime.InteropServices.Marshalling;

public class SimpleGoal 
{
    protected string _goalType = "SimpleGoal";
    protected string _goal = "";
    protected int _value;
    protected bool _complete;

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

    public virtual string Serialize() 
    {
        return $"{_goalType}|{_goal}|{_complete}|{_value}";
    }
    public virtual void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        string type = "";
        string value = "";
        string complete = "";
        string goal = "";
        if (segment[0] == "SimpleGoal")
        {
            if (oneOfMyGoals.Length < 4)
                {
                    Console.WriteLine("ERROR - Missing line segments, for a SimpleGoal.");
                }
            else
                {
                    type = segment[0];
                    value = segment[1];    
                    complete = segment[2];
                    goal = segment[3];
                }
            return "123";
        }
    }
}