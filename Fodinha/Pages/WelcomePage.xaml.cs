using System;
using Xamarin.Forms;

namespace Fodinha.Pages
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void NavigationButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PlayersPage());
        }
    }
}
