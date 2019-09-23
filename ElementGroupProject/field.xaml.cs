using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ElementGroupProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class field : Page
    {
        Computer c = new Computer();
        Player p = new Player();
        game g = new game();
      
        int counter = 0;
        public field()
        {
            this.InitializeComponent();
            ShowCards();
           
           
        }

        private void ShowCards()
        {
            Card1.DisplayCards(0);
            Card2.DisplayCards(1);
            Card3.DisplayCards(2);

            compCard1.DisplayCards(3);
            compCard2.DisplayCards(3);
            compCard3.DisplayCards(3);
            compCard1.IsEnabled = false;
            compCard2.IsEnabled = false;
            compCard3.IsEnabled = false;

        }


        private void GameOver()
        {
            int pScore = g.returnPlayerScore();
            int cScore = g.returnComputerScore();

            if (pScore == 4)
            {
                p.PlayerWin();
                hideandDisable();
                
            }

            else if (cScore == 4)
            {
                c.ComputerWin();
                hideandDisable();
          


            }
        }


        private void hideandDisable()
        {
            Card1.Visibility = Visibility.Collapsed;
            Card2.Visibility = Visibility.Collapsed;
            Card3.Visibility = Visibility.Collapsed;
            CompCardSelect.Visibility = Visibility.Collapsed;
            PlayerCardSelect.Visibility = Visibility.Collapsed;
            compCard1.Visibility = Visibility.Collapsed;
            compCard2.Visibility = Visibility.Collapsed;
            compCard3.Visibility = Visibility.Collapsed;

            donegame.Text = "GAME OVER!";
            


            Card1.IsEnabled = false;
            Card2.IsEnabled = false;
            Card2.IsEnabled = false;

            Returnhome.Visibility = Visibility.Visible;
            playAgain.Visibility = Visibility.Visible;
            Returnhome.IsEnabled = true;
            playAgain.IsEnabled = true;
        }



        private void Card1_Tapped(object sender, TappedRoutedEventArgs e)
        {

            CardTap(1);
            g.Compare(g.Fire, c.ComputerSelectedCard());
            counter++;
            GameOver();
            int playerScore = g.returnPlayerScore();
            int computerScore = g.returnComputerScore();
            Playerscore.Text = $"{playerScore}";
            Computerscore.Text = $"{computerScore}";

        }

        private void Card2_Tapped(object sender, TappedRoutedEventArgs e)
        {

            CardTap(2);
            g.Compare(g.Air, c.ComputerSelectedCard());
            counter++;
            GameOver();
            int playerScore = g.returnPlayerScore();
            int computerScore = g.returnComputerScore();
            Playerscore.Text = $"{playerScore}";
            Computerscore.Text = $"{computerScore}";

        }

        private void Card3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CardTap(3);
            g.Compare(g.Metal, c.ComputerSelectedCard());
            counter++;
            GameOver();
            int playerScore = g.returnPlayerScore();
            int computerScore = g.returnComputerScore();
            Playerscore.Text = $"{playerScore}";
            Computerscore.Text = $"{computerScore}";
        }




        private void CardTap( int cardnum)
        {

            CompCardSelect.DisplayCards(c.ComputerSelectedCard());
            if (cardnum == 1)
            {
                PlayerCardSelect.DisplayCards(0);
            }
            else if (cardnum == 2)
            {
                PlayerCardSelect.DisplayCards(1);
            }
            else if (cardnum == 3)
            {
                PlayerCardSelect.DisplayCards(2);
            }

            //PlayerScore_UI.Text = $"Your score: {game.PlayerScore}";
            //PlayerTurnScore_UI.Text = $"Your Turn score: {game.PlayerTurnScore}";
            //ComputerScore_UI.Text = $"Computer score: {game.ComputerScore}";
            //ComputerTurnScore_UI.Text = $"Computer Turn score: {game.ComputerTurnScore}";
        }

        private void Returnhome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void playAgain_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(field));
        }
    }
}
