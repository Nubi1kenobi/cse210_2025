using System;
using System.Runtime.CompilerServices;
class Person
{
    private string _lName = "";
    private string _fName = "";
    private string _fileName = "";
    private int _score = 0;
    private string _mainMenuSelector = "";
    private string _mainMenuOptions = "01234" ;
    int _menuDelay = 10;
    List<SimpleGoal> thisPersonsGoals = new List<SimpleGoal>();
    List<SimpleGoal> thisPersonsCompletedGoals = new List<SimpleGoal>();
    //Person() is where all of the magic happens. Each person has their own file,
    // saves and loads their goals. 
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
            Console.ForegroundColor = ConsoleColor.White;
            StringEater intoMessageBling5 = new StringEater($"{_fileName} ", _menuDelay,false);
            Thread.Sleep(500);
            StringEater intoMessageBling6 = new StringEater($"has been found.", _menuDelay,true);
            Thread.Sleep(800);
            Console.Clear(); 
            LoadMyFile();
        } 
        else 
        {
            Console.Clear();
            StringEater intoMessageBling4 = new StringEater($"\nYour filename ", _menuDelay,true);
            Console.ForegroundColor = ConsoleColor.White;
            StringEater intoMessageBling5 = new StringEater($"{_fileName} ", _menuDelay,false);
            Thread.Sleep(500);
            StringEater intoMessageBling6 = new StringEater($"was not been found.\n\n", _menuDelay,true);
            StringEater intoMessageBling7 = new StringEater($"{_fileName} ", _menuDelay,false);
            StringEater intoMessageBling8 = new StringEater($"has been created.\n", _menuDelay,true);
            Thread.Sleep(800);
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
            string mainMenuMessage = "Your Eternal Quest has begun!";
            Console.Clear();
            StringEater menuMessage = new StringEater($"{mainMenuMessage}\n", _menuDelay ,true);
            Menu mainMenu = new Menu(_score, "Add a New Goal","Record Event","Display Current Goals","Display Completed Goals");
            _mainMenuSelector = menuMessage.MenuVibrance(" <== Please Make a Selection ==> ", 10, 0, _mainMenuOptions); //(string, character delay, charactor position resets to...)
            MainMenuOptions(_mainMenuSelector, _menuDelay);
            if (_mainMenuSelector == "0") {looptyLoop = false;}
       } while (looptyLoop);
    }

    //loading the file happens when an existing user signs in,
    //anytime after a save, including adding goals and recording events.
    //loading is also where the scoring happens.
    //loading also categorizes goals that are complete and incomplete, on two different lists.
    //once the file is loaded, it wipes out the file, so it is important to properly exit the program,
    // not just cut it off while it is doing something. Open up "your" *.txt file and watch it as it progresses through the program.
    private void LoadMyFile() 
    {
        _score = 0;
        thisPersonsGoals.Clear();
        thisPersonsCompletedGoals.Clear();
        Console.Clear(); 
        StringEater intoMessageBling9 = new StringEater("<LOADING>.",35,true);
        StringEater intoMessageBling0 = new StringEater(".......",250,true);
        Console.Clear(); 
        string[] fileLines = File.ReadAllLines(_fileName);  
        foreach (string fileLine in fileLines)
        {
            string[] segment = fileLine.Split("-|-");
            if (segment[0] == "SimpleGoal")
            {
                SimpleGoal deSerializedGoal = new SimpleGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                if (!bool.Parse(segment[4]))
                {
                    thisPersonsGoals.Add(deSerializedGoal);
                }
                else 
                {
                    thisPersonsCompletedGoals.Add(deSerializedGoal);
                    _score = _score + Convert.ToInt16(segment[3]);
                }
            }
            if (segment[0] == "EternalGoal")
            {
                EternalGoal deSerializedGoal = new EternalGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                thisPersonsGoals.Add(deSerializedGoal);
                _score = _score + (Convert.ToInt16(segment[3]) * Convert.ToInt16(segment[4]));
                
            }
            if (segment[0] == "ChecklistGoal")
            {
                ChecklistGoal deSerializedGoal = new ChecklistGoal(); 
                deSerializedGoal.Deserialize(fileLine);
                if (!bool.Parse(segment[6]))
                {
                    thisPersonsGoals.Add(deSerializedGoal);
                    _score = _score + (Convert.ToInt16(segment[3]) * Convert.ToInt16(segment[4]));
                }
                if (bool.Parse(segment[6]))
                {
                    thisPersonsCompletedGoals.Add(deSerializedGoal);
                    _score = _score + (Convert.ToInt16(segment[3]) * Convert.ToInt16(segment[4]));
                    if (Convert.ToInt16(segment[4]) == Convert.ToInt16(segment[5]))
                    {
                        _score = _score + Convert.ToInt16(segment[7]);
                    }
                }
            }          
        }
        File.WriteAllText(_fileName, String.Empty);  
    }
    //saving saves everything on the two existing lists to a file, and then clears the two lists.
    private void SaveMyFile() 
    {
        Console.Clear();
        StringEater intoMessageBling9 = new StringEater("<SAVING>.",35,true);
        StringEater intoMessageBling0 = new StringEater(".......",250,true);
        Console.Clear(); 
        foreach (SimpleGoal goal in thisPersonsGoals) 
        {       
            using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) 
            {
                _outputFile.WriteLine(goal.Serialize());
            }
        }
        foreach (SimpleGoal goal in thisPersonsCompletedGoals) 
        {       
            using (StreamWriter _outputFile = new StreamWriter(_fileName, true)) 
            {
                _outputFile.WriteLine(goal.Serialize());
            }
        }
        thisPersonsGoals.Clear();
        thisPersonsCompletedGoals.Clear();
    }
    //I was happy with how I figured out how to do all three new goals, each class has a static class
    // that prompts the user for the goal info,m serializes it back to person in text, deserializes 
    // it and adds it to a list in person.
    private void NewSimpleGoal()
    {
        string aSimpleGoal = SimpleGoal.NewSimpleGoal();
        string[] segment = aSimpleGoal.Split("-|-");   
        SimpleGoal newGoal = new SimpleGoal(segment[0], segment[1], Convert.ToInt16(segment[2]), false);
        thisPersonsGoals.Add(newGoal);
        SaveMyFile();
        LoadMyFile();
    }
    private void NewEternalGoal()
    {
        string anEternalGoal = EternalGoal.NewEternalGoal();
        string[] segment = anEternalGoal.Split("-|-");   
        EternalGoal newGoal = new EternalGoal(segment[0], segment[1], Convert.ToInt16(segment[2]), false);
        thisPersonsGoals.Add(newGoal);
        SaveMyFile();
        LoadMyFile();
    }
    private void NewChecklistGoal()
    {
        string aChecklist = ChecklistGoal.NewChecklistGoal();
        string[] segment = aChecklist.Split("-|-");   
        ChecklistGoal newGoal = new ChecklistGoal(segment[0] /*newGoalA*/ ,  segment[1]/*newGoalDesc*/, Convert.ToInt16(segment[2])/*newGoalValue*/, false, Convert.ToInt16(segment[3]/*bonus*/), Convert.ToInt16(segment[4]/*timesToComplete*/));
        thisPersonsGoals.Add(newGoal);
        SaveMyFile();
        LoadMyFile();
    }
    //RecordEvent() was one of the last things I did and I struggled with it and how it did things and the 
    //order and calculating the score, I am glad I got it working, it was a challenge.
    private void RecordEvent()
    {
        int i = 0;
        Console.Clear();
        StringEater recordEventDisplay = new StringEater($"Which goal would you like to complete or update? \n\n", 10, true);
        foreach (SimpleGoal goal in thisPersonsGoals)
        {
            
            StringEater recordEvent1 = new StringEater($"{i + 1}. ", 0, true);
            goal.DisplayGoal();
            Console.Write("\n");
            i++;
        }
        StringEater recordEventDisplay1 = new StringEater($"\nPlease select a number and then press <ENTER> to update it.\n\n==> ", 10, true);
        Console.ForegroundColor = ConsoleColor.White;
        int recordEvent = Convert.ToInt16(Console.ReadLine());
        thisPersonsGoals[recordEvent-1].Increment();        
        Console.Clear();
        StringEater recordEventDisplay2 = new StringEater("<RECORDING YOUR EVENT>.",35,true);
        StringEater recordEventDisplay3 = new StringEater(".......",250,true);
        Thread.Sleep(250);
        SaveMyFile();
        Thread.Sleep(250);
        LoadMyFile();
        Thread.Sleep(250);
    }
    //displays all types of incomplete goals
    private void DisplayMyGoals()
    {
        Console.Clear();
        StringEater displayCCurrentGoals = new StringEater("Here are your current goals:\n", 10, true);
        foreach (SimpleGoal goal in thisPersonsGoals)
        {
            Console.Write("\n");
            goal.DisplayGoal();
        }
        Utility.PressAnyKey();
    }
    //early on in the project I envisioned having a way to remove the completed goal from the list to remove
    //the clutter, and then have somewhere else I can see all of the completed goals. It is important to 
    //note that eternal goals will never be on the completed goal list. 
    private void DisplayMyCompletedGoals()
    {
        Console.Clear();
        StringEater displayCompletedGoals = new StringEater("Here are your completed goals:\n", 10, true);
        foreach (SimpleGoal goal in thisPersonsCompletedGoals)
        {
            Console.Write("\n");
            goal.DisplayGoal();
        }
        Utility.PressAnyKey();
    }
    //I did this project much different than I have any other project. I basically waited to do the menu 
    //and structure until after I got the polymorphing to work, after I figured how how I was going to 
    // pass data around, and planned how I was going to do everything else, hugue success! 
    // You did notice this one got turned in on time and I had time to go and notate things. 
    // I like having menu as its own class and I love how small the class is.
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
                RecordEvent();
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
                Console.Clear();
                SaveMyFile();
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
                StringEater addGoalsLeaving = new StringEater("<Returning to Main Menu>.", 10, true);
                StringEater addGoalsLeaving1 = new StringEater("......", 150, true);
                Thread.Sleep(800);                           
            return;
            default:
                return;
        }
    }
}

