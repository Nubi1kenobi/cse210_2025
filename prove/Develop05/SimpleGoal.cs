using System;
using System.Runtime.InteropServices.Marshalling;
//the other two goal classes are derived from this class.
public class SimpleGoal 
{
    protected string _goalType = "SimpleGoal";
    protected string _goal = "";
    protected string _goalDesc = "";
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
    public bool GetComplete(){return _complete;}
    public virtual void Increment(){SetComplete();}
    public void SetValue(int value){_value = value;}
    public void SetComplete(){_complete = true;}
    public virtual string Serialize() 
    {
        return $"{GetGoalType()}-|-{GetGoal()}-|-{GetGoalDesc()}-|-{GetValue()}-|-{GetComplete()}";
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
        StringEater displayGoal = new StringEater($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}]\nGoal Description: {GetGoalDesc()}\n ", 0, true);
    }
    //this is that static class I mentioned. Each goal class has its own.
    public static string NewSimpleGoal() 
    {
        StringEater simpleGoal0 = new StringEater("What is your new Simple Goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalA = Console.ReadLine();
        StringEater simpleGoal1 = new StringEater("Describe your goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalDesc = Console.ReadLine();
        StringEater simpleGoal2 = new StringEater("What is your goal's value? ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int  newGoalValue = int.Parse(Console.ReadLine());
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}"; //it is serialized back to the person created
    }                                                          //from the person class. All three goal classes
}                                                              //has their own different - yet similar static class.
    
    
