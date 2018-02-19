using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var list = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            Employee employee = new Employee();

            var input = Console.ReadLine();
            var parts = input.Split(' ');

            var name = parts[0];
            var salary = decimal.Parse(parts[1]);
            var position = parts[2];
            var department = parts[3];

            employee.Name = name;
            employee.Salary = salary;
            employee.Position = position;
            employee.Department = department;

            string email = "n/a";
            int age = -1;
            if (parts.Length == 5)
            {
                if (parts[4].Contains('@'))
                {

                    email = parts[4];
                    employee.Email = email;
                    employee.Age = age;

                }
                else
                {
                    age = int.Parse(parts[4]);
                    employee.Age = age;
                    employee.Email = email;
                }
                


            }
            else if (parts.Length == 6)
            {

                email = parts[4];
                employee.Email = email;


                age = int.Parse(parts[5]);
                employee.Age = age;
            }
            else 
            {
                
                employee.Email = email;
                
                employee.Age = age;
            }

            list.Add(employee);
        }

    

        var result = list.GroupBy(e => e.Department)
                .Select(d => new
                {
                    Department = d.Key,
                    AverageSalary = d.Average(e => e.Salary),
                    Employees = d.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(d => d.AverageSalary)
                .FirstOrDefault();

        if (result != null)
        {
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

        
    }
}

