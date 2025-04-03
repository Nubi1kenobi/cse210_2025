using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Lecture newLecture = new Lecture("Founders Blend Midland"," Hear from two Midland businesses as they share about their business and important lessons they have learned.", "Wednesday, April 2, 2025", "7:30 AM - 9:00 AM", "223 W Wall St STE 200, Midland, TX 79701", "Midland", "TX", "79701", "USA", "Speaker Name", 50);
        Reception newReception = new Reception("", "", "", "", "", "", "", "", "", "", "", "" );
        OutdoorGatherings newGathering = new OutdoorGatherings("", "", "", "", "", "", "", "", "", "", "");
    }
}