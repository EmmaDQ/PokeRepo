using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Services
{
    public class PokkeRepo : IPokkeRepo
    {
        private readonly PokeDbContext context;
        public PokkeRepo(PokeDbContext context)
        {
            this.context = context;
        }
        public void AddPokemonToDb(Pokemon pokemon)
        {
            if (pokemon != null)
            {
                context.Pokemons.Add(pokemon);
                context.SaveChanges();

            }

            else
            {
                throw new Exception("Pokemonobject was null!");
            }

        }

        public Pokemon? GetByName(string name)
        {


            if (name != null)
            {
                Pokemon? pokeFound = new Pokemon();

                try
                {
                    pokeFound = context.Pokemons.FirstOrDefault(p => p.Name == name);
                }

                catch (Exception ex)
                {
                    throw new Exception("No pokemon found");
                }

                return pokeFound;
            }

            return null;

        }

        public IEnumerable<Pokemon> GetAllPokemon()
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            pokemonList = context.Pokemons.ToList();

            return pokemonList;
        }
    }
}
