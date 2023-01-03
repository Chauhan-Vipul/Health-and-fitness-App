using System;
using System.Collections.Generic;
using SQLite;
using FitnessApp.Models;
using FitnessApp.Services;
using FitnessApp.Views;

using Xamarin.Forms;

namespace FitnessApp.Views
{
    public partial class DashBoardView : ContentPage
    {
        public String Email = "";
        public DashBoardView()
        {
            InitializeComponent();
            SingleView.ItemsSource = new Transformations().GetResult();
        }
        public DashBoardView(string email)
        {
            InitializeComponent();
            SingleView.ItemsSource = new Transformations().GetResult();
            this.Email = email;
            var emails = FitnessService.GetIndividualEmail(email);
            EntryName.Text = $"Hello {emails.FName}";

        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new UserProfileView(this.Email));
        }
    }
}

