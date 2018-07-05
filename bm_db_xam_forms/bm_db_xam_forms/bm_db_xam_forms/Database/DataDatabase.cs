using bm_db_xam_forms.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bm_db_xam_forms.Database
{
    public class DataDatabase
    {
        readonly SQLiteAsyncConnection database;

        public DataDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Data>().Wait();
        }

        public void SaveItems(List<Data> dataList)
        {
            database.InsertAllAsync(dataList).Wait();
        }

        public void DeleteItems(List<Data> dataList)
        {
            foreach(Data d in dataList)
                database.DeleteAsync(dataList);
        }

        public Task<List<Data>> GetItemsAsync()
        {
            return database.Table<Data>().ToListAsync();
        }
    }
}
