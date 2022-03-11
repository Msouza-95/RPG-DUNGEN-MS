namespace RPG_DUNGEON_MS.src.Entities
{
    public abstract class Hero
    {

        
        public string Name { get; set; }
        public int Level { get; set;}
        public string HeroType { get; set;}
        public int Hp { get; set;}
        public int Mp { get; set;}
        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
            HeroType = "default";
           
            
        }

        public override string ToString(){
            return 
            $@"
            -------------------------
            Nome: {this.Name }  
            Tipo: {this.HeroType }
            Level: {this.Level}
            HP: {this.Hp}
            MP: {this.Mp}
            --------------------------";

        }

        public virtual string Attack(){
            return  this.Name + " Attacked with swrod "; 

        }
    }
}