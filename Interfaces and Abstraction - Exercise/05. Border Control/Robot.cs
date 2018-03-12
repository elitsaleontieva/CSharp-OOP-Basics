using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BorderControl
{
    public class Robot : Citizen
    {

        public string Model { get; set; }

        public Robot()
        {

        }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        
    }
}
