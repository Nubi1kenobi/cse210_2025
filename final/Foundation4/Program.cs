using System;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activityList = new List<Activity>();
        Console.Clear();
        Running myRun = new Running("05 Apr 2025", 60, "Running", 5);
        activityList.Add(myRun);
        Cycling myCycle = new Cycling("05 Apr 2025", 30, "Cycling", 5);
        activityList.Add(myCycle);
        Swimming mySwim = new Swimming("05 Apr 2025", 30, "Swimming", 33);
        activityList.Add(mySwim);
        foreach (Activity myActivity in activityList)      
        {
            Console.Write($"{myActivity.Summary()}\n");
        }

    }
}