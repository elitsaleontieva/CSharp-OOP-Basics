using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firtsName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firtsName, string lastName, int age, decimal salary)
    {
        this.firtsName = firtsName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public int Age
    {
        get { return this.age; }
    }
}

