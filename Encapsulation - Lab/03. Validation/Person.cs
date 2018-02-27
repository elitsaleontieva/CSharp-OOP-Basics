using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;


    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;

    }


    public string FirstName {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value.Length<3)
            {
              throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            
                this.firstName = value;
            
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName ;
        }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
                this.lastName = value;
            
        }
    }

    public int Age {
        get {
            return this.age;
            }
        set {
            if (value<=0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
           
                this.age = value;

           
        }
    }
    public decimal Salary
    {
        get
        {
            return this.salary;
        }

        set
        {
            if (value<460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");

            }
            
                this.salary = value;
            
        }
    }


    public void IncreaseSalary(decimal percentage)
    {
        
        if (this.age >= 30)
        {


            this.salary= ((percentage/100) * this.salary)+this.salary;
        }
        else
        {
            this.salary = (((percentage/2) / 100) * this.salary) + this.salary;
        }
       
    }

    public override string ToString()
    {
        
        return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";

    }

   
}
