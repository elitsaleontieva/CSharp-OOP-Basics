using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    public string Model = "488-Spider";
    public string DriversName { get; set; }

    public Ferrari(string driversName)
    {
        this.DriversName = driversName;
    }

    public string GasPedalPushed()
    {
        return "GasPedalPushed";
    }

    public string PushBreaks()
    {
        return "Brakes!";
    }


}

