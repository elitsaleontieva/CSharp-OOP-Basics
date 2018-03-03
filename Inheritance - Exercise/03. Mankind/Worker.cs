using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <10) 
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            else
            {
                this.weekSalary = value;
            }
        }
    }
    public decimal WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            else
            {
                this.workHoursPerDay = value;
            }
        }
    }

    public override string ToString()
    {
        return base.ToString()
             + $"Week Salary: {this.WeekSalary:F2}" + Environment.NewLine
             + $"Hours per day: {this.WorkHoursPerDay:F2}" + Environment.NewLine
             + $"Salary per hour: {this.WeekSalary/(this.WorkHoursPerDay*5):F2}";
    }
}

