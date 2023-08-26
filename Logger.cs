using System;

public static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger.LogMessage("Starting the application...");



        Logger.LogMessage("Application finished...");

        Console.ReadLine();
    }
}