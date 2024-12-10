using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person other)
    {
        return Age.CompareTo(other.Age);
    }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25), 
            new Person("Charlie", 35)
        };

        // ascending age
        people.Sort();

        Console.WriteLine("Sorted by age ascending:");
        foreach (var p in people) Console.WriteLine($"{p.Name} - {p.Age}");

        // comparator
        var reverseAgeComparer = Comparer<Person>.Create((a, b) => b.Age.CompareTo(a.Age));

        // reverse age order
        people.Sort(reverseAgeComparer);

        Console.WriteLine("\nSorted by age descending:");
        foreach (var p in people) Console.WriteLine($"{p.Name} - {p.Age}");
    }
}
