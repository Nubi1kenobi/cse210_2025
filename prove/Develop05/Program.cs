using System;
using System.Runtime.Serialization;
//I like to keep my main program as small as possible and have all my classes do the work. 
class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.CursorVisible = false;
        Console.Clear();
        StringEater intro = new StringEater("Hello Develop05 World!",75,true);
        Thread.Sleep(1500);
        //this runs EVERYTHING.
        Person thisPerson = new Person();
    } 
}