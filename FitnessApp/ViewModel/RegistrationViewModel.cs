using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;
using FitnessApp.Views;
using FitnessApp.Models;
using FitnessApp.Services;
using System.Text.RegularExpressions;

namespace FitnessApp.ViewModel
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        private string _FirstName;
        public string FirstName
        {
            set
            {
                _FirstName = value; OnPropertyChanged();
            }
            get { return _FirstName; }
        }

        private string _LastName;
        public string LastName
        {
            set
            {
                _LastName = value; OnPropertyChanged();
            }
            get { return _LastName; }
        }

        private string _Mobile;
        public string Mobile
        {
            set
            {
                _Mobile = value; OnPropertyChanged();
            }
            get { return _Mobile; }
        }

        private string _Email;
        public string Email
        {
            set
            {
                _Email = value; OnPropertyChanged();
            }
            get { return _Email; }
        }

        private string _Password;
        public string Password
        {
            set
            {
                _Password = value; OnPropertyChanged();
            }
            get { return _Password; }
        }

        public Command ReturnLoginCommand { get; }
        public Command UserRegistered { get; }

        public RegistrationViewModel()
        {
            ReturnLoginCommand = new Command(GoToLogin);
            UserRegistered = new Command(RegisterUser);
        }

        public void GoToLogin()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new LoginPageView());
        }

        public void RegisterUser()
        {
            var valiate = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            var email = Email;

                if (!String.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, valiate)))
                {                 
                    App.Current.MainPage.DisplayAlert("Error", "Invalid Email ID", "OK");
                }
                else
                {
                    var fitness = new Fitness()
                    {
                        FName = FirstName,
                        LName = LastName,
                        Email = Email,
                        Password = Password,
                        Mobile = Mobile
                    };

                    FitnessService.InsertRecord(fitness);
                    App.Current.MainPage.DisplayAlert("Success", "Registered Succesfully", "OK");
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new LoginPageView());
                }
            }
    }
}
