using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ElementGroupProject
{
    class game
    {
        public int Metal = 2; //Metal element attribute cards (beats Earth)

        public int Air = 1; //Wind element attribute cards (beats Flame)


        public int Fire = 0; //Flame element attribute cards (beats Metal)


        Player p = new Player();
        Computer c = new Computer();
       
        public void Compare(int playerCard, int computerCard) //Method that is called to compare card attributes
        {
            if (playerCard == Metal && computerCard == Air)
            {
                p.playerScore += 1;


            }
            else if (playerCard == Air && computerCard == Fire)
            {

                p.playerScore += 1;

            }

            else if (playerCard == Fire && computerCard == Metal)
            {

                p.playerScore += 1;

            }
            else if (playerCard == Metal && computerCard == Fire)
            {

                c.computerScore += 1;

            }
            else if (playerCard == Air && computerCard == Metal)
            {

                c.computerScore += 1;

            }

            else if (playerCard == Fire && computerCard == Air)
            {

                c.computerScore += 1;

            }
            else if (playerCard == Air && computerCard == Air)
            {
                c.computerScore += 0;
                p.playerScore += 0;
            }
            else if (playerCard == Fire && computerCard == Fire)
            {
                c.computerScore += 0;
                p.playerScore += 0;
            }
            else if (playerCard == Metal && computerCard == Metal)
            {
                c.computerScore += 0;
                p.playerScore += 0;
            }



        }
        public int returnPlayerScore()
        {
            return p.playerScore;
        }
        public int returnComputerScore()
        {
            return c.computerScore;
        }
    }
}

