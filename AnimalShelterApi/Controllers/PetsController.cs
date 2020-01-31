using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //This is in order to use EntityState.
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private AnimalShelterApiContext _db;

        public PetsController(AnimalShelterApiContext db)
        {
            _db = db;
        }

        // GET api/pets
        // THis method now allows a user to enter query parameters for species, gender and name
        // The 3 of these are properties of each Animal instance (ex: api/animals?gender=female )
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
                query = query.Where(entry => entry.Color == color);
            }

            return query.ToList();
        }

        // GET api/pets/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            return _db.Pets.FirstOrDefault(entry => entry.PetId == id);
        }

        // POST api/pets
        [HttpPost]
        public void Post([FromBody] Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet pet)
        {
            pet.PetId = id;
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/pets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var petToDelete = _db.Pets.FirstOrDefault(entry => entry.PetId == id);
            _db.Pets.Remove(petToDelete);
            _db.SaveChanges();
        }

    }
}




