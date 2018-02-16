using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Family family = new Family();
        Person person = new Person();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var name = input[0];
            var age = int.Parse(input[1]);


            Person newPerson = new Person();

            newPerson.Name = name;
            newPerson.Age = age;


            family.AddMember(newPerson);
        }

        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
    }
}

