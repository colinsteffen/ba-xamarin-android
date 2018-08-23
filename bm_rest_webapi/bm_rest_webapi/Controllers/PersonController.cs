using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using bm_rest_webapi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TodoApi.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> personen;

        public PersonController()
        {
            personen = new List<Person>();

            for (int i = 0; i < 1000; i++)
                personen.Add(new Person("Mustermann", "Max", 22));
        }

        [HttpGet]
        public ActionResult<String> GetAll()
        {
            return JsonConvert.SerializeObject(personen);
        }

        [HttpPost]
        public IActionResult InsertPersonen(string pn)
        {
            Debug.WriteLine(JsonConvert.SerializeObject(pn));
            return Ok(true);
        }
    }
}