using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_project
{
    class Employee
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Constructor
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary:C}"); // Currency format
        }
    }

    class Class1
    {
        static void Main(string[] args)
        {
            // Create an Employee instance
            Employee employee = new Employee("MOHIT SHARMA", 25, 500000.00);

            // Display employee details using the method
            employee.DisplayDetails();
        }
    }
}
