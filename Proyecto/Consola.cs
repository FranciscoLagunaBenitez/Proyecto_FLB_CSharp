using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Consola
    {

        public static void RealizarTest()
        {
            Console.WriteLine("Please, select one of the following commands:\n");
            Console.WriteLine("import, export, oldest, scoreCount, gamesCountByGenre, gamesByPlayer");

            string res = Console.ReadLine();

            // Pasar a minusculas la frase
            res = res.ToLower();     

            switch (res)
            {
                case "import":
                    GameServices.Import();
                    break;
                case "export":
                    GameServices.Export();
                    break;
                case "oldest":
                    Console.WriteLine(GameServices.OldestGame());
                    break;
                case "scorecount":
                    Console.WriteLine("Write the name of the game: ");
                    string valor1 = Console.ReadLine();
                    Console.WriteLine("Write the name of the ranking list: ");
                    string valor2 = Console.ReadLine();
                    Console.WriteLine(GameServices.PointsCountByName(valor1, valor2)); 
                    break;
                case "gamescountbygenre":
                    Console.WriteLine("Write the name of the genre: ");
                    string valor3 = Console.ReadLine();
                    Console.WriteLine(GameServices.CountByGenre((Genres)Enum.Parse(typeof(Genres), valor3)));
                    break;
                case "gamesbyplayer":
                    GameServices.HowManyGamesHavePlayedEveryone();
                    break;
                default:
                    Console.WriteLine("Sorry, but the command you wrote cannot be found on our list.");
                    break;
            }
        }
    }
}
