using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace bm_db_xam_shared.Model
{
    public class Data
    {
        public string DataString { get; set; }
        public int DataInt { get; set; }
        public Boolean DataBoolean { get; set; }
        public double DataDouble { get; set; }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public Data()
        {
            DataString = "JustSomeData";
            DataInt = 123456789;
            DataBoolean = true;
            DataDouble = 4.0;
            ID = 0;
        }
    }
}
