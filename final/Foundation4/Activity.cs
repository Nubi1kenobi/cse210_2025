using System;
public class Activity
{
    private string _date = "01/01/1900";
    private int _lengthInMinutes = 1;
    private int _distance = 1;
    public Activity(string date, int length, int distance)
    {
        _date = date;
        _lengthInMinutes = length;
        _distance = distance;
    }
    public double CalculateDistance()
    {
        return 0;
    }
    public double CalculateSpeed()
    {
        return 0;
    }
    public double CalculatePace()
    {
        return 0;
    }

}
