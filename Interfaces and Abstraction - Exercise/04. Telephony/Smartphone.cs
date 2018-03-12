using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Smartphone : ICallable, IBrowseable
{

    public string Site { get; set; }
    public string Number { get; set; }


    public string BrowseWeb(string site)
    {
        if (!site.ToCharArray().Any(x => Char.IsDigit(x)))
        {
            return $"Browsing: {site}!";
        }
        else
        {
            throw new ArgumentException("Invalid URL!");
        }
    }

    public string CallPhone(string phone)
    {
        if (phone.ToCharArray().All(x => Char.IsDigit(x)))
        {
            return $"Calling... {phone}";
        }
        else
        {
            throw new ArgumentException("Invalid number!");

        }
    }


}
