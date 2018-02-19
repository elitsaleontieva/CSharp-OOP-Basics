using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<Car>();

        var distanceTraveled = 0;
        for (int i = 0; i < n; i++)
        {

            var carInfo = Console.ReadLine();
            var chars1 = " ".ToArray();
            var parts = carInfo.Split(chars1, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var model = parts[0];
            var fuelAmount = double.Parse(parts[1]);
            var fuelConsumptionFor1km = double.Parse(parts[2]);

            Car car = new Car();
            car.Model = model;
            car.FuelAmount = fuelAmount; //23
            car.FuelConsumptionFor1Km = fuelConsumptionFor1km; //0.3
            car.DistanceTraveled = distanceTraveled; //0
                                                     //AudiA4 23 0.3
            list.Add(car);
        }
            var command = Console.ReadLine();

        while (command != "End")
            {
            foreach (var car in list)
            {
                
                var chars = " ".ToArray();
                var parts2 = command.Split(chars, StringSplitOptions.RemoveEmptyEntries);
                var carModel = parts2[1];
                var amountOfKm = double.Parse(parts2[2]);

                var totalConsumption = car.FuelConsumptionFor1Km * amountOfKm;
                if (carModel == car.Model)
                {


                    if (totalConsumption > car.FuelAmount)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                

                    }
                    else if (totalConsumption == car.FuelAmount)
                    {
                        car.FuelAmount -= totalConsumption;
                        car.DistanceTraveled -= amountOfKm;
                    }
                    else
                    {
                        car.FuelAmount -= totalConsumption;

                        car.DistanceTraveled -= amountOfKm;
                        
                    }
                }
               

            }
                command = Console.ReadLine();
            }

        foreach (var car in list)
        {
           
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {Math.Abs(car.DistanceTraveled)}");
        }


    }
    }


