using PokeRepo.Models;

namespace PokeRepo.Services
{
    public interface IPokeRepo
    {
        public IEnumerable<Pokemon> GetPokemon();
        public Pokemon GetByName(string name);
        public Pokemon AddPokemonToDb(Pokemon pokemon);
    }
}
