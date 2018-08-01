using ProjectNumber1.Views.Account;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

            Application.Current.MainPage = new ProjectNumber1.Views.Account.LoginPage();

        }

        


    }
}