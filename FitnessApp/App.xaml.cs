using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FitnessApp.Views;

namespace FitnessApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new NavigationPage(new LoginPageView());
            //MainPage = new NavigationPage(new DashBoardView());


        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

