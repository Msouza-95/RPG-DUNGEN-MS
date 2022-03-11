namespace RPG_DUNGEON_MS.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level)
        {
            HeroType = "Knight";
            Hp = 749 ;
            Mp = 72 ;

        }
    }
}