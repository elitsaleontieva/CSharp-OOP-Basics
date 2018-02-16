using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Person person = new Person();
        var list = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var name = input[0];
            var age = int.Parse(input[1]);
            Person newPerson = new Person();

            newPerson.Name = name;
            newPerson.Age = age;

            list.Add(newPerson);
        }

        
        foreach (var personOver30 in list.Where(x=>x.Age>30).OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{personOver30.Name} - {personOver30.Age}");
        }
       
    }
}

