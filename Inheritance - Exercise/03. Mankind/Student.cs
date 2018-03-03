﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }
    

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if ((value.Length <5 || value.Length > 10) || !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            else
            {
                this.facultyNumber = value;
            }
        }
    }

    public override string ToString()
    {
        return base.ToString()+
                $"Faculty number: {this.FacultyNumber}";
    }

  
}

