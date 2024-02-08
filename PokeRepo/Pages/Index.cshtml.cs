using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public PokkeRepo Repo { get; }
        public List<Pokemon> pokes = new List<Pokemon>();
        public Pokemon selectedPoke = new Pokemon();



        public async Task OnGetAsync()
        {

            pokes = Repo.GetAllPokemon().ToList();

        }

        public void OnPostAsync(string pokeName)
        {
            //return RedirectToPage("/Details", new {pokemon =  })
        }
    }
}
