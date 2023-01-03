using System;
using FitnessApp.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FitnessApp.Services
{
	public class FitnessService
	{
		public FitnessService()
		{
		}

        public static void InsertRecord(Fitness fitness)
        {
            var cn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            cn.Insert(fitness);
            cn.Close();
        }


        public static List<Fitness> ReturnRecord()
        {
            var cn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            var fitness = cn.Table<Fitness>().ToList();
            cn.Close();
            return fitness;

        }

        public static Fitness GetIndividualResult(string user, string pass)
        {
            var cn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            var fitness = cn.Table<Fitness>();

            var credentials = fitness.Where(u => u.Email == user
             && u.Password == pass).FirstOrDefault();

            return credentials;
        }

        public static Fitness GetIndividualEmail(string user)
        {
            var cn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            var fitness = cn.Table<Fitness>();

            var email = fitness.Where(u => u.Email == user).FirstOrDefault();


            return email;
        }


        public static void createTable()
        {
            var cn = DependencyService.Get<ISQLiteConnection>().GetConnection();
            cn.CreateTable<Fitness>();
            cn.Close();
            App.Current.MainPage.DisplayAlert("Hello", "ok", "cancel");
        }
    }
}

