using System;

using BingToday.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingToday.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);


        }

        public void BeginThemeStoryBoards()
        {
            BackgroundColorAnimation.From =
                (NavigationMenu.PaneBackground as Windows.UI.Xaml.Media.SolidColorBrush).Color;

            BackgroundStoryboard.Stop();

            BackgroundStoryboard.Begin();
            
            ForegroundColorAnimation.From =
                (NavigationMenu.Foreground as Windows.UI.Xaml.Media.SolidColorBrush).Color;
            ForegroundStoryboard.Stop();
            ForegroundStoryboard.Begin();

            DisplayModeStoryboard.Begin();

        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
