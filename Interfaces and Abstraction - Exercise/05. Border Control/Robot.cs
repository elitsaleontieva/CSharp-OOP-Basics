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

        //public bool CheckId(string id, string fakeDigits)
        //{
        //    if (string.Join("", id.ToString().TakeLast(fakeDigits.Length)) == fakeDigits)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
