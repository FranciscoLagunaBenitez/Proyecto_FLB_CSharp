using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Ranking
    {
        #region Members

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Score> scores;
        public List<Score> Scores
        {
            get { return scores; }
        }

        #endregion

        public Ranking(string name, List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }

        public Ranking(string data)
        {
            List<Score> scores = new List<Score>();
            string[] firstSplittedData = data.Split('-', ',');
            for (int i=2; i >= firstSplittedData.Length; i++) { 
                foreach (string s in firstSplittedData)
                {
                    Score sc = new Score(firstSplittedData[i]);
                    scores.Add(sc);
                }
            }

            this.name = firstSplittedData[1];
            this.scores = scores;
        }

        public override string ToString()
        {
            string s ="Ranking: " + Name + "\n";
            int i = 1;
            //Ordena la lista segun la puntuacion de mayor a menor
            //Poner al principio System.Linq para que funcione
            IEnumerable<Score> scoreSorted = scores.OrderByDescending(score => score.Points);
            foreach (Score score in scoreSorted)
            {
                s += i + ". "+ score.NickName + " - " + score.Points + "\n";
                i++;                
            }
            return s;
        }       
    }
}
