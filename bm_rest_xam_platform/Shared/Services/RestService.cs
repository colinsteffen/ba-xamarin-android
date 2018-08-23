using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Shared.Services
{
    public class RestService
    {
        string serveradresse = "http://172.20.10.3:5000/api/person/";
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> GetPersonsJson()
        {
            var timer = new Stopwatch();
            timer.Start();

            var uri = new Uri(string.Format(serveradresse));

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                timer.Stop();
                Debug.WriteLine("Time: Get -> " + timer.Elapsed);

                string answer = await response.Content.ReadAsStringAsync();
                return answer;
            }

            return "";
        }

        public async Task<bool> PostPersons(string personsJson)
        {
            var timer = new Stopwatch();
            timer.Start();

            var uri = new Uri(string.Format(serveradresse));

            var content = new StringContent(personsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                timer.Stop();
                Debug.WriteLine("Time: Post -> " + timer.Elapsed);
                return true;
            }

            return false;
        }
    }
}
