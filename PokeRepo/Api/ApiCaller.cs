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

                PokemonApi? result = JsonConvert.DeserializeObject<PokemonApi>(json);


                if (result != null)
                {



                    Pokemon pokemon = new Pokemon()
                    {
                        Name = result.Name,
                        Hp = result.Stats[0].BaseStat,
                        Attack = result.Stats[1].BaseStat,
                        Defence = result.Stats[2].BaseStat,
                        SpecialAttack = result.Stats[3].BaseStat,
                        SpecialDefence = result.Stats[4].BaseStat,
                        Speed = result.Stats[5].BaseStat,
                        Image = result.Sprites.Sprite,
                        Abilities =
                        {
                            new Ability()
                            {
                                Name = result.Abilities[0].AbilityApiDeep.Name
                            },
                            new Ability()
                            {
                                Name = result.Abilities[1].AbilityApiDeep.Name
                            },
                        }


                    };

                    return pokemon;
                }
            }
            throw new Exception("Could not find Pokemon");
        }
    }
}
