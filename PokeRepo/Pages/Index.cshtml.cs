using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public Pokemon Test { get; set; }
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
    }
}
