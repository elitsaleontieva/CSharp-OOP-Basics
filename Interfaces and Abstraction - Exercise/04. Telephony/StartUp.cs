using System;
using System.Linq;
using System.Collections.Generic;


public class StartUp
{
    static void Main(string[] args)
    {
        var phoneNumbersInput = Console.ReadLine().Split(' ').ToArray();
        var sitesInput = Console.ReadLine().Split(' ').ToArray();

        Smartphone smartphone = new Smartphone();

        foreach (var phone in phoneNumbersInput)
        {
            smartphone.Number = phone;
            try
            {
                Console.WriteLine($"{smartphone.CallPhone(smartphone.Number)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        foreach (var site in sitesInput)
        {
            smartphone.Site = site;
            try
            {
                Console.WriteLine($"{smartphone.BrowseWeb(smartphone.Site)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
