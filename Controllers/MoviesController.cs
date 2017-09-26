using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_theater.Models;

namespace web_theater.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {

        List<Movie> Values = new List<Movie>() { 
            new Movie("ET", "An alien and a Boy"),
            new Movie("IT", "A clown and several boys"),
            new Movie("Lassie", "A dog and a boy")
        };
        public MoviesController()
        {
            Values.Add(new Movie("Blade", "Some Vampires and a boy"));
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            var request = id - 1;
            if (request < Values.Count && request > -1)
            {
                return Values[request];
            }
            return null;
        }

        [HttpGet("{banana}")]
        public Movie Get(string banana)
        {
            return Values.Find(x => x.Title.Contains(banana));
        }


        public string Get(int x, bool b)
        {
            return "cool";
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Movie> Post([FromBody]Movie value)
        {
            Values.Add(value);
            return Values;
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
