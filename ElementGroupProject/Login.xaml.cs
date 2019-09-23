using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class Login : Page
    {
        Rank r = new Rank();

        public string grabName { get; set; }

        public Login()
        {
            this.InitializeComponent();
        }

        private async void gotofiled_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(field));

            grabName = Username.Text;

            StorageFolder dataFolder = ApplicationData.Current.LocalFolder;

            await dataFolder.CreateFileAsync("Rankings.txt", CreationCollisionOption.ReplaceExisting);

            StorageFile rankingFile = await dataFolder.GetFileAsync("Rankings.txt");
            await FileIO.AppendTextAsync(rankingFile, $"Rank: {r.officialRank}: Name:{grabName }");


        }


    }
}

