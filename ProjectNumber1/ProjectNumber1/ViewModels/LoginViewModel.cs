using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using ProjectNumber1.Views.Account;

namespace ProjectNumber1.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "rodrigogeronimo@outlook.com")
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                Application.Current.MainPage = new ProjectNumber1.Views.Main();

                


                //MasterDetailPage fpm = new MasterDetailPage();
                //fpm.Master = new ProjectNumber1.Views.MasterPage();
                //fpm.Detail = new NavigationPage(new ProjectNumber1.Views.Device.DeviceTabbedPage());
                //Application.Current.MainPage = fpm;
            }

        }
    }
}
