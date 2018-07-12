using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public void LoadData()
        {
            var timer = new Stopwatch();
            timer.Start();

            DataList = database.GetItems();

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
            Debug.WriteLine("Time: Insert -> " + database.GetItems().Count);
        }

        public void DeleteData()
        {
            var keysToDelete = DataList.Select(d => (object)d.ID);

            var timer = new Stopwatch();
            timer.Start();

            database.DeleteItems(keysToDelete);

            timer.Stop();
            Debug.WriteLine("Time: Delete -> " + timer.Elapsed);
            Debug.WriteLine("Time: Delete -> " + database.GetItems().Count);

            DataList.Clear();
            AddDataToList();
        }

        private void AddDataToList()
        {
            for (int i = 0; i < 10000; i++)
            {
                DataList.Add(new Data());
            }
        }

    }
}
