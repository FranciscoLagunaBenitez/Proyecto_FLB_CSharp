using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public enum Genres
    {
        Action = 0,
        Strategy = 1,
        RPG = 2,
        Puzzles = 3,
        Adventure = 4,
        Simulation = 5,
        Survival_Horror = 6,
        Sandbox = 7
    }

    public enum Platforms
    {
        PC = 0,
        MAC = 1,
        Linux = 2,
        PS4 = 3,
        XBOXONE = 4
    }

    public class Game
    {
        #region Members

        private string name;
        public string Name
        {
            get { return name; }
        }

        private Genres genre;
        public Genres Genre
        {
            get { return genre; }
        }

        private List<Platforms> platforms;
        public List<Platforms> PlatForms
        {
            get { return platforms; }
        }

        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
        }

        private Dictionary<Platforms, Ranking> rankings;
        public Dictionary<Platforms, Ranking> Rankings
        {
            get { return rankings; }
        }

        #endregion

        public Game(string name, Genres genre, List<Platforms> platforms, int releaseDate, Dictionary<Platforms, Ranking> rankings)
        {
            this.name = name;
            this.genre = genre;
            this.platforms = platforms;
            this.releaseDate = releaseDate;
            this.rankings = rankings;
        }


        public Game(string data, Ranking ranking)
        {
            string[] splittedData = data.Split('-');
            string[] splittedDataPlatforms = splittedData[3].Split(',');
            List<Platforms> platforms = new List<Platforms>();

            foreach (string s in splittedDataPlatforms)
            {
                Platforms p = (Platforms)Enum.Parse(typeof(Platforms), s);
                platforms.Add(p);
            }

            this.name = splittedData[0];
            this.genre = (Genres)Enum.Parse(typeof(Genres), splittedData[1]);
            this.releaseDate = int.Parse(splittedData[2]);
            this.platforms = platforms;


        }

        public override bool Equals(object obj)
        {
            if (obj is Game)
            {
                Game aux = (Game)obj;
                return aux.Name == this.Name;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string s = "--- " + Name + "(" + ReleaseDate + ") - ";
            foreach (Platforms p in platforms)
            {
                s += p + ", ";
            }
            //Esta funcion quita el espacio y la coma del final de la cadena s
            s = s.TrimEnd(' ', ',');
            s += " - " + Genre + " ---\n Rankings: \n";
            
            foreach (Ranking r in Rankings.Values)
            {
                s += r.Name + " (" + r.Scores.Count + ")\n";
            }

            return s;

        }
    }
}
