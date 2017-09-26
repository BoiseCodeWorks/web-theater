using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_theater.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        List<string> Values = new List<string>() { "value1", "value2", "Value 3" };

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var request = id - 1;
            if (request < Values.Count && request > -1)
            {
                return Values[request];
            }
            return "HEY THATS DOESNT WORK";
        }

        [HttpGet("{banana}")]
        public string Get(string banana)
        {
            return Values.Find(x => x.Contains(banana));
        }


        public string Get(int x, bool b)
        {
            return "cool";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //THIS IS YOUR JOB
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
    }
}
