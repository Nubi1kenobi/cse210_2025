using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "SomeTech";
        job1._jobTitle = "Technical Support";
        job1._startYear = 2010;
        job1._endYear = 2020;

        job2._company = "Stauchshunds";
        job2._jobTitle = "Owner";
        job2._startYear = 2020;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Bryan C. Stauch";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }
}