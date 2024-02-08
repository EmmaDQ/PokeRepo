using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {
        public IPokkeRepo repo;
        public ApiCaller caller;
        public List<Pokemon> Pokemons { get; set; } = new();

        public Pokemon Poke { get; set; } = new Pokemon();

        public DetailsModel(ApiCaller caller, IPokkeRepo repo)
        {
            this.caller = caller;
            this.repo = repo;
        }

        public DetailsModel()
        {
            this.caller = new ApiCaller();
        }



        public async void OnGet(string name)
        {
            Pokemons = await caller.GetFirst30Pokemon();

            try
            {
                Pokemon? foundPoke = Pokemons.FirstOrDefault(p => p.Name == name);

                if (foundPoke != null)
                {
                    Poke = foundPoke;
                    repo.AddPokemonToDb(foundPoke);
                }

            }
            catch (Exception ex)
            {

            }


        }


    }
}
