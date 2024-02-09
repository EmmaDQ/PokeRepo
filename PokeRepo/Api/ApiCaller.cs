using Newtonsoft.Json;
using PokeRepo.Models;
using PokeRepo.Services;

namespace PokeRepo.Api
{
    public class ApiCaller
    {
        public HttpClient client { get; set; }
        public readonly IPokkeRepo repo;
        public ApiCaller(IPokkeRepo repo)
        {
            client = new HttpClient();

            this.repo = repo;

            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        public async Task<List<Pokemon>> GetFirst30Pokemon()
        {
            List<Pokemon> pokemonList = new List<Pokemon>();

            for (int i = 1; i <= 30; i++)
            {
                string url = $"{i}";
                Pokemon pokemon = await MakeCall(url);
                pokemonList.Add(pokemon);
            }

            return pokemonList;
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

                    List<Ability> resultAbilities = new();
                    foreach (var ability in result.Abilities)
                    {
                        Ability existingAbility = repo.GetAbilityByName(ability.AbilityApiDeep.Name);

                        if (existingAbility != null)
                        {
                            new Ability()
                            {
                                Id = existingAbility.Id,
                            };

                            resultAbilities.Add(existingAbility);
                        }
                        else
                        {

                            resultAbilities.Add(new Ability()
                            {
                                Name = ability.AbilityApiDeep.Name,
                            });
                        }
                    }


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


                        Abilities = resultAbilities,



                    };

                    return pokemon;
                }
            }
            throw new Exception("Could not find Pokemon");
        }
    }
}
