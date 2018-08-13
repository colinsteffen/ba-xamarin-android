using System;
using System.Collections.Generic;
using System.Text;

namespace bm_rest_xam_forms.Model
{
    public class Person
    {

        public String Nachname { get; set; }
        public String Vorname { get; set; }
        public int Alter { get; set; }

        public Person(string nachname, string vorname, int alter)
        {
            this.Nachname = nachname;
            this.Vorname = vorname;
            this.Alter = alter;
        }

    }
}
