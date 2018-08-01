using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNumber1.Models.Device
{
    public class DeviceSource
    {
        private static List<Device> _device;
        static DeviceSource()
        {
            // stops for our Food and Fun park tour
            _device = new List<Device>();
            _device.Add(new Device
            {
                IdDevice = 1,
                NameDevice = "Device 1",
                Consumption = "500",
                CurrentTemp = "41",
                TypeOfDevice = "Type 1",
                MinTemp = 20,
                MaxTemp = 70

            });

            _device.Add(new Device
            {
                IdDevice = 2,
                NameDevice = "Device 2",
                Consumption = "350",
                CurrentTemp = "52",
                TypeOfDevice = "Type 2",
                MinTemp = 10,
                MaxTemp = 80

            });

            _device.Add(new Device
            {
                IdDevice = 3,
                NameDevice = "Device 3",
                Consumption = "180",
                CurrentTemp = "63",
                TypeOfDevice = "Type 3",
                MinTemp = 0,
                MaxTemp = 90

            });           
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

    public class Device
    {
        public int IdDevice { get; set; }
        public string NameDevice { get; set; }
        public string TypeOfDevice { get; set; }
        public string Consumption { get; set; }
        public string CurrentTemp { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
    }

}
