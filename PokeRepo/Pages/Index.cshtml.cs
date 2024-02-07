using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public PokemonApi Test { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            ApiCaller caller = new ApiCaller();
            Test = await caller.MakeCall("1");


        }

        public void OnPostAsync(string pokeName)
        {
            //return RedirectToPage("/Details", new {pokemon =  })
        }
    }
}
