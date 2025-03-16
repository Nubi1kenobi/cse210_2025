using System;
using System.Reflection.Metadata.Ecma335;
public class ChecklistGoal : SimpleGoal
{   
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;
    private int _bonusValue = 0;
    public ChecklistGoal() : base() {}
    // the notes by each parameter was to help me keep everything straight. I got them confused a few times, it caused a bunch of problems.
    public ChecklistGoal(string goal /*newGoalA*/, string goalDesc /*newGoalDesc*/, int value /*newGoalValue*/, bool complete /*false*/, int bonusValue /*bonus*/, int timesToComplete /*timesToComplete*/) : base(goal, goalDesc, value, complete)
    {
        SetGoalType();
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;
    }
    public void SetGoalType(){_goalType = "ChecklistGoal";}
    public override void Increment()
    {
        _timesCompleted++;
        BonusChecker(); 
    }   
    public void BonusChecker()
    {
        if (_timesCompleted == _timesToComplete) 
        {
            SetComplete();
        }
    }
    public int GetTimesToComplete() {return _timesToComplete;}
    public int GetTimesCompleted(){return _timesCompleted;}
    public int GetBonus() {return _bonusValue;}
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
        StringEater displayGoal = new StringEater($"{GetGoalType()}: {GetGoal()} | Value [{GetValue()}] | Times Completed [{GetTimesCompleted()}]/[{GetTimesToComplete()}] | Bonus [{GetBonus()}]\nGoal Description: {GetGoalDesc()}\n ", 0, true);
    }
    public static string NewChecklistGoal() 
    {
        StringEater checklistGoal0 = new StringEater("What is your new Checklist Goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalA = Console.ReadLine();
        StringEater checklistGoal1 = new StringEater("Describe your goal?\n ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        string newGoalDesc = Console.ReadLine();
        StringEater checklistGoal2 = new StringEater("What is your goal's value? ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int  newGoalValue = int.Parse(Console.ReadLine());
        StringEater checklistGoal3 = new StringEater("How many times to complete this goal to get the bonus? ==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int  timesToComplete = int.Parse(Console.ReadLine());
        StringEater checklistGoal4 = new StringEater($"What is your goal's bonus value for completing the goal {timesToComplete} times? ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int  bonus = int.Parse(Console.ReadLine());
        return $"{newGoalA}-|-{newGoalDesc}-|-{newGoalValue}-|-{bonus}-|-{timesToComplete}";
    }
}