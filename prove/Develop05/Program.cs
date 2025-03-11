using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        List<SimpleGoal> allGoals = new List<SimpleGoal>{};
        SimpleGoal newGoal = new SimpleGoal("Goal0", 5, false);
        allGoals.Add(newGoal);
        SimpleGoal newGoal1 = new SimpleGoal("Goal1", 15, false);
        allGoals.Add(newGoal1);
        SimpleGoal newGoal2 = new SimpleGoal("Goal2", 25, false);
        allGoals.Add(newGoal2);
        
        EternalGoal newGoal3 = new EternalGoal("Goal3", 40, false);
        allGoals.Add(newGoal3);
        EternalGoal newGoal4 = new EternalGoal("Goal4", 50, false);
        allGoals.Add(newGoal4);
        EternalGoal newGoal5 = new EternalGoal("Goal5", 60, false);
        allGoals.Add(newGoal5);
        Console.Clear();

        ChecklistGoal newGoal6 = new ChecklistGoal("Goal6", 40, false, 100, 3);
        allGoals.Add(newGoal6);
        ChecklistGoal newGoal7 = new ChecklistGoal("Goal7", 40, false, 100, 5);
        allGoals.Add(newGoal7);
        ChecklistGoal newGoal8 = new ChecklistGoal("Goal8", 40, false, 100, 7);
        allGoals.Add(newGoal8);
        
        foreach (SimpleGoal goals in allGoals)
        {
            if (goals is ChecklistGoal checklistGoal) // Type checking
                {
                    Console.WriteLine($"{checklistGoal.GetGoalType()} - {checklistGoal.GetGoal()} - {checklistGoal.GetValue()} - {checklistGoal.GetComplete()} - {checklistGoal.GetBonus()} - {checklistGoal.GetTimeCompleted()} - {checklistGoal.GetTimesToComplete()}");
                }
            {Console.WriteLine($"{goals.GetGoalType()} - {goals.GetGoal()} - {goals.GetValue()} - {goals.GetComplete()}");}
        }
        Console.Write("\n");

        newGoal6.Increment();
        newGoal6.Increment();
        newGoal6.Increment();
        newGoal7.Increment();
        newGoal7.Increment();
        newGoal7.Increment();
        newGoal7.Increment();
        newGoal8.Increment();
        newGoal8.Increment();
        newGoal8.Increment();
        newGoal8.Increment();
        newGoal8.Increment();
        newGoal8.Increment();

        foreach (SimpleGoal goals in allGoals)
        {
            if (goals is ChecklistGoal checklistGoal) // Type checking
                {
                    Console.WriteLine($"{checklistGoal.GetGoalType()} - {checklistGoal.GetGoal()} - {checklistGoal.GetValue()} - {checklistGoal.GetComplete()} - {checklistGoal.GetBonus()} - {checklistGoal.GetTimeCompleted()} - {checklistGoal.GetTimesToComplete()}");
                }
            {Console.WriteLine($"{goals.GetGoalType()} - {goals.GetGoal()} - {goals.GetValue()} - {goals.GetComplete()}");}
        }
        Console.Write("\n");


    }
}