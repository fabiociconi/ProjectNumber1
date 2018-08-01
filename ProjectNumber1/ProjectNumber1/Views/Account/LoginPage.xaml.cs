using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectNumber1.Views;
using ProjectNumber1.ViewModels;

namespace ProjectNumber1.Views.Account
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Account was not found. Try again.", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }

    }
}