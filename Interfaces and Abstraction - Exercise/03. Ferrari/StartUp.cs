using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();

        Ferrari ferrari = new Ferrari(name);

        Console.WriteLine($"{ferrari.Model}/{ferrari.PushBreaks()}/{ferrari.GasPedalPushed()}/{ferrari.DriversName}");

    }
}

