using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Employee emp1 = new Employee("monu sharma", 30, 50000.00);


        emp1.DisplayDetails();
        Console.ReadLine();
    }
}