using System;

using Xamarin.Forms;

namespace XamarinMaps
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MapView());
        }
    }
}
