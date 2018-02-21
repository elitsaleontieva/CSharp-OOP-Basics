using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var carList = new List<Car>();
        var engineList = new List<Engine>();

        for (int i = 0; i < n; i++)
        {
            Engine engine = new Engine();

            var engineInput = Console.ReadLine();
            var charArr = " ".ToCharArray();
            var engineParts = engineInput.Split(charArr, StringSplitOptions.RemoveEmptyEntries);

            var model = engineParts[0];
            engine.Model = model;

            var power = double.Parse(engineParts[1]);
            engine.Power = power;

            if (engineParts.Length == 4)
            {
                var displacement = int.Parse(engineParts[2]);
                var efficiency = engineParts[3];
                engine.Displacemet = displacement;
                engine.Efficiency = efficiency;

            }
            else if (engineParts.Length == 3)
            {
                if (int.TryParse(engineParts[2], out int result) == true)
                {
                    var displacement = int.Parse(engineParts[2]);
                    engine.Displacemet = displacement;
                }
                else
                {
                    var efficiency = engineParts[2];
                    engine.Efficiency = efficiency;
                }
            }

            engineList.Add(engine);

        }

        var m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            var carsInput = Console.ReadLine();
            var charArr2 = " ".ToCharArray();
            var carParts = carsInput.Split(charArr2, StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car();

            var model = carParts[0];
            car.Model = model;

            var engine = carParts[1];
            car.Engine = engine;

            if (carParts.Length == 4)
            {
                var weight = double.Parse(carParts[2]);
                car.Weight = weight;

                var color = carParts[3];
                car.Color = color;
            }
            else if (carParts.Length == 3)
            {
                if (int.TryParse(carParts[2], out int result) == true)
                {
                    var weight = int.Parse(carParts[2]);
                    car.Weight = weight;
                }
                else
                {
                    var color = carParts[2];
                    car.Color = color;
                }
            }

            carList.Add(car);

        }

        foreach (var car in carList)
        {
            foreach (var engine in engineList)
            {


                if (car.Engine == engine.Model)
                {
                    Console.WriteLine($"{car.Model}:");

                    Console.WriteLine($"  {engine.Model}:");
                    Console.WriteLine($"    Power: {engine.Power}");
                    if (engine.Displacemet == 0)
                    {
                        Console.WriteLine($"    Displacement: n/a");
                    }
                    else
                    {
                        Console.WriteLine($"    Displacement: {engine.Displacemet}");
                    }
                    if (engine.Efficiency == null)
                    {
                        Console.WriteLine($"    Efficiency: n/a");

                    }
                    else
                    {
                        Console.WriteLine($"    Efficiency: {engine.Efficiency}");

                    }


                    if (car.Weight == 0)
                    {
                        Console.WriteLine($"  Weight: n/a");
                    }
                    else
                    {
                        Console.WriteLine($"  Weight: {car.Weight}");
                    }
                    if (car.Color == null)
                    {
                        Console.WriteLine($"  Color: n/a");

                    }
                    else
                    {
                        Console.WriteLine($"  Color: {car.Color}");

                    }
                }
            }
        }

    }
}
