using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace FFImageTest.Client.Lib.Controls.ListView
{
    public class BaseDetailsRowViewCell : ViewCell
    {
        double _LabelWidth;
        public double LabelWidth 
        {
            get => _LabelWidth;
            set
            {
                _LabelWidth = value;
                OnPropertyChanged();
            }
        }

        double _ValueWidth;
        public double ValueWidth
        {
            get => _ValueWidth;
            set
            {
                _ValueWidth = value;
                OnPropertyChanged();
            }
        }

        public BaseDetailsRowViewCell()
        {
            LoadValues();
        }

        void LoadValues()
        {
            //LabelWidth = (DetailsListView.DetailsWidth - DetailsListView.DetailsMargin) * 0.4;
            //ValueWidth = (DetailsListView.DetailsWidth - DetailsListView.DetailsMargin) * 0.6;

            LabelWidth = DeviceDisplay.MainDisplayInfo.Width * 0.4;
            ValueWidth = DeviceDisplay.MainDisplayInfo.Width * 0.6;
        }

        protected virtual void OnWidthChanged()
        {
            LoadValues();
        }

        void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs args)
        {
            OnWidthChanged();
        }

        protected override void OnAppearing()
        {
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
            base.OnAppearing();
            OnWidthChanged();
        }

        protected override void OnDisappearing()
        {
            DeviceDisplay.MainDisplayInfoChanged -= OnMainDisplayInfoChanged;
            base.OnDisappearing();
        }
    }
}
