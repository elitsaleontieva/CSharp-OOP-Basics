using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Family
{
    public List<Person> people { get; set; }

    public Family()
    {
        this.people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.people.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.people
            .OrderByDescending(x => x.Age)
            .FirstOrDefault();
    } 
}

