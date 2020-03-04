using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Services;
using App1.Views;

namespace App1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            var q = new MainPage();
            q.Children.Add(new BlanckPage(new Page1()));
            q.Children.Add(new BlanckPage(new Page2()));
            var o = new BlanckPage(new Page3());
            q.Children.Add(o);
            MainPage = q;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
