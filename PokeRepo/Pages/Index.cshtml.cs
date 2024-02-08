using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public PokkeRepo Repo { get; }
        public List<Pokemon> pokes { get; set; } = new List<Pokemon>();
        public Pokemon selectedPoke = new Pokemon();



        public async Task OnGetAsync()
        {
            //try
            //{
            //    pokes = Repo.GetAllPokemon().ToList();
            //}
            //catch (Exception ex)
            //{

            //}

        }

        public void OnPostAsync(string pokeName)
        {
            //return RedirectToPage("/Details", new {pokemon =  })
        }
    }
}
