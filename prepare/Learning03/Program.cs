using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning03 World!");
        Fraction uno = new Fraction();
        Console.WriteLine(uno.GetFractionString());
        Console.WriteLine(uno.GetDecimalValue());
        Fraction dos = new Fraction(5);
        Console.WriteLine(dos.GetFractionString());
        Console.WriteLine(dos.GetDecimalValue());
        Fraction tres = new Fraction(1,3);
        Console.WriteLine(tres.GetFractionString());
        Console.WriteLine(tres.GetDecimalValue());

    }
}

