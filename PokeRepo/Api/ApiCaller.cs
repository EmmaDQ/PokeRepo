using Newtonsoft.Json;
using PokeRepo.Models;

namespace PokeRepo.Api
{
    public class ApiCaller
    {
        public HttpClient client { get; set; }
        public ApiCaller()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        public async Task<Pokemon> MakeCall(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Pokemon? result = JsonConvert.DeserializeObject<Pokemon>(json);

                if (result != null)
                {
                    return result;
                }
            }
            throw new Exception("Could not find Pokemon");
        }
    }
}
