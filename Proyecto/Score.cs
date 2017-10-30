using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Score 
    {
        #region Members

        private string nickname;
        public string NickName
        {
            get { return nickname; }
        }

        private int points;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        #endregion

        public Score(string nickname, int points)
        {
            this.nickname = nickname;
            if (points > 0) { 
                this.points = points;
            }
            else { this.points = 0; }
        }

        public Score(string data)
        {
            string[] secondsplittedData = data.Split(',');
            string[] thirdsplittedData = data.Split('=');
            this.nickname = secondsplittedData[0];
            this.points = int.Parse(secondsplittedData[1]);
        }

        public override string ToString()
        {
            string s = NickName + " - " + Points;
            return s;
        }
    }
}
