using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DogFactsSamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
        public static MeFactDb Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new MeFactDb();
                    prefillDatabase();

                }
                return _database;
            }
        }
        static void prefillDatabase()
        {
            _database.ClearAllAsync();
            List<MeFactData> items = new List<MeFactData>();
            items.Add(new MeFactData() { TheFact = "Noodles", ShortFact = "My Favorite Food", TheImage = "" });
            items.Add(new MeFactData() { TheFact = "South Carolina", ShortFact = "My Favorite State", TheImage = "" });
            items.Add(new MeFactData() { TheFact = "Milky Ways", ShortFact = "My Favorite Candy", TheImage = "" });
            items.Add(new MeFactData() { TheFact = "Visual Basic", ShortFact = "My Least Favorite Programming Language", TheImage = "" });
            items.Add(new MeFactData() { TheFact = "blue", ShortFact = "The Colors of my Eyes", TheImage = "" });
            _database.InsertList(items);

        }


    }
}
