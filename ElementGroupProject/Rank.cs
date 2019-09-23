using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ElementGroupProject
{
    class Rank
    {
        

        public string playerName { get; set; }

        public int officialRank = 1;
        

        public void AddWin()
        {
            
            officialRank++;
        }

    }
}

