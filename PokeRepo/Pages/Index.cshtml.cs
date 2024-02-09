using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPokkeRepo? Repo;
        public List<Pokemon>? pokes { get; set; } = new List<Pokemon>();
        public Pokemon selectedPoke = new Pokemon();
        public string message = "";

        public IndexModel(IPokkeRepo repo)
        {
            Repo = repo;
        }

        public void OnGet()
        {


        }

        public void OnPost()
        {

            try
            {
                if (Repo.GetAllPokemon().Any())
                {
                    foreach (var pokee in Repo.GetAllPokemon())
                    {
                        pokes.Add(pokee);
                    }
                }




            }
            catch (Exception ex)
            {
                message = "No pokémon has been viewed yet!";
            }

            Page();
        }
    }
}
