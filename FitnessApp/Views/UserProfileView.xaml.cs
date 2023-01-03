using System;
using System.Collections.Generic;
using FitnessApp.Services;

using Xamarin.Forms;

namespace FitnessApp.Views
{
    public partial class UserProfileView : ContentPage
    {
        public UserProfileView()
        {
            InitializeComponent();
        }

        public UserProfileView(string Email)
        {
            InitializeComponent();
            var emails = FitnessService.GetIndividualEmail(Email);
            EntryName.Text = emails.FName;
            EntryEmail.Text = emails.Email;
            EntryPhone.Text = emails.Mobile;
        }

        void HomeBtn_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new DashBoardView());
        }
    }
}
