using System;


class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

sealed class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.StartEngine();
        myCar.Drive();
        myCar.StopEngine();
        Console.ReadLine();
    }
}