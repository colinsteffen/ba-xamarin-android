using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bm_rest_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private List<Person> personen;

        public TodoController()
        {
            personen = new List<Person>();

            for (int i = 0; i < 1000; i++)
                personen.Add(new Person("Mustermann", "Max", 22));
        }

        [HttpGet]
        public ActionResult<List<Person>> GetAll()
        {
            return personen;
        }
    }
}