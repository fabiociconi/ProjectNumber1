using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectNumber1.Views.Account;
using ProjectNumber1.Views;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ProjectNumber1
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
            MainPage = new LoginPage();
            //MainPage = new Main();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
