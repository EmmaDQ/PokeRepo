using Newtonsoft.Json;

namespace PokeRepo.Models
{
    public class PokemonApi
    {

        public string Name { get; set; } = null!;

        public List<Stats> Stats { get; set; }
        public List<AbilityApi> Abilities { get; set; } = new();
        public Sprites? Sprites { get; set; }

    }

    public class AbilityApi
    {
        [JsonProperty("ability")]
        public AbilityApiDeep AbilityApiDeep { get; set; }
    }
    public class AbilityApiDeep
    {
        public string Name { get; set; }
    }

    public class Stats
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

    }
    public class Sprites
    {
        [JsonProperty("front_default")]
        public string? Sprite { get; set; }
    }


    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public int SpecialDefence { get; set; }
        public int SpecialAttack { get; set; }
        public List<Ability> Abilities { get; set; } = new List<Ability>();


    }

    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }

}
