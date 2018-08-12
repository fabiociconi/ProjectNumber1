using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ProjectNumber1.Models.Devices
{
    public class DeviceModel
    {
        private static List<Device> _device;
        static DeviceModel()
        {           
            _device = new List<Device>(); 
        }

        public static Device First()
        {
            var result = _device.ToList<Device>();
            return result.First();
        }
        public static List<Device> GetAllDevices()
        {
            var result = _device.ToList<Device>();
            return result;
        }
        public static List<Device> GetDevices(int count)
        {
            var result = _device.Take(count).ToList<Device>();
            return result;
        }
        public static List<Device> Devices
        {
            get
            {
                return _device;
            }
        }

    }

    public class Device : INotifyPropertyChanged
    {
        public int IdDevice { get; set; }

        private string _name;
        [JsonProperty("updatedAt")]
        public string NameDevice
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }

        }        

        public string TypeOfDevice { get; set; }
        public string Consumption { get; set; }


        private int _temperature;
        [JsonProperty("temperature")]
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                OnPropertyChanged();
            }

        }



        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
