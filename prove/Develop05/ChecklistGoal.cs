using System;
using System.Reflection.Metadata.Ecma335;
public class ChecklistGoal : SimpleGoal
{
    
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;
    private int _bonusValue = 0;
    public ChecklistGoal() : base() {}
    public ChecklistGoal(string goal, string goalDesc, int value, bool complete, int bonusValue, int timesToComplete) : base(goal, goalDesc, value, complete)
    {
        SetGoalType();
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;

    }
    public void SetGoalType(){_goalType = "ChecklistGoal";}
    public void Increment(){_timesCompleted++; BonusChecker();}
    public void BonusChecker()
    {
        if (_timesCompleted == _timesToComplete) 
        {
            SetComplete();
        }
    }
    public int GetTimesToComplete() {return _timesToComplete;}
    public int GetBonus() {return _bonusValue;}
    public int GetTimesCompleted(){return _timesCompleted;}
    public override string Serialize() 
    {
        return $"{GetGoalType()}-|-{GetGoal()}-|-{GetGoalDesc()}-|-{GetValue()}-|-{GetTimesCompleted()}-|-{GetTimesToComplete()}-|-{GetComplete()}-|-{GetBonus()}";
    }


    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        if (oneOfMyGoals.Length < 8)
            {
                Console.WriteLine("ERROR - Missing line segments, in ChecklistGoal.Deserialize.");
            }
        else
            {
                _goalType = segment[0];
                _goal = segment[1];
                _goalDesc = segment[2];
                _value = Convert.ToInt16(segment[3]);  
                _timesCompleted = Convert.ToInt16(segment[4]);
                _timesToComplete = Convert.ToInt16(segment[5]);
                _complete = Convert.ToBoolean(segment[6]);
                _bonusValue = Convert.ToInt16(segment[7]);                
            }
    }
        public override void DisplayGoal()
    {
        Console.WriteLine($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Times Completed [{GetTimesCompleted()}]/[{GetTimesToComplete()}] | Bonus [{GetBonus()}]\nGoal Description: {_goalDesc}\n ");
    }
    public static string NewChecklistGoal() 
    {
        Console.Write("What is your goal?\n ==> ");
        string newGoalA = Console.ReadLine();
        Console.Write("Describe your goal?\n ==> ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("What is your goal's value? ==> ");
        int  newGoalValue = int.Parse(Console.ReadLine());
        Console.Write("How many times to complete this goal to get the bonus? ==> ");
        int  timesToComplete = int.Parse(Console.ReadLine());
        Console.Write($"What is your goal's bonus value for completing the goal {timesToComplete} times? ");
        int  bonus = int.Parse(Console.ReadLine());
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}-|-{bonus}-|-{timesToComplete}";
    }
// public ChecklistGoal(string goal, int value, bool complete, int bonusValue, int timesToComplete) : base(goal, value, complete)
}