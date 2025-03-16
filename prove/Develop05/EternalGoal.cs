using System;
public class EternalGoal : SimpleGoal
{
    private int _timesCompleted = 0;
    public EternalGoal() : base() {}
    public EternalGoal(string goal, string goalDesc, int value, bool complete) : base(goal, goalDesc, value, complete){SetGoalType();}
    public int GetTimesCompleted(){return _timesCompleted;}
    public void SetGoalType(){_goalType = "EternalGoal";}
    public override void Increment(){_timesCompleted++;}
    public override string Serialize() {return $"{GetGoalType()}-|-{GetGoal()}-|-{GetGoalDesc()}-|-{GetValue()}-|-{GetTimesCompleted()}-|-{GetComplete()}";}
    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");       
        if (oneOfMyGoals.Length < 6) {Console.WriteLine("ERROR - Missing line segments, in EternalGoal.Deserialize.");}
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
        StringEater displayGoal = new StringEater($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Times Completed [{GetTimesCompleted()}]\nGoal Description: {GetGoalDesc()}\n ", 0 , true);
    }  
    public static string NewEternalGoal() 
    {
        StringEater eternalGoal0 = new StringEater("What is your new Eternal Goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalA = Console.ReadLine();
        StringEater eternalGoal1 = new StringEater("Describe your goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalDesc = Console.ReadLine();
        StringEater eternalGoal2 = new StringEater("What is your goal's value? ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int  newGoalValue = int.Parse(Console.ReadLine());
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}";
    }
}