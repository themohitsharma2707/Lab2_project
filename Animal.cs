using System;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
}


class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching the ball.");
    }
}

class Cat : Animal
{
    public bool IsIndoor { get; set; }

    public Cat(string name, int age, bool isIndoor) : base(name, age)
    {
        IsIndoor = isIndoor;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Dog dog = new Dog("Buddy", 3, "Golden Retriever");
        Cat cat = new Cat("Whiskers", 2, true);

        dog.MakeSound();
        dog.Fetch();

        cat.MakeSound();
        cat.Purr();
        Console.ReadLine();
    }
}