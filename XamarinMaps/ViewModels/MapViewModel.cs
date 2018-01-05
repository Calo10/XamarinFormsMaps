using System;
using System.ComponentModel;

namespace XamarinMaps.ViewModels
{
    public class MapViewModel : INotifyPropertyChanged
    {
        public MapViewModel()
        {
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
