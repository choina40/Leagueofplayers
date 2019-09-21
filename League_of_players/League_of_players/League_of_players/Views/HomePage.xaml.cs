using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace League_of_players.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        void ViewPlayers_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FindTeamPage());
        }
        void ViewTeam_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FindTeamPage());
        }
        void CreateTeam_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CreateTeamPage());
        }
    }
}