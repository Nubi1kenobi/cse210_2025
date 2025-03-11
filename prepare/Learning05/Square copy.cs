using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    } 
    



}