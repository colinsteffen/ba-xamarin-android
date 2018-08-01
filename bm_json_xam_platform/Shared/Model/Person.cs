using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Model
{
    class Person
    {
        public string Country { get; set; }
        public string Birthday { get; set; }
        public string Phonenumber { get; set; }
        public Adress Location { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }

        public Person()
        {
            Country = "Germany";
            Birthday = "13.08.1985";
            Phonenumber = "+490154868686";
            Location = new Adress();
            Surname = "Mustermann";
            Forename = "Max";
        }
    }
}
