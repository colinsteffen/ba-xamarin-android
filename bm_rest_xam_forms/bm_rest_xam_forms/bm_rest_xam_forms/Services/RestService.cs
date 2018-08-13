using bm_rest_xam_forms.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace bm_rest_xam_forms.Services
{
    public class RestService
    {
        string serveradresse = "http:localhost:44301/api/";

        public RestService()
        {
        }

        public string GetPersonsJson()
        {
            var timer = new Stopwatch();
            timer.Start();

            var client = new RestClient();
            var uri = new Uri(serveradresse + "person");
            var request = new RestRequest(Method.GET);

            request.AddHeader("content-type", "application/json");
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);

            timer.Stop();
            Debug.WriteLine("Time: Serialization -> " + timer.Elapsed);

            string answer = response.Content.ToString();
            Debug.WriteLine("Content:" + answer);

            return answer;
        }

        public async Task<bool> PostPersons(string personsJson)
        {
            var timer = new Stopwatch();
            timer.Start();

            var client = new HttpClient();
            var uri = new Uri(serveradresse + "person");

            var content = new StringContent(personsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(false);

            if(response.IsSuccessStatusCode)
            {
                timer.Stop();
                Debug.WriteLine("Time: Serialization -> " + timer.Elapsed);
                return true;
            }

            return false;
        }

    }
}
