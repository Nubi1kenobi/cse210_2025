using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class PromptGenerator
{
    string userPrompt;
    Random randomNumber = new Random();
    List <string> _promptList = new List<string>
    {
        "What is the weather like today?",
        "What kind thing you did for someone today?",
        "What are you planning for tomorrow?",
        "What are you planning for next week?",
        "Create a new goal for today.",
        "What can you do to make today a good day?"
    };
        
    public string Prompt()
    {
        Console.WriteLine("Stub: PromptGenerator/Prompt()");
        int magicKey = randomNumber.Next(_promptList.Count); 
        string _userPrompt = (_promptList[magicKey]);
        return _userPrompt;
    }
    
    static void AddNewPrompt()
    {
        Console.WriteLine("Stub: PromptGenerator/AddNewPrompt()");
    } 
    static void Display()
    {
        Console.WriteLine("Stub: PromptGenerator/Display()");
    } 
}