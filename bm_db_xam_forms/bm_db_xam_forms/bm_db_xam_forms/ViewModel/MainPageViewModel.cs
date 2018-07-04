using bm_db_xam_forms.Database;
using bm_db_xam_forms.Helper;
using bm_db_xam_forms.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bm_db_xam_forms.ViewModel
{
    public class MainPageViewModel
    {
        private DataDatabase database;
        List<Data> DataList;

        public MainPageViewModel()
        {
            DataList = new List<Data>();
            database = new DataDatabase(DependencyService.Get<IPathHelper>().GetLocalPath("db_xam_forms"));

            for (int i = 0; i < 1000; i++)
            {
                DataList.Add(new Data());
            }
        }

        public async void LoadData()
        {
            var timer = new Stopwatch();
            timer.Start();

            DataList = await database.GetItemsAsync();

            timer.Stop();
            Debug.WriteLine("LoadTime: " + timer.Elapsed);
            Debug.WriteLine("Datensatz:" + DataList.Count);
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
            Debug.WriteLine("InsertTime: " + timer.Elapsed);

            Debug.WriteLine("InsertTime: " + database.GetItemsAsync().Result.Count);
        }

    }
}
