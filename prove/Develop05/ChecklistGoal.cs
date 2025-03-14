using System;
using System.Reflection.Metadata.Ecma335;
public class ChecklistGoal : SimpleGoal
{
    bool _permanentFlag = true;
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;
    private int _bonusValue = 0;
    public ChecklistGoal() : base() {}
    public ChecklistGoal(string goal, int value, bool complete, int bonusValue, int timesToComplete) : base(goal, value, complete)
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
        return $"{GetGoalType()}-|-{GetGoal()}-|-{GetValue()}-|-{GetTimesCompleted()}-|-{GetTimesToComplete()}-|-{GetComplete()}-|-{GetBonus()}";
    }


    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        if (oneOfMyGoals.Length < 7)
            {
                Console.WriteLine("ERROR - Missing line segments, in ChecklistGoal.Deserialize.");
            }
        else
            {
                _goalType = segment[0];
                _goal = segment[1];
                _value = Convert.ToInt16(segment[2]);  
                _timesToComplete = Convert.ToInt16(segment[3]);
                _timesCompleted = Convert.ToInt16(segment[4]);
                _complete = Convert.ToBoolean(segment[5]);
                _bonusValue = Convert.ToInt16(segment[6]);                
            }
    }
        public override void DisplayGoal()
    {
        Console.WriteLine($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Complete? [{GetComplete()}] | Times Completed [{GetTimesCompleted()}]/[{GetTimesToComplete()}] | Bonus [{GetBonus()}]");
    }
    public static string NewChecklistGoal() 
    {
        Console.Write("What is your goal?\n ==> ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("What is your goal's value? ==> ");
        int  newGoalValue = int.Parse(Console.ReadLine());
        Console.Write("How many times to complete this goal to get the bonus? ==> ");
        int  timesToComplete = int.Parse(Console.ReadLine());
        Console.Write("What is your goal's bonus value? ==> ");
        int  bonus = int.Parse(Console.ReadLine());
        return $"{newGoalDesc}-|-{newGoalValue}-|-{bonus}-|-{timesToComplete}";
    }
// public ChecklistGoal(string goal, int value, bool complete, int bonusValue, int timesToComplete) : base(goal, value, complete)
}