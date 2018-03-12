using System;
using System.Collections.Generic;
using System.Text;


    public interface Interface
    {
       string Birthdate { get;  }

        bool CheckId(string id, string fakeDigits);
    }
