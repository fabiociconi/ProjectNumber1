using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using ProjectNumber1.Views.Account;
using ProjectNumber1.Services;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Acr.UserDialogs;

namespace ProjectNumber1.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;

        private ApiServices _apiServices = new ApiServices();
        public bool IsBusy { get; set; }

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
            SubmitCommand = new Command( OnSubmitAsync);
        }
        public async void OnSubmitAsync()
        {
            ///
            //

            if (IsBusy)
                return;
            using (var objDialog = UserDialogs.Instance.Loading("Loading..", null, null, true, MaskType.Black))
            {
                try
                {
                    IsBusy = true;
                    await _apiServices.LoginAsync(email);
                }
                catch (Exception ex) when (ex is WebException || ex is HttpRequestException)
                {
                    await Application.Current.MainPage.DisplayAlert("Communication error", "Error", "Try again");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error in: {ex}");
                }
                finally
                {
                    IsBusy = false;
                }
                ///retirar isso//
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
}
