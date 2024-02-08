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
                bool isMatch = false;
                foreach (var poke in GetAllPokemon())
                {
                    if (poke.Name == pokemon.Name)
                    {
                        isMatch = true;
                    }

                }

                if (!isMatch)
                {
                    context.Pokemons.Add(pokemon);
                    context.SaveChanges();
                }
            }

            else
            {
                throw new Exception("Pokemonobject was null!");
            }

        }



        public Pokemon GetByName(string name)
        {
            Pokemon? pokeFound = new Pokemon();

            if (name == null)
            {

            }

            else
            {
                try
                {
                    pokeFound = context.Pokemons.FirstOrDefault(p => p.Name == name);
                }

                catch (Exception ex)
                {
                    throw new Exception("No pokemon found");
                }
            }

            return pokeFound;

        }

        public IEnumerable<Pokemon> GetAllPokemon()
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            pokemonList = context.Pokemons.ToList();

            if (pokemonList.Any())
            {
                return pokemonList;
            }

            else
            {

                List<Pokemon> holder = new()
                {
                    new Pokemon(),
                    new Pokemon()

                };
                return holder;

            }

        }
    }
}
