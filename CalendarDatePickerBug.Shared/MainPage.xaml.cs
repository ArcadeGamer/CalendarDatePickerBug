using Windows.UI.Xaml.Controls;

namespace CalendarDatePickerBug
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }
}
