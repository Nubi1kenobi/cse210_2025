using System;
public class Listing : Activity 
{    
    public Listing() : base()
    {
        _activity = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        WelcomeMsg();
        RunListing();
    }   
    public void RunListing() 
    {
        Console.Clear();
        StringEater listingActivity = new StringEater("Commence your Listing!\n", 15, true);
        Thread.Sleep(_messageDelay);
        //Sometimes it takes listing things out to see how truly blessed we are!
    }  
}