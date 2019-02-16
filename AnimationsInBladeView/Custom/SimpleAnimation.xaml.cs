using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace AnimationsInBladeView.Custom
{
    public sealed partial class SimpleAnimation : UserControl
    {
        public SimpleAnimation()
        {
            this.InitializeComponent();
        }

        private void AnimateButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            AnimateButton.Visibility = Visibility.Collapsed;
            ElementStack.Visibility  = Visibility.Visible;
        }

        private void CancelButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            AnimateButton.Visibility = Visibility.Visible;
            ElementStack.Visibility  = Visibility.Collapsed;
        }
    }
}
