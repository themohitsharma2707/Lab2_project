using System;

public static class MathHelper
{
    public static double CalculateAverage(int[] arr)
    {


        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        double average = (double)sum / arr.Length;
        return average;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of index ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        double average = MathHelper.CalculateAverage(arr);
        Console.WriteLine("Average: " + average);
        Console.ReadLine();
    }
}