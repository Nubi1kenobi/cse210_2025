using System;
using System.Runtime.CompilerServices;

class Person
{
    private string _lName = "";
    private string _fName = "";
    
    private string _fileName = "";
    private int score = 0;
    List<SimpleGoal> thisPersonsGoals = new List<SimpleGoal>();

    public Person() 
    {
        Console.Write("What is you first name? ");
        _fName = Console.ReadLine();
        Console.Write("What is you last name? ");
        _lName = Console.ReadLine();
        _fileName = $"{_fName}.{_lName}.txt";
        _fileName = _fileName.Trim().ToLower();
        Console.WriteLine($"This is your filename: {_fileName}");
        if (File.Exists(_fileName)) {LoadMyFile();}
        else {SaveMyFile();}
        AddGoal();
        LoadMyFile();

        foreach (SimpleGoal goal in thisPersonsGoals)
        {
            goal.DisplayGoal();
        }
    }
    private void AddGoal()
    {
        NewSimpleGoal();
        
//        LoadMyFile();

    }
     
     private void LoadMyFile() 
     {
        thisPersonsGoals.Clear();
        Console.Clear(); 
        Console.Write("Your File is Loading...\n");
        string[] fileLines = File.ReadAllLines(_fileName);  
        foreach (string fileLine in fileLines)
        {
            string[] segment = fileLine.Split("-|-");
            if (segment[0] == "SimpleGoal")
            {
                SimpleGoal deSerializedGoal = new SimpleGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                thisPersonsGoals.Add(deSerializedGoal);
            }
            if (segment[0] == "EternalGoal")
            {
                EternalGoal deSerializedGoal = new EternalGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                thisPersonsGoals.Add(deSerializedGoal);
            }
            if (segment[0] == "ChecklistGoal")
            {
                ChecklistGoal deSerializedGoal = new ChecklistGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                thisPersonsGoals.Add(deSerializedGoal);
            }          
        }  
    }
    private void SaveMyFile() {using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) { _outputFile.WriteLine("");}}
    private void SaveMyFile(SimpleGoal newGoal) {using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) { _outputFile.WriteLine(newGoal.Serialize());}}
    private void NewSimpleGoal()
    {
        string aSimpleGoal = SimpleGoal.NewSimpleGoal();
        string[] segment = aSimpleGoal.Split("-|-");   
        SimpleGoal newGoal = new SimpleGoal(segment[0], Convert.ToInt16(segment[1]), false);
        SaveMyFile(newGoal);
    }
    private void NewEternalGoal()
    {
        string anEternalGoal = EternalGoal.NewEternalGoal();
        string[] segment = anEternalGoal.Split("-|-");   
        EternalGoal newGoal = new EternalGoal(segment[0], Convert.ToInt16(segment[1]), false);
        SaveMyFile(newGoal);
    }
    private void NewChecklistGoal()
    {
        string aChecklist = ChecklistGoal.NewChecklistGoal();
        string[] segment = aChecklist.Split("-|-");   
        ChecklistGoal newGoal = new ChecklistGoal(segment[0], Convert.ToInt16(segment[1]), false, Convert.ToInt16(segment[2]), Convert.ToInt16(segment[3]));
        SaveMyFile(newGoal);
    }


  
}