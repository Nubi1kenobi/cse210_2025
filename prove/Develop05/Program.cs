using System;
using System.Runtime.Serialization;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        List<String> allGoals = new List<String>{};
        SimpleGoal newGoal = new SimpleGoal("Goal0", 5, false);
        SimpleGoal newGoal1 = new SimpleGoal("Goal1", 15, false);
        SimpleGoal newGoal2 = new SimpleGoal("Goal2", 25, false);
        EternalGoal newGoal3 = new EternalGoal("Goal3", 40, false);
        EternalGoal newGoal4 = new EternalGoal("Goal4", 50, false);
        EternalGoal newGoal5 = new EternalGoal("Goal5", 60, false);
        ChecklistGoal newGoal6 = new ChecklistGoal("Goal6", 40, false, 100, 3);
        ChecklistGoal newGoal7 = new ChecklistGoal("Goal7", 40, false, 100, 5);
        ChecklistGoal newGoal8 = new ChecklistGoal("Goal8", 40, false, 100, 7);

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

        allGoals.Add(newGoal.Serialize());
        allGoals.Add(newGoal1.Serialize());
        allGoals.Add(newGoal2.Serialize());
        allGoals.Add(newGoal3.Serialize());
        allGoals.Add(newGoal4.Serialize());
        allGoals.Add(newGoal5.Serialize());
        allGoals.Add(newGoal6.Serialize());
        allGoals.Add(newGoal7.Serialize());
        allGoals.Add(newGoal8.Serialize());
        
        Console.WriteLine("Serializing Data");
        foreach (string goals in allGoals)
        {
            Console.WriteLine(goals);
        }
        Console.Write("\n");

        List<SimpleGoal> DeSerializedList = new List<SimpleGoal>();

        foreach (string serializedGoal in allGoals)
        {
            
        }

        //string _fileName = Console.ReadLine() + ".txt";
        
    }
}