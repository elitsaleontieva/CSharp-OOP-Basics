using System;

class Program
{
    static void Main(string[] args)
    {
        var date1 = Console.ReadLine();
        var date2 = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();
        dateModifier.FirstDate = date1;
        dateModifier.SecondDate = date2;

        Console.WriteLine($"{Math.Abs(int.Parse(dateModifier.DifferenceBetweenDates(date1, date2)))}");

    }
}
