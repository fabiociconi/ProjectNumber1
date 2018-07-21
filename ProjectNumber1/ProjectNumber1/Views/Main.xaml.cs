using ProjectNumber1;
using System;
using Xamarin.Forms;

namespace ProjectNumber1.Views
{    
    public partial class Main : MasterDetailPage
    {
        public Main()
        {
            InitializeComponent();
            masterPage.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}