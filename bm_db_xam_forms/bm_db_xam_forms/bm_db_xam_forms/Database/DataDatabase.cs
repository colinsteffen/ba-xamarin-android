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
