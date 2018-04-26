using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalSanctuary.Models
{
    public class AnimalSanctuaryContext : DbContext
    {
        public AnimalSanctuaryContext()
        { }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
            .UseMySql(@"Server=localhost;Port=8889;database=animals;uid=root;pwd=root;");

        public AnimalSanctuaryContext(DbContextOptions<AnimalSanctuaryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
