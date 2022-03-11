using System;
using RPG_DUNGEON_MS.src.Entities;

namespace RPG_DUNGEON_MS
{

    class Program
    {

        static void Main(string[] args)
        {


            Utils utils = new Utils();


            int condition = 10;

            while (condition != 0)
            {
                utils.GenerateMenu();
                condition = int.Parse(Console.ReadLine());

                switch (condition)
                {

                    case 1:
                        var typeHero = utils.OptionHero();

                        Console.WriteLine("informe o Nome do Heroi");
                        var name = Console.ReadLine();

                        Console.WriteLine("Digite o level Heroi");
                        if(! int.TryParse(Console.ReadLine(), out int level)){
                            throw new ArgumentException("O level precisa ser Inteiro");
                        }

                        if (name != null)
                        {
                            utils.CreateHero(name, typeHero, level);
                        }

                        Console.WriteLine("Criado com Sucesso!");

                        break;
                    case 2:
                        // Show all Heros 
                       var heros = utils.ShowHeros(); 
                       foreach (var hero in heros)
                       {
                           if(hero.Name == null){
                               continue;
                           }
                           Console.WriteLine(hero);
                       }
                        break;
                    case 3:
                        // TDelete a Hero 
                        break;
                    case 4:
                        //  Finding a Hero 
                        Console.WriteLine("Digite o nome do Heroi que deseja buscar");
                        var findName = Console.ReadLine();
                        Console.WriteLine(utils.FindHero(findName));
                        break;
                    case 0:
                        // 0  - End game "
                        Console.WriteLine("Fim de Game");
                        break;
                    default:
                        throw new Exception("opção invalida");

                }



            }

        }

    }
}



