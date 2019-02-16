using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace AnimationsInBladeView
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            ImplicitAnimationsBladeView.Visibility = Visibility.Visible;
            ImplicitAnimationsBladeItem.IsOpen     = true;
        }
    }
}
