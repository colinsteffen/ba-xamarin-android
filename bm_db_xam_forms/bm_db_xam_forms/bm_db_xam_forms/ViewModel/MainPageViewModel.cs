using bm_db_xam_forms.Database;
using bm_db_xam_forms.Helper;
using bm_db_xam_forms.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        void AddDataToList()
        {
            for (int i = 0; i < 10000; i++)
                DataList.Add(new Data());
        }

    }
}
