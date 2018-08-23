using Newtonsoft.Json;
using Shared.Model;
using Shared.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Shared.ViewModel
{
    class MainActivityViewModel
    {
        private List<Person> PersonList;
        private RestService restService;

        public MainActivityViewModel()
        {
            restService = new RestService();

            PersonList = new List<Person>();
            for (int i = 0; i < 1000; i++)
                PersonList.Add(new Person("Mustermann", "Max", 22));
        }

        public async void GetPersons()
        {
            string answer = await restService.GetPersonsJson();
            Debug.WriteLine("Content: " + answer);
        }

        public async void PostPersons()
        {
            string content = JsonConvert.SerializeObject(PersonList);

            await restService.PostPersons(content);
        }
    }
}
