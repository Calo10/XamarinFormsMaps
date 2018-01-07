using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using XamarinMaps.Models;

namespace XamarinMaps.ViewModels
{
    public class MapViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Location> _lstLocations { get; set; }

        public ObservableCollection<Location> lstLocations
        {
            get
            {
                return _lstLocations;
            }
            set
            {
                _lstLocations = value;
                OnPropertyChanged("lstLocations");
            }
        }

        public MapViewModel()
        {

            Location locationA = new Location { Latitude = 9.8580959, Longitude = -83.9355353};
            Location locationB = new Location { Latitude = 9.863189, Longitude = -83.917933};

            lstLocations = new ObservableCollection<Location>();

            lstLocations.Add(locationA);
            lstLocations.Add(locationB);
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
