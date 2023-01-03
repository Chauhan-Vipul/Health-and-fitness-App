using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using FitnessApp.Services;
using FitnessApp.Models;
using System.Threading.Tasks;
using FitnessApp.Views;

namespace FitnessApp.ViewModel
{
    public class DashBoardViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public Command DietChart { get; }
        public Command Transformations { get; }
        public Command BMICalculate { get; }

        public DashBoardViewModel()
        {
            var transformations = new Transformations().GetResult();
            DietChart = new Command(Diet);
            Transformations = new Command(Transformation);
            BMICalculate = new Command(BMI);

        }

        public void Diet()
        {
            CheckWaitAsync();
        }

        public void Transformation()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new WorkoutView());
        }

        public void BMI()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new BMIView());
        }

        public async Task CheckWaitAsync()
         {

            bool value = await App.Current.MainPage.DisplayAlert("Diet", "Choose Your Diet", "Weight Loss", "Weight Gain");
            if (value)
            {            
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new WeightLossView());
            }
            else
            {            
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new WeightGainView());
            }

         }        
    }      
}
