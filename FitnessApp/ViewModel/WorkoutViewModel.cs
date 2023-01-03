using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using FitnessApp.Views;

namespace FitnessApp.ViewModel
{
    public class WorkoutViewModel : INotifyPropertyChanged
    {       

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public Command HomeCall { get; }

        public WorkoutViewModel()
        {
            HomeCall = new Command(RedirectToHome);
        }

        public void RedirectToHome()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new DashBoardView());
        }

    }
}

