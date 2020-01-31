using Microsoft.EntityFrameworkCore;


namespace AnimalShelterApi.Models
{
    public class AnimalShelterApiContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pet>()
                .HasData(
                    new Pet { PetId = 1, Species = "Cat", Name = "Fred", Color = "black", Age = "7" },
                    new Pet { PetId = 2, Species = "Cat", Name = "Chubs", Color = "white", Age = "3" },
                    new Pet { PetId = 3, Species = "Dog", Name = "Teddy", Color = "black/white", Age = "5" },
                    new Pet { PetId = 4, Species = "Cat", Name = "Billy", Color = "tan", Age = "10 "},
                    new Pet { PetId = 5, Species = "Dog", Name = "Snoopy", Color = "black/white", Age = "3" },
                    new Pet { PetId = 6, Species = "Dog", Name = "Bear", Color = "brown", Age = "6" },
                    new Pet { PetId = 7, Species = "Dog", Name = "Hulk", Color = "gray", Age = "11" },
                    new Pet { PetId = 8, Species = "Cat", Name = "Medusa", Color = "black", Age = "12" },
                    new Pet { PetId = 9, Species = "Dog", Name = "Hercules", Color = "black/brown", Age = "7" },
                    new Pet { PetId = 10, Species = "Cat", Name = "Pythagorous", Color = "gray", Age = "9" }
                );
        }


    }
    
}

