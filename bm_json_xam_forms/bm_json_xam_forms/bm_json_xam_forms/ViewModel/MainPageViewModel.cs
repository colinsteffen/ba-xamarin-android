using bm_json_xam_forms.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace bm_json_xam_forms.ViewModel
{
    public class MainPageViewModel
    {
        private List<Person> PersonList;
        private string SerializedJsonList;

        public MainPageViewModel()
        {
            PersonList = new List<Person>();

            for (int i = 0; i < 10000; i++)
            {
                PersonList.Add(new Person());
            }
        }

        public void SerializePersons()
        {
            var timer = new Stopwatch();
            timer.Start();

            SerializedJsonList = JsonConvert.SerializeObject(PersonList);

            timer.Stop();
            Debug.WriteLine("Time: Serialization -> " + timer.Elapsed);
        }

        public void DeserializePersons()
        {
            var timer = new Stopwatch();
            timer.Start();

            PersonList = JsonConvert.DeserializeObject<List<Person>>(SerializedJsonList);

            timer.Stop();
            Debug.WriteLine("Time: Deserialization -> " + timer.Elapsed);
            Debug.WriteLine("Time: Deserialization -> " + PersonList.Count);
        }
    }
}
