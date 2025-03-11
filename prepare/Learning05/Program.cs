using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> allMyShapes = new List<Shape>(){};
        Square newSquare = new Square("purple", 8);
        allMyShapes.Add(newSquare);
        Rectangle newRectangle = new Rectangle("green", 8, 32);
        allMyShapes.Add(newRectangle);
        Circle perfectCircle = new Circle("blue", 58);
        allMyShapes.Add(perfectCircle);
        Console.Clear();
        //testing the classes
        Console.WriteLine($"your new {newSquare._color} square has an area of {newSquare.GetArea()}.");
        Console.WriteLine($"your new {newRectangle._color} rectangle has an area of {newRectangle.GetArea()}.");
        Console.WriteLine($"your new {perfectCircle._color} circle has an area of {perfectCircle.GetArea()}.");
        Console.Write("Press Any Key");
        Console.ReadKey();
        Console.Clear();
        //listing them all 
        foreach (Shape things in allMyShapes)
        {
            Console.WriteLine($"your new {things._color} thing has an area of {things.GetArea()}.");
        }
        
        


        }
    }
