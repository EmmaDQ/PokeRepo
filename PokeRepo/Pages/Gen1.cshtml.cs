using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class Gen1Model : PageModel
    {
        public string? Name { get; set; }
        public ApiCaller caller { get; private set; }
        public Pokemon Poke { get; private set; }

        public Gen1Model()
        {

        }
        public async void OnGet()
        {

        }

        public async Task OnPostAsync()
        {
            string name =

            caller = new ApiCaller();
            Poke = await caller.MakeCall(name.ToLower());

        }
    }
}
