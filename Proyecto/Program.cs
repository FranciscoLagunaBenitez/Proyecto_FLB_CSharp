using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player("Latory", "latory96@gmail.com", 0);
            Player p2 = new Player("Pequod56", "pequod56@gmail.com", 0);
            Player p3 = new Player("jairo_hollow", "jairo_hollow@gmail.com", 0);
            Player p4 = new Player("Aureo196", "Aureo196@gmail.com", 0);

            Score s1 = new Score("Latory", 20000);
            Score s2 = new Score("Pequod56", 200);
            Score s3 = new Score("jairo_hollow", 17200);
            Score s4 = new Score("Aureo196", 10000);
            Score s5 = new Score("Latory", 0);
            Score s6 = new Score("Pequod56", 50);
            Score s7 = new Score("jairo_hollow", 10);
            Score s8 = new Score("Aureo196", 24);

            List<Score> listaPuntuaciones = new List<Score>() { s1, s2, s3, s4};
            List<Score> listaMuertes = new List<Score>() { s5, s6, s7, s8 };
            List<Player> jugadores = new List<Player>() { p1, p2, p3, p4 };
            

            Ranking Metal_slug_puntuaciones = new Ranking("Puntos", listaPuntuaciones);
            Ranking Metal_slug_muertes = new Ranking("Muertes", listaMuertes);

            List<Platforms> Metal_Slug_Platforms = new List<Platforms>() { Platforms.PC, Platforms.PS4, Platforms.XBOXONE};

            Dictionary<Platforms, Ranking> ranking_MS = new Dictionary<Platforms, Ranking>();

            ranking_MS.Add(Platforms.PC, Metal_slug_puntuaciones);
            ranking_MS.Add(Platforms.PS4, Metal_slug_muertes);

            Game metal_slug = new Game("Metal Slug", Genres.Action, Metal_Slug_Platforms, 1994, ranking_MS);

            List<Platforms> tew2Platforms = new List<Platforms>() { Platforms.PS4, Platforms.XBOXONE, Platforms.PC, };

            Score s9 = new Score("Latory", 10);
            Score s10 = new Score("Pequod56", 77);

            List<Score> tew2_listamuertes = new List<Score>() { s9, s10 };

            Ranking tew2_muertes = new Ranking("Muertes", tew2_listamuertes);

            Dictionary<Platforms, Ranking> ranking_TEW2 = new Dictionary<Platforms, Ranking>();

            ranking_TEW2.Add(Platforms.PC, tew2_muertes);


            Game the_evil_within2 = new Game("The Evil Within 2", Genres.Survival_Horror, tew2Platforms, 2017, ranking_TEW2);

            List<Game> listOfGames = new List<Game>() { metal_slug, the_evil_within2};

            //Console.WriteLine(metal_slug);

            GameServices.Players.Add(p1);
            GameServices.Players.Add(p2);
            GameServices.Players.Add(p3);
            GameServices.Players.Add(p4);

            GameServices.Games.Add(metal_slug);
            GameServices.Games.Add(the_evil_within2);

            //Console.WriteLine(GameServices.OldestGame());
            //Console.WriteLine(GameServices.PointsCountByName("The Evil Within 2", "Muertes"));
            //Console.WriteLine(GameServices.CountByGenre(Genres.Survival_Horror));
            //Console.WriteLine(GameServices.GameByPointsCount());
            //Console.WriteLine(GameServices.AnyGameWithCallOnItsName());
            //GameServices.GamesPlayedBySomeone("Latory");
            //GameServices.HowManyGamesHavePlayedEveryone();

            //GameServices.Export();
            //GameServices.Import();

            //Console.WriteLine(GameServices.AnyGameWithCallOnItsName(listOfGames));

            //GameServices.GamesPlayedBySomeone(listOfGames, "Aureo196");

            //GameServices.HowManyGamesHavePlayedEveryone(listOfGames, jugadores);
            //Consola.RealizarTest();

            Console.ReadLine();

        }
    }
}
