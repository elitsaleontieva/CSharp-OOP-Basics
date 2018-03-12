using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Citizen 
    {

        private string Name { get; set; }

        private int Age { get; set; }

        public string Id { get; set; }



        public Citizen()
        {

        }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
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
}
