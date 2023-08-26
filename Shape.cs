using System;


abstract class Shape
{
    public abstract double CalculateArea();
}


class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Shape circle = new Circle(5.0);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        Shape rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        Console.ReadLine();
    }
}