using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class PromptGenerator
{
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
        int magicKey = randomNumber.Next(_promptList.Count); 
        string _userPrompt = (_promptList[magicKey]);
        return _userPrompt;
    }
}