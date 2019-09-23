using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ElementGroupProject
{
    class Player
    {
        Rank r = new Rank();
        public int playerScore { get; set; } // keeps track of player score

        public void PlayerWin()
        {
           
            r.AddWin();
            MessageDialog md = new MessageDialog("Players Wins!");
            md.ShowAsync();

            // need to add code to navigate back to mainpage
            
        }







    }
}

