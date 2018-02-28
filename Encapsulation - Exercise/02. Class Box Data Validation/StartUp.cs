using System;
using System.Linq;
using System.Collections.Generic;


    public class StartUp
    {
        static void Main(string[] args)
        {

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
        try
        {
            Box box = new Box(length, width, height);

            Console.WriteLine(box.ToString());

        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}
