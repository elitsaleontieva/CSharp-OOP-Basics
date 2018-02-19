using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var list = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Cargo cargo = new Cargo();
            Engine engine = new Engine();

            Tire tire1 = new Tire();
            Tire tire2 = new Tire();
            Tire tire3 = new Tire();
            Tire tire4 = new Tire();

            Car car = new Car();

            var command = Console.ReadLine();
            var charArr = " ".ToCharArray();
            var parts = command.Split(charArr, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var model = parts[0];
            car.Model = model;

            var engineSpeed = int.Parse(parts[1]);
            engine.Speed = engineSpeed;
            var enginePower = int.Parse(parts[2]);
            engine.Power = enginePower;

            car.Engine = engine;

            var cargoWeight = int.Parse(parts[3]);
            cargo.Weight = cargoWeight;
            var cargoType = parts[4];
            cargo.Type = cargoType;

            car.Cargo = cargo;

            car.Tires = new List<Tire>();

            var tire1Pressure = double.Parse(parts[5]);
            tire1.Pressure = tire1Pressure;
            var tire1Age = int.Parse(parts[6]);
            tire1.Age = tire1Age;
            car.Tires.Add(tire1);

            var tire2Pressure = double.Parse(parts[7]);
            tire2.Pressure = tire2Pressure;
            var tire2Age = int.Parse(parts[8]);
            tire2.Age = tire2Age;
            car.Tires.Add(tire2);


            var tire3Pressure = double.Parse(parts[9]);
            tire3.Pressure = tire3Pressure;
            var tire3Age = int.Parse(parts[10]);
            tire3.Age = tire1Age;
            car.Tires.Add(tire3);


            var tire4Pressure = double.Parse(parts[11]);
            tire4.Pressure = tire4Pressure;
            var tire4Age = int.Parse(parts[12]);
            tire4.Age = tire4Age;
            car.Tires.Add(tire4);

            list.Add(car);

        }

        var cargoTypeCheck = Console.ReadLine();

        if (cargoTypeCheck == "flamable")
        {

            foreach (var flamableCargoType in list.Where(x => x.Cargo.Type.Equals("flamable")))
            {
                if (flamableCargoType.Engine.Power > 250)
                {
                    Console.WriteLine(flamableCargoType.Model);

                }
            }
        }
        else
        {
            foreach (var fragileCargoType in list.Where(x => x.Cargo.Type.Equals("fragile")))
            {
                foreach (var item1 in fragileCargoType.Tires.Where(x => x.Pressure < 1).ToList())
                {
                    Console.WriteLine(fragileCargoType.Model);
                    break;
                }

            }


        }
    }


}


