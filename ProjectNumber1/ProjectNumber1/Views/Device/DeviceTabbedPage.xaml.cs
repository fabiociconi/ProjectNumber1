﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectNumber1.Views.Device
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceTabbedPage : TabbedPage
    {
        public DeviceTabbedPage ()
        {
            InitializeComponent();
        }
    }
}