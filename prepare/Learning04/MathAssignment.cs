using System;
public class MathAssignment : Assignment 
{
    private string _textbooksection;
    private string _problems;
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbooksection = "7.3"; 
        _problems = "8-19";}
      
    public string GetHomeworkList() {return $"{_studentName}\nSection {_textbooksection} Problems {_problems}";}
}