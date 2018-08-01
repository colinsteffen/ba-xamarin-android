using System;
using System.Collections.Generic;
using System.Text;

namespace bm_json_xam_forms.Model
{
    class Adress
    {
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Adress()
        {
            City = "Berlin";
            ZipCode = 10179;
            Street = "Bahnhofstrasse";
            Number = "10a";
        }
    }
}
