using System;

namespace RPG_DUNGEON_MS.src.Entities
{
    public class Utils
    {
        public List<Hero> heros = new List<Hero>();
      
        public void GenerateMenu()
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine(" 1 - Register a new Hero ");
            Console.WriteLine(" 2 - Show all Heros ");
            Console.WriteLine(" 3 - Delete a Hero ");
            Console.WriteLine(" 4 - Finding a Hero ");
            Console.WriteLine(" 0  - End game ");
            Console.WriteLine("-----------------------");

        }

        public void AddHero(Hero newhero)
        {

            this.heros.Add(newhero);


        }

        public void CreateHero(string name, int typrhero, int level)
        {

            switch (typrhero)
            {
                case 1:
                    Knight newKnight = new Knight(name, level);
                    this.AddHero(newKnight);
                    break;
                case 2:
                    Wizard newWizard = new Wizard(name, level);
                    this.AddHero(newWizard);
                    break;
                case 3:
                    Ninja newNinja = new Ninja(name, level);
                    break;
                default:
                    throw new Exception("Opção de tipo de Heroi invalida");
            }


        }

        public void ShowHeros()
        {

            foreach (var hero in this.heros)
            {

                Console.WriteLine(hero);
            }
        }

        public int OptionHero()
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("Digita uma Opção:");
            Console.WriteLine("1 - Knight ");
            Console.WriteLine("2 - Wizard");
            Console.WriteLine("3 - Ninja ");
            Console.WriteLine("-----------------");

        
            return int.Parse(Console.ReadLine());
        }

        public void DeleteHero(string name)
        {
            int index = this.FindIndex(name);
            this.heros.RemoveAt(index); 

        }

        public int FindIndex(string name){

           return  this.heros.FindIndex(hero => hero.Name == name); 

        }

       

        public Hero FindHero(string name)
        {
            var hero = this.heros.Find(hero => hero.Name == name); 
            if(hero ==  null){
            
                return new Ninja("null",  1); 

            }else{
                return hero; 
            }
            

    
        }
    }
}