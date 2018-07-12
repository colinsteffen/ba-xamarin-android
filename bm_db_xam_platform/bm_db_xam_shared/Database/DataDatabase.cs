using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using bm_db_xam_shared.Model;
using SQLite;

namespace bm_db_xam_shared.Database
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
            database.DeleteAsync(dataList).Wait();
        }

        public Task<List<Data>> GetItemsAsync()
        {
            return database.Table<Data>().ToListAsync();
        }
    }
}
