using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using League_of_players.Models;
using League_of_players.Repository;

namespace League_of_players.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class CreateTeamPage : ContentPage
    {
        public Item Item { get; set; }

        private TeamRepository teamRepository { get; set; }

        public CreateTeamPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            teamRepository = new TeamRepository(App.Database.database);
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void AddTeam(object sender, EventArgs e)
        {
            bool validate = true;
            string Message = string.Empty;

            if (Mode.SelectedIndex == -1)
            {
                validate = false;
                Message = "Mode is required\n";
            }
            if (MinimumTier.SelectedIndex == -1)
            {
                validate = false;
                Message = Message + "Minimum Tier is required\n";
            }
            if (MaximumTier.SelectedIndex == -1)
            {
                validate = false;
                Message = Message + "Maximum Tier is required\n";
            }

            if (validate)
            {
                await teamRepository.SaveItemAsync(new Team
                {
                    Name = Title.Text,
                    TeamMaster = App.username,
                    Description = Description.Text,
                    Mode = Mode.SelectedItem.ToString(),
                    Size = 1,
                    MinTier = MinimumTier.SelectedItem.ToString(),
                    MaxTier = MaximumTier.SelectedItem.ToString()
                });

                Title.Text = Description.Text = string.Empty;
                Mode.SelectedIndex = MinimumTier.SelectedIndex = MaximumTier.SelectedIndex = -1;

                await Navigation.PopAsync();            
            }
            else
            {
                await DisplayAlert("", Message, "OK");
            }
        }
    }
}