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
    



}