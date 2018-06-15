using bm_db_xam_forms.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace bm_db_xam_forms.ViewModel
{
    public class MainPageViewModel
    {
        List<Data> DataList;

        public MainPageViewModel()
        {
            DataList = new List<Data>();

            for (int i = 0; i >= 10000; i++)
            {
                DataList.Add(new Data());
            }
        }

        public async void LoadData()
        {
            var timer = new Stopwatch();
            timer.Start();

            DataList = await App.Database.GetItemsAsync();

            timer.Stop();
            Debug.WriteLine("LoadTime: " + timer.Elapsed);
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
                await App.Database.SaveItemAsync(d);
            }

            timer.Stop();
            Debug.WriteLine("InsertTime: " + timer.Elapsed);
        }

    }
}
