using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {

        public Pokemon Poke { get; set; }
        public ApiCaller caller { get; set; }


        public async void OnGet(string name)
        {




        }


    }
}
