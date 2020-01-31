using System.Collections.Generic;
using System;

namespace AnimalShelterApi.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public bool Available { get; set; }
    }

}