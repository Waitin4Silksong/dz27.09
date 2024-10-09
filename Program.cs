using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{LastName}, {FirstName} - Age: {Age}";
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { FirstName = "Yurii", LastName = "Krasnov", Age = 17 },
            new Student { FirstName = "Myroslav", LastName = "Shevchuk", Age = 19 },
            new Student { FirstName = "Andriy", LastName = "Gnativ", Age = 17 },
            new Student { FirstName = "Veronika", LastName = "Mocharna", Age = 18 },
            new Student { FirstName = "Artem", LastName = "Armash", Age = 16 }


        };
        var sorted = students
            .OrderBy(s => s.LastName)
            .ThenBy(s => s.Age)
            .ThenBy(s => s.FirstName);

        foreach (var student in sorted)
        {
            Console.WriteLine(student);
        }

    }
}