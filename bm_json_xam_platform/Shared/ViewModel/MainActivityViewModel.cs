using Newtonsoft.Json;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Shared.ViewModel
{
    public class MainActivityViewModel
    {
        private List<Person> PersonList;
        private string SerializedJsonList;

        public MainActivityViewModel()
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
