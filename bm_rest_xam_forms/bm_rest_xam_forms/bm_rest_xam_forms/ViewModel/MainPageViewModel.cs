using bm_rest_xam_forms.Model;
using bm_rest_xam_forms.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace bm_rest_xam_forms.ViewModel
{
    public class MainPageViewModel
    {
        private List<Person> PersonList;
        private RestService restService;

        public MainPageViewModel()
        {
            restService = new RestService();
        }

        public void GetPersons()
        {
            string answer = restService.GetPersonsJson();

            PersonList = JsonConvert.DeserializeObject<List<Person>>(answer);
        }

        public async void PostPersons()
        {
            string content = JsonConvert.SerializeObject(PersonList);

            await restService.PostPersons(content);
        }
    }
}
