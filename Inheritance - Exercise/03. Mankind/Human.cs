﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (!(Char.IsUpper(value.ToCharArray().First())) || !(Char.IsLetter(value.ToCharArray().First())))
            {
                throw new ArgumentException("Expected upper case letter!Argument: firstName");
            }
            else if (value.Length<=3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            else
            {
                this.firstName = value;
            }
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (!(Char.IsUpper(value.ToCharArray().First())) || !(Char.IsLetter(value.ToCharArray().First())))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            else if (value.Length <= 2)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            else
            {
                this.lastName = value;
            }
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}" + Environment.NewLine
               + $"Last Name: {this.lastName}" + Environment.NewLine;
    }

}

