using System;

using BingToday.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingToday.Views
{
    public sealed partial class HomePage : Page
    {
        public HomePageViewModel ViewModel { get; } = new HomePageViewModel();

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
