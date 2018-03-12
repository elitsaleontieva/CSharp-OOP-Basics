using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Pet : Interface
    {
        public string Name { get; set; }
        

        public string Birthdate { get; set; }

        public Pet()
        {

        }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
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
