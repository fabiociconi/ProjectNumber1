using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectNumber1.Models.Device;

namespace ProjectNumber1.Views.Device
{
	public partial class ListDevicePage : ContentPage
	{
		public ListDevicePage ()
		{
			InitializeComponent ();
            DevicesListView.BindingContext = DeviceSource.GetAllDevices();
        }
	}
}