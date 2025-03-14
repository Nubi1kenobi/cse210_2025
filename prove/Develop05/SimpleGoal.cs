using System;
using System.Runtime.InteropServices.Marshalling;

public class SimpleGoal 
{
    protected string _goalType = "SimpleGoal";
    protected string _goal = "";
    protected int _value;
    protected bool _complete;

    public SimpleGoal() {}
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
        return $"{GetGoalType()}-|-{GetGoal()}-|-{GetValue()}-|-{GetComplete()}";
    }
    public virtual void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        if (oneOfMyGoals.Length < 4)
            {
                Console.WriteLine("ERROR - Missing line segments, for a SimpleGoal.");
            }
        else
            {
                _goalType = segment[0];
                _goal = segment[1];
                _value = Convert.ToInt16(segment[2]);
                _complete = Convert.ToBoolean(segment[3]);
            }
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Complete? [{GetComplete()}]");
    }

    public static string NewSimpleGoal() 
    {
        Console.Write("What is your goal?\n ==> ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("What is your goal's value? ==> ");
        int  newGoalValue = int.Parse(Console.ReadLine());
        
        return $"{newGoalDesc}-|-{newGoalValue}";
    }
    
}