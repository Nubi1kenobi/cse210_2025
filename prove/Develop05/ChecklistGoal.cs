using System;

public class ChecklistGoal : SimpleGoal
{
    bool _permanentFlag = true;
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;
    private int _bonusValue = 0;
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
    public int GetTimeCompleted() {return _timesCompleted;}
    public int GetTimesToComplete() {return _timesToComplete;}
    public int GetBonus() {return _bonusValue;}
    public int GetTimesCompleted(){return _timesCompleted;}

        public override string Serialize() 
    {
        return $"{GetGoalType()}|{GetValue()}|{GetComplete()}|{GetTimesCompleted()}|{GetBonus()}|{GetGoal()}";
    }

    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        string type = "";
        string value = "";
        string complete = "";
        string timesCompleted = "";
        string bonus = "";
        string goal = "";
        if (oneOfMyGoals.Length < 6)
            {
                Console.WriteLine("ERROR - Missing line segments, in ChecklistGoal.Deserialize.");
            }
        else
            {
                type = segment[0];
                value = segment[1];    
                complete = segment[2];
                timesCompleted = segment[3];
                bonus = segment[4];
                goal = segment[5];
            }
    }
}