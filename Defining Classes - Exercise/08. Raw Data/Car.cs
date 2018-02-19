using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
 
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tire> Tires;

    public Car(string model,Engine engine,Cargo cargo, List<Tire> tires)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = new List<Tire>();

    }

    public Car()
    {
    }
}

