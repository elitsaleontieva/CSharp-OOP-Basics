using System;
using System.Linq;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            


            var inputList = new List<string>();
            inputList.Add(input);

            while (input!="End")
            {
                input = Console.ReadLine();

                inputList.Add(input);
            }
            var lastDigitsOfFakeIds = Console.ReadLine();

            foreach (var inputLine in inputList.SkipLast(1))
            {
                var parts = inputLine.Split(' ').ToArray();
                var partsLength = parts.Length;
                if (parts.Length == 2)
                {
                    var model = parts[0];
                    Robot robot = new Robot();
                   
                    
                    var id = parts[1];
                    
                    if (robot.CheckId(id, lastDigitsOfFakeIds)==false)
                    {
                        robot = new Robot(model, id);
                        Console.WriteLine(robot.Id);
                    }

                }
                else if (parts.Length == 3)
                {

                    var name = parts[0];
                    var age = int.Parse(parts[1]);
                    var id = parts[2];
                    
                    Citizen citizen = new Citizen();
                    if (citizen.CheckId(id, lastDigitsOfFakeIds) == false)
                    {
                        citizen = new Citizen(name, age, id);
                        Console.WriteLine(citizen.Id);
                    }
                    

                }
            }

        }
    }
}


                