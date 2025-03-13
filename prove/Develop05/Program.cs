using System;
using System.Runtime.Serialization;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("Creating a Serialized List, Creating Goals, Serializing Them, Incrementing Some of Them, Adding them to the List");
        Console.Write("\n<Press any key to continue>\n");
        Console.ReadKey();

        List<String> serializedGoals = new List<String>{};
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

        serializedGoals.Add(newGoal.Serialize());
        serializedGoals.Add(newGoal1.Serialize());
        serializedGoals.Add(newGoal2.Serialize());
        serializedGoals.Add(newGoal3.Serialize());
        serializedGoals.Add(newGoal4.Serialize());
        serializedGoals.Add(newGoal5.Serialize());
        serializedGoals.Add(newGoal6.Serialize());
        serializedGoals.Add(newGoal7.Serialize());
        serializedGoals.Add(newGoal8.Serialize());

        Console.WriteLine("Displaying the Serialized List");     
        Console.Write("\n<Press any key to continue>\n");
        
        foreach (string goals in serializedGoals)
        {
            Console.WriteLine(goals);
        }
        
        Console.Write("\n<Press any key to continue>\n");
        Console.ReadKey();
        Console.Clear();
        
        Console.WriteLine("De-serializing the Serialized List and Creating a New SimpleGoalList form the Deserialized Data");

        List<SimpleGoal> DeSerializedList = new List<SimpleGoal>();
        foreach (string serializedGoal in serializedGoals)
        {
            string[] segment = serializedGoal.Split("-|-");
            Console.WriteLine($"Debugging Main, Splitting Serialized Line, Checking It, Then Deserializing: {segment[0]}");
            if (segment[0] == "SimpleGoal")
            {
                SimpleGoal deSerializedGoal = new SimpleGoal(); 
                deSerializedGoal.Deserialize(serializedGoal);
                DeSerializedList.Add(deSerializedGoal);
            }
            if (segment[0] == "EternalGoal")
            {
                EternalGoal deSerializedGoal = new EternalGoal(); 
                deSerializedGoal.Deserialize(serializedGoal);
                DeSerializedList.Add(deSerializedGoal);
            }
            if (segment[0] == "ChecklistGoal")
            {
                ChecklistGoal deSerializedGoal = new ChecklistGoal(); 
                deSerializedGoal.Deserialize(serializedGoal);
                DeSerializedList.Add(deSerializedGoal);
            }           
        }  
        Console.Write("\n<Press any key to continue>\n");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Displaying the De-serialized Data");     
        foreach (SimpleGoal goal in DeSerializedList){goal.DisplayGoal();}

        Console.WriteLine("The End");     
        Console.Write("\n<Press any key to continue>\n");
        Console.ReadKey();
        Console.Clear();

        //string _fileName = Console.ReadLine() + ".txt";
        
    }
}