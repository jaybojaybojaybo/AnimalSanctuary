using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalSanctuary.Models
{
    public class EFAnimalSanctuaryRepository : IAnimalSanctuaryRepository
    {
        AnimalSanctuaryContext db = new AnimalSanctuaryContext();

        public IQueryable<Animal> Animals { get { return db.Animals; } }

        public Animal Save(Animal animal)
        {
            db.Animals.Add(animal);
            db.SaveChanges();
            return animal;
        }

        public Animal Edit(Animal animal)
        {
            db.Entry(animal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return animal;
        }

        public void Remove(Animal animal)
        {
            db.Animals.Remove(animal);
            db.SaveChanges();
        }
    }
}
