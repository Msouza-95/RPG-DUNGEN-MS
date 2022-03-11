using System;

namespace RPG_DUNGEON_MS.src.Entities
{
    public class Utils
    {
        public Hero[] heros = new Hero[100];
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

            for (int i = 0; i < this.heros.Length; i++)
            {
                if (heros[i] != null)
                {
                    continue;
                }
                this.heros[i] = newhero;
                break;
            }

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

        public Hero[] ShowHeros()
        {

            return this.heros;
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

            for (int i = 0; i < this.heros.Length; i++)
            {
                if (this.heros[i].Name == name)
                {
                    // this.heros[i] = null; 

                }
            }
        }

        public int FindIndex(string name)
        {

            for (int i = 0; i < this.heros.Length; i++)
            {
                if (this.heros[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public Hero FindHero(string name){

            int index = this.FindIndex(name);

            return this.heros[index]; 
        }
    }
}