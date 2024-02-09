using PokeRepo.Models;

namespace PokeRepo.Services
{
    public interface IPokkeRepo
    {
        public IEnumerable<Pokemon> GetAllPokemon();
        public Pokemon GetByName(string name);
        public void AddPokemonToDb(Pokemon pokemon);
        public Pokemon GetByNameWithAbilities(string name);

        public Ability GetAbilityByName(string name);
    }
}
