using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eye_Tractor.Services;
using Eye_Tractor.Views;

namespace Eye_Tractor
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
    }
}
