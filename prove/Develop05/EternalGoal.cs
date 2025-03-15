using System;
public class EternalGoal : SimpleGoal
{
    private int _timesCompleted = 0;
    public EternalGoal() : base() {}
    public EternalGoal(string goal, string goalDesc, int value, bool complete) : base(goal, goalDesc, value, complete)
    {
        SetGoalType();
        SetPermFlag();
    }
    public void SetGoalType(){_goalType = "EternalGoal";}
    public void Increment(){_timesCompleted++;}
    public int GetTimesCompleted(){return _timesCompleted;}

    public override string Serialize() 
    {
        return $"{GetGoalType()}-|-{GetGoal()}-|-{GetGoalDesc()}-|-{GetValue()}-|-{GetTimesCompleted()}";
    }
    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");       
        if (oneOfMyGoals.Length < 5)
            {
                Console.WriteLine("ERROR - Missing line segments, in EternalGoal.Deserialize.");
            }
        else
            {   
                _goalType = segment[0];
                _goal = segment[1];
                _goalDesc = segment[2];
                _value = Convert.ToInt16(segment[3]);   
                _timesCompleted = Convert.ToInt16(segment[4]);             
            }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Times Completed [{GetTimesCompleted()}]\nGoal Description: {_goalDesc}\n ");
    }
    
    public static string NewEternalGoal() 
    {
        Console.Write("What is your goal?\n ==> ");
        string newGoalA = Console.ReadLine();
        Console.Write("Describe your goal?\n ==> ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("What is your goal's value? ==> ");
        int  newGoalValue = int.Parse(Console.ReadLine());
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}";
    }



}