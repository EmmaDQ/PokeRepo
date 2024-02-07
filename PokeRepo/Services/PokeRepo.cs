using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Services
{
    public class PokeRepo : IPokeRepo
    {
        private readonly PokeDbContext context;
        public PokeRepo(PokeDbContext context)
        {
            this.context = context;
        }
        public Pokemon AddPokemonToDb(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pokemon> GetPokemon()
        {
            throw new NotImplementedException();
        }
    }
}
