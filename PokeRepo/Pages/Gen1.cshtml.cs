using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class Gen1Model : PageModel
    {
        public string? Name { get; set; }
        public ApiCaller caller { get; private set; }
        public Pokemon Poke { get; private set; }

        private readonly IPokkeRepo repo;

        public Gen1Model(IPokkeRepo repo)
        {
            this.repo = repo;
        }
        public async void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string pokeName)
        {


            caller = new ApiCaller(repo);
            Poke = await caller.MakeCall(pokeName.ToLower());



            repo.AddPokemonToDb(Poke);

            return RedirectToPage("/Details", new { Poke.Name });

        }
    }
}
