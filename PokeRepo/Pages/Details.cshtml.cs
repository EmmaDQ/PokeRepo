using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {

        public Pokemon Poke { get; set; }
        public ApiCaller caller { get; set; }
        public readonly IPokkeRepo repo;

        public DetailsModel(IPokkeRepo repo)
        {
            this.repo = repo;
        }
        public void OnGet(string name)
        {
            Pokemon pokk = repo.GetByNameWithAbilities(name);
            Poke = pokk;

        }


    }
}
