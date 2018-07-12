using bm_db_xam_forms.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bm_db_xam_forms.Database
{
    public class DataDatabase
    {
        readonly SQLiteConnection con;

        public DataDatabase(string dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Data>();
        }

        public void SaveItems(List<Data> dataList)
        {
            Task.Run(() =>
            {
                con.InsertAll(dataList);
            }).Wait();
        }

        public void DeleteItems(IEnumerable<object> keys)
        {
            Task.Run(() =>
            {
                con.DeleteAllIds<Data>(keys);
            }).Wait();      
        }

        public List<Data> GetItems()
        {
            List<Data> items = null;
            Task.Run(() =>
            {
                items = con.Query<Data>("select * from Data");
            }).Wait();
            return items;
        }
    }
}
