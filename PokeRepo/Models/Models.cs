namespace PokeRepo.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
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
