using System;
using System.Runtime.InteropServices.Marshalling;

public class SimpleGoal 
{
    protected string _goalType = "SimpleGoal";
    protected string _goal = "";
    protected string _goalDesc = "";
    bool _permanentFlag = false;
    protected int _value;
    protected bool _complete;

    public SimpleGoal() {}
    public SimpleGoal(string goal, string goalDesc, int value, bool complete)
    {
        _goal = goal;
        _goalDesc = goalDesc;
        _value = value;
        _complete = complete;
    }

    public string GetGoalType(){return _goalType;}
    public string GetGoal(){return _goal;}
    public string GetGoalDesc(){return _goalDesc;}
    public int GetValue(){return _value;}
    public bool GetPermFlag(){return _permanentFlag;}
    public bool GetComplete(){return _complete;}
    public void SetValue(int value){_value = value;}
    public void SetComplete(){_complete = true;}
    public void SetPermFlag(){_permanentFlag = true;}

    public virtual string Serialize() 
    {
        return $"{GetGoalType()}-|-{GetGoalDesc()}-|-{GetGoal()}-|-{GetValue()}-|-{GetComplete()}";
    }
    public virtual void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        if (oneOfMyGoals.Length < 5)
            {
                Console.WriteLine("ERROR - Missing line segments, for a SimpleGoal.");
            }
        else
            {
                _goalType = segment[0];
                _goal = segment[1];
                _goalDesc = segment[2];
                _value = Convert.ToInt16(segment[3]);
                _complete = Convert.ToBoolean(segment[4]);
            }
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}]\nGoal Description: {_goalDesc}\n ");
    }

    public static string NewSimpleGoal() 
    {
        Console.Write("What is your goal?\n ==> ");
        string newGoalA = Console.ReadLine();
        Console.Write("Describe your goal?\n ==> ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("What is your goal's value? ");
        int  newGoalValue = int.Parse(Console.ReadLine());
        
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}";
    }
    
}