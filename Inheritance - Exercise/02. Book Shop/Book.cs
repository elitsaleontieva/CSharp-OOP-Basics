using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Book
{
    private string author;

    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }
    public string Author
    {
        get
        {
            return this.author;
        }
        set
        {

            var firstAndSecondName = value.Split(' ').ToArray();
            
            if (firstAndSecondName.Length == 2)
            {

                var secondname = firstAndSecondName[1].ToArray().First();
                var check = Char.IsDigit(secondname);

                if (check)
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            
                this.author = value;
            

        }
    }
    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

 
    public virtual decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;

    }

}

