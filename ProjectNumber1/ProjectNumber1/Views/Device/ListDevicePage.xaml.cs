using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectNumber1.Models.Devices;
using System.Net.Http;
using Newtonsoft.Json;
using ProjectNumber1.Services;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ProjectNumber1.Views.Device
{
	public partial class ListDevicePage : ContentPage
	{
        private const int userId = 1;
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<Models.Devices.Device> _devices;
        public string Url;
        public ListDevicePage ()
		{
            InitializeComponent();
            //DevicesListView.BindingContext = DeviceModel.GetAllDevices();
        }

        protected override async void OnAppearing()
        {
            Url = "http://" + Constants.RestUrl + "/api/getWeatherData?userId=" + userId;
            //Url = "http://jsonplaceholder.typicode.com/posts?userId=1";
            string content = await _client.GetStringAsync(Url);

            List<Models.Devices.Device> devices = (from token in JsonConvert.DeserializeObject<JObject>(content)["payload"].Children() select JsonConvert.DeserializeObject<Models.Devices.Device>(token.ToString())).ToList();
            foreach (Models.Devices.Device device in devices)
            {
                Console.WriteLine(device);
                Console.ReadLine();
            }
            //   List<Models.Devices.Device> devices = JsonConvert.DeserializeObject<List<Models.Devices.Device>>(content);      
            //  _devices = new ObservableCollection<Models.Devices.Device>(devices);

            DevicesListView.ItemsSource = _devices;
            base.OnAppearing();
        }

       
        private async void OnAdd(object sender, EventArgs e)
        {
            Models.Devices.Device device = new Models.Devices.Device { NameDevice = $"{DateTime.UtcNow}" };
            string content = JsonConvert.SerializeObject(device);
            await _client.PostAsync(Url, new StringContent(content, Encoding.UTF8, "application/json")); 
            _devices.Insert(0, device);
        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            Models.Devices.Device device = _devices[0];
            device.NameDevice += " [updated]";
            string content = JsonConvert.SerializeObject(device);
            await _client.PutAsync(Url + "/" + device.IdDevice, new StringContent(content, Encoding.UTF8, "application/json"));
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            Models.Devices.Device device = _devices[0]; 
            await _client.DeleteAsync(Url + "/" + device.IdDevice); 
            _devices.Remove(device);
        }
    }
}