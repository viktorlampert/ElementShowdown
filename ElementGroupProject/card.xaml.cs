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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ElementGroupProject
{
    public sealed partial class card : UserControl
    {
        public card()
        {
            this.InitializeComponent();
            HideCards();
        }
        public void HideCards()
        {
            Backcard.Visibility = Visibility.Collapsed;
            Firecard.Visibility = Visibility.Collapsed;
            Aircard.Visibility = Visibility.Collapsed;
            Metalcard.Visibility = Visibility.Collapsed;

        }

        public void DisplayCards(int card)
        {
            HideCards();
            switch (card)
            {
           
                case 0:
                    Firecard.Visibility = Visibility.Visible;
                    break;
                case 1:
                    Aircard.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Metalcard.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Backcard.Visibility = Visibility.Visible;
                    break;
           
            }
        }
    }
}
