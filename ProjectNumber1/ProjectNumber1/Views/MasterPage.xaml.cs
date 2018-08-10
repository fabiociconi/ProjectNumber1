using System;
using Xamarin.Forms;
using ProjectNumber1.Views.Account;

namespace ProjectNumber1.Views
{

    public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();
        }

        private void ViewAccountButton_Clicked(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new ProfilePage());
        }

        private void SignOutButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }






    }
}