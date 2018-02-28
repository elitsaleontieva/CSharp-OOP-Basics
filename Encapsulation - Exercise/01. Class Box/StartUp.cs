using System;
using System.Linq;
using System.Collections.Generic;


    class StartUp
    {
        static void Main(string[] args)
        {

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = new Box(length,width,height);

            Console.WriteLine(box.ToString());
        }
    }
