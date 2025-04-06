using System;
class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.WriteLine("Hello Foundation3 World!");
        Lecture newLecture = new Lecture("Founders Blend Midland","Hear from two Midland businesses as they share about their business and important lessons they have learned.", "Wednesday, April 2, 2025", "7:30 AM to 9:00 AM", "223 W Wall St STE 200, Midland, TX 79701", "Midland", "TX", "79701", "USA", "FirstName LastName and also FirstName LastName", 50);
        Reception newReception = new Reception("Reception for Mr. and Mrs. XYZ", "The Venue at Live Oak", "5/1/2025", "10:00 AM", "3201 Elkins Rd", "Midland", "TX", "79705", "USA", "Please RSVP by 4/10/2025 by emailing us at: ", "Wedding", "RSVP@Gmail.com" );
        OutdoorGatherings newGathering = new OutdoorGatherings("Basin Red Dirt BBQ & Music Festival", "", "4/26/2025", "3:45 PM", "5514 Champions Dr", "Midland", "TX", "79706", "USA", "Concert", "\nWeather is expected to be cloudy, with a wind advisory. More details to come as it gets closer.");
        Console.Clear();
        Console.Write($"Standard Description:\n");
        Console.Write($"{newLecture.GetStandardDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newLecture.GetFullDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newLecture.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();
        Console.Clear();
        Console.Write($"Standard Description:\n");
        Console.Write($"{newReception.GetStandardDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newReception.GetFullDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newReception.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();Console.Clear();
        Console.Write($"Standard Description:\n");
        Console.Write($"{newGathering.GetStandardDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newGathering.GetFullDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newGathering.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();
    }
}