using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Code_Strange_News.Services;
using Code_Strange_News.Views;

namespace Code_Strange_News
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
