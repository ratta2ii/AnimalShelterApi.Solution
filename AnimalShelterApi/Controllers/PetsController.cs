using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        private AnimalShelterApiContext _db;

        public PetsController(AnimalShelterApiContext db)
        {
            _db = db;
        }

        // GET api/pets
        // Query parameters
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get(string species, string name, string color)
        {
            var query = _db.Pets.AsQueryable();

            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if (color != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            return query.ToList();

        }

        // Get api/pets/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/pets
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/pets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
    
}
