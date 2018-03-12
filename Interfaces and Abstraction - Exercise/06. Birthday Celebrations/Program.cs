using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();



        var inputList = new List<string>();
        inputList.Add(input);

        while (input != "End")
        {
            input = Console.ReadLine();

            inputList.Add(input);
        }
        var lastDigitsOfFakeIds = Console.ReadLine();

        foreach (var inputLine in inputList.SkipLast(1))
        {
            var parts = inputLine.Split(' ').ToArray();
            var partsLength = parts.Length;
            if (parts.Length == 5 && parts[0] == "Citizen")
            {

                Citizen citizen = new Citizen();
                var name = parts[1];
                var age = int.Parse(parts[2]);
                var id = parts[3];
                var birthdate = parts[4];

                if (citizen.CheckId(birthdate, lastDigitsOfFakeIds) == false)
                {
                    citizen = new Citizen(name, age, id, birthdate);
                    Console.WriteLine(citizen.Birthdate);
                }

            }
            else if (parts.Length == 3 && parts[0] == "Pet")
            {

                var name = parts[1];
                var birthdate = parts[2];

                Pet pet = new Pet();
                if (pet.CheckId(birthdate, lastDigitsOfFakeIds) == false)
                {
                    pet = new Pet(name, birthdate);
                    Console.WriteLine(pet.Birthdate);
                }


            }
        }

    }
}
                