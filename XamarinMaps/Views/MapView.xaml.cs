using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinMaps.ViewModels;

namespace XamarinMaps.Views
{
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();

            BindingContext = new MapViewModel();
        }
    }
}
