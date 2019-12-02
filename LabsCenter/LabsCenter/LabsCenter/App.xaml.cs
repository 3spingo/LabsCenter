using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LabsCenter.Services;
using LabsCenter.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace LabsCenter
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
            AppCenter.Start("android=8a2eba08-a41d-4765-9e55-2231026c41e3;" +
                              "ios=cae03651-4a45-424c-89d8-78065f56a7f3;",
                              typeof(Analytics), typeof(Crashes));
            Crashes.GenerateTestCrash();
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
