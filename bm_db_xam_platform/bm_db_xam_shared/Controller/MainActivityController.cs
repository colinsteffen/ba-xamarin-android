using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using bm_db_xam_android.Helper;
using bm_db_xam_shared.Database;
using bm_db_xam_shared.Model;

namespace bm_db_xam_shared.Controller
{
    public class MainActivityController
    {
        List<Data> DataList;
        static DataDatabase database;

        public MainActivityController()
        {
            database = new DataDatabase(PathHelper.GetLocalPath("db_xam_platform"));
            DataList = new List<Data>();

            for (int i = 0; i < 1000; i++)
            {
                DataList.Add(new Data());
            }
        }

        public async void LoadData()
        {
            var timer = new Stopwatch();
            timer.Start();

            DataList = await database.GetItemsAsync(); ;

            timer.Stop();
            Debug.WriteLine("LoadTime: " + timer.Elapsed);
            Debug.WriteLine("Datensatz:" + DataList.Count);
        }

        public void ResetList()
        {
            DataList = null;
        }

        public async void InsertData()
        {
            var timer = new Stopwatch();
            timer.Start();

            foreach (Data d in DataList)
            {
                await database.SaveItemAsync(d);
            }

            timer.Stop();
            Debug.WriteLine("InsertTime: " + timer.Elapsed);
        }

    }
}
