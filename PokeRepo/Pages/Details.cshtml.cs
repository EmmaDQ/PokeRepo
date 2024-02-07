using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {
        public Pokemon poke { get; set; } = new Pokemon();
        public void OnGet(Pokemon poke)
        {
            this.poke = poke;
        }

        public void OnPost()
        {

        }

    }
}
