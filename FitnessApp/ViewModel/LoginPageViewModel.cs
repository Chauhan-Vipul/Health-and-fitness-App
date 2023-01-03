using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using FitnessApp.Services;
using FitnessApp.Views;

namespace FitnessApp.ViewModel
{
	public class LoginPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

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

        public Command NewUserCommand { get; }
        public Command LoginCommand { get; }

        public LoginPageViewModel()
        {
            NewUserCommand = new Command(NewUser);
            LoginCommand = new Command(Login);
        }

        public void NewUser()
        {
            //FitnessService.createTable();            
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new RegistrationView());
        }

        public void Login()
        {
           
            var credentials = FitnessService.GetIndividualResult(Email, Password);

                if (credentials != null)
                {
                    //Navigation.PushModalAsync(new HomePage(UserName.Text));
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new DashBoardView(Email));
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Failure", "Wrong Username or Password", "OK");            
                }
        }
    }
}

