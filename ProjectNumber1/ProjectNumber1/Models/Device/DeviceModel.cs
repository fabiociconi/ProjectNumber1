using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectNumber1.Models.Device
{
    public class DeviceModel
    {
        public int IdDevice { get; set; }
        public string NameDevice { get; set; }
        public string TypeOfDevice { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
    }
}
