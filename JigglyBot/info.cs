using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigglyBot
{
    public class Info
    {
        String[] scores;
         
        public Info()
        {
            scores = new String[10];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = "0";
            }
        }

        public String[] getScores()
        {
            return scores;
        }

    }
}
