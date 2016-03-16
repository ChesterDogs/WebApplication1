using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPersons.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [Route("/api/people")]
        public JsonResult GetPeople()
        {
            return Json(GetPersonList());
        }

        protected List<Models.Person> GetPersonList()
        {
            var people = new List<Models.Person>()
            {
                new Models.Person { Id = 1, FirstName = "John", LastName = "Doe" },
                new Models.Person { Id = 1, FirstName = "Mary", LastName = "Jane" },
                new Models.Person { Id = 1, FirstName = "Bob", LastName = "Parker" }
            };
            return people;
        }
    }
}
