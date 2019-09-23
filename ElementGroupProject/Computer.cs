using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ElementGroupProject
{
    class Computer
    {
        public int[] computerHand = new int[4]; // computer hand


        public int computerScore { get; set; }

        public void ComputerWin()
        {
            
            
                MessageDialog md = new MessageDialog("Computer Wins!");
                md.ShowAsync();
                // need to add code to navigate back to mainpage
            
        }

        public int ComputerSelectedCard()
        {
            Random r = new Random();
            int randomSelect = r.Next(0, 3);
            return randomSelect;

        }







    }
}

