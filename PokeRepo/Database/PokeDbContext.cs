using Microsoft.EntityFrameworkCore;
using PokeRepo.Models;

namespace PokeRepo.Database
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext(DbContextOptions<PokeDbContext> options) : base(options)
        {

        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Ability> Abilities { get; set; }


    }
}
