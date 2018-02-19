using System;
using System.Collections.Generic;
using System.Text;


public class DateModifier
{
    public string FirstDate { get; set; }
    public string SecondDate { get; set; }

    public DateModifier()
    {

    }

    public string DifferenceBetweenDates(string date1, string date2)
    {
        var parseDate1 = DateTime.Parse(date1);
        var parseDate2 = DateTime.Parse(date2);

        return $"{(parseDate1 - parseDate2).TotalDays}";
    }

}
