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

        public Task<int> SaveItemAsync(Data data)
        {
            if (data.ID != 0)
            {
                return database.UpdateAsync(data);
            }
            else
            {
                return database.InsertAsync(data);
            }
        }

        public Task<List<Data>> GetItemsAsync()
        {
            return database.Table<Data>().ToListAsync();
        }
    }
}
