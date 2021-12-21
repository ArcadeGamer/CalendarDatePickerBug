using System;
using System.ComponentModel;

namespace CalendarDatePickerBug
{
    [Windows.UI.Xaml.Data.Bindable]
    public partial class MainPageViewModel : INotifyPropertyChanged
    {
        private DateTimeOffset? _chosenDate;

        public DateTimeOffset? ChosenDate
        {
            get => _chosenDate;
            set
            {
                _chosenDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChosenDate"));
            }
        }

        public DateTimeOffset CurrentDate { get; } = DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
