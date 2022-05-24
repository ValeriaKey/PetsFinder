using PetsFinder.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetsFinder
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "pets.db";
        public static PetRepository database;

        public static PetRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PetRepository(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));

                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
           MainPage = new NavigationPage (new LoginUI());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
