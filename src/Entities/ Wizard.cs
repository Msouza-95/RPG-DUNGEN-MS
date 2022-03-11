namespace RPG_DUNGEON_MS.src.Entities
{
    public class Wizard : Hero
    {


        public Wizard(string name, int level) : base(name, level)
        {
            HeroType = "Wizard";
            Hp =601 ;
            Mp = 482;
        }

        public override string Attack(){
            return  this.Name + " Attacked with magic "; 

        }

        public string Attack( int bonus){
            return  this.Name + $" Attacked magic with bonus of { bonus}"; 

        }
        
    }


}