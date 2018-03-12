using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Citizen : Interface
    {

        private string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; private set; }

        public string Birthdate { get; set; }



        public Citizen()
        {

        }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
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
