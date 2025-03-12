using System;

public class EternalGoal : SimpleGoal
{
    bool _permanentFlag = true;
    private int _timesCompleted = 0;
    public EternalGoal(string goal, int value, bool complete) : base(goal, value, complete)
    {
        SetGoalType();
    }
    public void SetGoalType(){_goalType = "EternalGoal";}
    public void Increment(){_timesCompleted++;}
    public bool GetPermanantFlag(){return _permanentFlag;}
    public int GetTimesCompleted(){return _timesCompleted;}

        public override string Serialize() 
    {
        return $"{_goalType}|{_goal}|{_complete}|{_value}";
        return $"{GetGoalType()}|{GetValue()}|{GetComplete()}|{GetTimesCompleted()}|{GetPermanantFlag()}|{GetGoal()}";
    }
    public override void Deserialize(string oneOfMyGoals)
    {
        string[] segment = oneOfMyGoals.Split("-|-");
        string type = "";
        string value = "";
        string complete = "";
        string goal = "";
        string timesCompleted = "";
        string permanentFlag = "";
        if (oneOfMyGoals.Length < 6)
            {
                Console.WriteLine("ERROR - Missing line segments, in EternalGoal.Deserialize.");
            }
        else
            {
                type = segment[0];
                value = segment[1];    
                complete = segment[2];
                timesCompleted = segment[3];
                permanentFlag = segment[4];
                goal = segment[5];
            }
    }

    



}