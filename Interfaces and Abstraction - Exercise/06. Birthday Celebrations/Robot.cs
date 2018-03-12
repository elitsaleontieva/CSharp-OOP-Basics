using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


    public class Robot : Interface
    {

        public string Model { get; set; }
        public string Id { get; set; }

        public string Birthdate { get; set; }

        public Robot()
        {

        }

        public Robot(string model, string id, string birthdate)
        {
            this.Model = model;
            this.Id = id;
        this.Birthdate = birthdate;
        }

       

        public bool CheckId(string id, string fakeDigits)
        {
            if (string.Join("", id.ToString().TakeLast(fakeDigits.Length)) == fakeDigits)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
