using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using bm_db_xam_android.Helper;
using bm_db_xam_shared.Database;
using bm_db_xam_shared.Model;

namespace bm_db_xam_shared.ViewModel
{
    public class MainActivityViewModel
    {
        List<Data> DataList;
        static DataDatabase database;

        public MainActivityViewModel()
        {
            database = new DataDatabase(PathHelper.GetLocalPath("db_xam_platform"));
            DataList = new List<Data>();

            AddDataToList();
        }

        public async void LoadData()
        {
            var timer = new Stopwatch();
            timer.Start();

            DataList = await database.GetItemsAsync();

            timer.Stop();
            Debug.WriteLine("Time: Load -> " + timer.Elapsed);
            Debug.WriteLine("Time: Load -> " + DataList.Count);
        }

        public void ResetList()
        {
            DataList = null;
        }

        public void InsertData()
        {
            var timer = new Stopwatch();
            timer.Start();

            database.SaveItems(DataList);

            timer.Stop();
            Debug.WriteLine("Time: Insert -> " + timer.Elapsed);
            Debug.WriteLine("Time: Insert -> " + database.GetItemsAsync().Result.Count);
        }

        public void DeleteData()
        {
            var timer = new Stopwatch();
            timer.Start();

            database.DeleteItems(DataList);

            timer.Stop();
            Debug.WriteLine("Time: Insert -> " + timer.Elapsed);
            Debug.WriteLine("Time: Insert -> " + database.GetItemsAsync().Result.Count);

            DataList.Clear();
            AddDataToList();
        }

        private void AddDataToList()
        {
            for (int i = 0; i < 1000; i++)
            {
                DataList.Add(new Data());
            }
        }

    }
}
