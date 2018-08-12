using Newtonsoft.Json;
using ProjectNumber1.Helpers;
using ProjectNumber1.Models.Account;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNumber1.Services
{
    public class ApiServices
    {
        public async Task<bool> LoginAsync(string email)
        {
            var client = new HttpClient();
            Uri uri = new Uri(Constants.RestUrl + "/api/Login");// ver o endereco
            LoginModel login = new LoginModel
            {
                Email = email,
            };
            try
            {
                string json = JsonConvert.SerializeObject(login);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                var responseStr = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    //guarda na classe settings para ficar guardado
                    Settings.AccessToken = responseStr;

                    return true;
                }
                else
                {
                    {
                        await App.Current.MainPage.DisplayAlert("Invalid", "Login failure", "Try again");                    
                        return false;
                    }

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);

            }
            return false;
        }
    }
}
