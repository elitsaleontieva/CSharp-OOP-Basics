using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Person> bag;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            {
                this.money = value;
            }
        }
    }

    public List<Product> Bag { get; set; }

    public Person(string name, decimal money, List<Product> bag)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    
    public void AddToBag(string name, decimal cost)
    {
        Bag.Add(new Product(name, cost));
    }

}
