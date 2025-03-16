using System;
using System.Runtime.CompilerServices;

class Person
{
    private string _lName = "";
    private string _fName = "";
    private string _fileName = "";
    private int _score = 50;
    private string _mainMenuSelector = "";
    private string _mainMenuOptions = "01234" ;
    int _menuDelay = 10;
    List<SimpleGoal> thisPersonsGoals = new List<SimpleGoal>();
    List<SimpleGoal> thisPersonsCompletedGoals = new List<SimpleGoal>();
    public Person() 
    {
        bool looptyLoop = true;
        Console.Clear();
        string introMessage = "Welcome to your Eternal Quest!\n\nPlease follow the next couple of prompts;\nthis determines how everything is saved.\n\n";
        StringEater intoMessageBling = new StringEater(introMessage, _menuDelay ,true);
        StringEater intoMessageBling2 = new StringEater("What is you first name? ", _menuDelay,true);
        Console.ForegroundColor = ConsoleColor.White;
        _fName = Console.ReadLine();
        StringEater intoMessageBling3 = new StringEater("What is you last name? ", _menuDelay,true);
        Console.ForegroundColor = ConsoleColor.White;
        _lName = Console.ReadLine();
        _fileName = $"{_fName}.{_lName}.txt";
        _fileName = _fileName.Trim().ToLower();
        if (File.Exists(_fileName)) 
        {
            Console.Clear();
            StringEater intoMessageBling4 = new StringEater($"\nYour filename ", _menuDelay,true);
            StringEater intoMessageBling5 = new StringEater($"{_fileName} ", _menuDelay,false);
            StringEater intoMessageBling6 = new StringEater($"has been found.", _menuDelay,true);
            Thread.Sleep(2500);
            Console.Clear(); 
            LoadMyFile();
        } 
        else 
        {
            Console.Clear();
            StringEater intoMessageBling4 = new StringEater($"\nYour filename ", _menuDelay,true);
            StringEater intoMessageBling5 = new StringEater($"{_fileName} ", _menuDelay,false);
            StringEater intoMessageBling6 = new StringEater($"was not been found.\n\n", _menuDelay,true);
            StringEater intoMessageBling7 = new StringEater($"{_fileName} ", _menuDelay,false);
            StringEater intoMessageBling8 = new StringEater($"has been created.\n", _menuDelay,true);
            Thread.Sleep(2500);
            Console.Clear(); 
            for (int i = 0; i < 2; i++)
            {
                StringEater intoMessageBling9 = new StringEater("<CREATING YOUR FILE>.",35,true);
                StringEater intoMessageBling0 = new StringEater(".......",250,true);
                Console.Clear();
            }
            SaveMyFile();
        }
       do
       {
            string mainMenuMessage = "Your Eternal Quest begins now!";
            Console.Clear();
            StringEater menuMessage = new StringEater($"{mainMenuMessage}\n", _menuDelay ,true);
            Menu mainMenu = new Menu(_score, "Add a New Goal","Record Event","Display Current Goals","Display Completed Goals");
            _mainMenuSelector = menuMessage.MenuVibrance(" <== Please Make a Selection ==> ", 10, 0, _mainMenuOptions); //(string, character delay, charactor position resets to...)
            MainMenuOptions(_mainMenuSelector, _menuDelay);
            if (_mainMenuSelector == "0") {looptyLoop = false;}
       } while (looptyLoop);
    }
    private void AddGoal() //Temporary Class
    {
        NewSimpleGoal();
        NewEternalGoal();
        NewChecklistGoal();
    } 
     private void LoadMyFile() 
     {
        thisPersonsGoals.Clear();
        Console.Clear(); 
        for (int i = 0; i < 2; i++)
        {
            StringEater intoMessageBling9 = new StringEater("<LOADING>.",35,true);
            StringEater intoMessageBling0 = new StringEater(".......",250,true);
            Console.Clear(); 
        }
        string[] fileLines = File.ReadAllLines(_fileName);  
        foreach (string fileLine in fileLines)
        {
            string[] segment = fileLine.Split("-|-");
            if (segment[0] == "SimpleGoal")
            {
                SimpleGoal deSerializedGoal = new SimpleGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                if (segment[4] == "false"){thisPersonsGoals.Add(deSerializedGoal);}
                else {thisPersonsCompletedGoals.Add(deSerializedGoal);}
            }
            if (segment[0] == "EternalGoal")
            {
                EternalGoal deSerializedGoal = new EternalGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                if (segment[5] == "false"){thisPersonsGoals.Add(deSerializedGoal);}
                else {thisPersonsCompletedGoals.Add(deSerializedGoal);}
            }
            if (segment[0] == "ChecklistGoal")
            {
                ChecklistGoal deSerializedGoal = new ChecklistGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                if (segment[6] == "false"){thisPersonsGoals.Add(deSerializedGoal);}
                else {thisPersonsCompletedGoals.Add(deSerializedGoal);}
            }          
        }  
    }
    private void SaveMyFile() {using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) { _outputFile.WriteLine("");}}
    private void SaveMyFile(SimpleGoal newGoal) {using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) { _outputFile.WriteLine(newGoal.Serialize());}}
    private void NewSimpleGoal()
    {
        string aSimpleGoal = SimpleGoal.NewSimpleGoal();
        string[] segment = aSimpleGoal.Split("-|-");   
        SimpleGoal newGoal = new SimpleGoal(segment[0], segment[1], Convert.ToInt16(segment[2]), false);
        SaveMyFile(newGoal);
    }
    private void NewEternalGoal()
    {
        string anEternalGoal = EternalGoal.NewEternalGoal();
        string[] segment = anEternalGoal.Split("-|-");   
        EternalGoal newGoal = new EternalGoal(segment[0], segment[1], Convert.ToInt16(segment[2]), false);
        SaveMyFile(newGoal);
    }
    private void NewChecklistGoal()
    {
        string aChecklist = ChecklistGoal.NewChecklistGoal();
        string[] segment = aChecklist.Split("-|-");   
        ChecklistGoal newGoal = new ChecklistGoal(segment[0],  segment[1], Convert.ToInt16(segment[2]), false, Convert.ToInt16(segment[2]), Convert.ToInt16(segment[3]));
        SaveMyFile(newGoal);
    }
    private void DisplayMyGoals()
    {
        Console.Clear();
        StringEater displayCCurrentGoals = new StringEater("Here are your current goals:\n", 10, true);
        foreach (SimpleGoal goal in thisPersonsGoals)
        {
            goal.DisplayGoal();
            Utility.PressAnyKey();
        }
    }
    private void DisplayMyCompletedGoals()
    {
        Console.Clear();
        StringEater displayCompletedGoals = new StringEater("Here are your completed goals:\n", 10, true);
        foreach (SimpleGoal goal in thisPersonsCompletedGoals)
        {
            goal.DisplayGoal();
            Utility.PressAnyKey();
        }
    }
    private void MainMenuOptions(string parameterA, int menuDelay)
    {
        string _selector = parameterA;
        switch (_selector)
        {
            case "1":
                AddGoalsMenu(menuDelay);
                return;
            case "2":
                Console.Clear();
                StringEater num2 = new StringEater("Record an Event", 20, true);
                Utility.PressAnyKey();
                return;
            case "3":
                Console.Clear();
                DisplayMyGoals();
                return;                                
            case "4":
                Console.Clear();
                DisplayMyCompletedGoals();
                return;                                
            case "0":
                Playground.Quit();
                return;
            default:
                return;
        }
    }
    private void AddGoalsMenu(int menuDelay)
    {
        string selector = "";
        bool looptyLoop = true;
        string addGoalMenuOptions = "1234" ;
        do
       {
            Console.Clear();
            string addGoalMenuMessage = "What kind of goal would you like to add?";
            StringEater addGoalMenuMessage1 = new StringEater($"{addGoalMenuMessage}\n", menuDelay ,true);
            Menu goalMenu = new Menu("Simple Goal", "EternalGoal Goal", "Checklist Goal", "Return to the Main Menu" );
            selector = addGoalMenuMessage1.MenuVibrance(" <== Please Make a Selection ==> ", 10, 0, addGoalMenuOptions); //(string, character delay, charactor position resets to...)
            if (selector == "4") {looptyLoop = false;}
            AddGoalsMenuOptions(selector, menuDelay);
            
       } while (looptyLoop);
    }
    private void AddGoalsMenuOptions(string parameterA, int menuDelay)
    {
        string selector = parameterA;
        switch (selector)
        {
            case "1":
                Console.Clear();
                NewSimpleGoal();
                return;
            case "2":
                Console.Clear();
                NewEternalGoal();                
                return;
            case "3":
                Console.Clear();
                NewChecklistGoal();
                return;    
            case "4":    
                Console.Clear();
                StringEater addGoalsLeaving = new StringEater("Returning to Main Menu...", 10, true);  // Optional: Debugging message
                Thread.Sleep(1500);                           
            return;
            default:
                return;
        }
    }
}

