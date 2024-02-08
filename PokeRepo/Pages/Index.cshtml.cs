using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {



        }

        public void OnPostAsync(string pokeName)
        {
            //return RedirectToPage("/Details", new {pokemon =  })
        }
    }
}
