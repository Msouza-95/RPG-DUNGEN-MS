namespace RPG_DUNGEON_MS.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level) : base(name, level)
        {   
            HeroType = "Ninja";
            Hp = 574;
            Mp = 89;
        }
    }
}