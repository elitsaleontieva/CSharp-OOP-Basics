using System;
using System.Collections.Generic;
using System.Text;


public class Cargo
{
    public string Type;
    public int Weight;

    public Cargo()
    {
    }

    public Cargo(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;
    }
}

