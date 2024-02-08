using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class Gen1Model : PageModel
    {
        private readonly IPokkeRepo repo;
        public List<Pokemon> Pokemons { get; set; }
        public List<Pokemon> DbPokemons { get; set; }
        public Gen1Model(IPokkeRepo repo)
        {
            this.repo = repo;
        }
        public async void OnGet()
        {
            Pokemons = (List<Pokemon>)repo.GetAllPokemon();
        }
    }
}
