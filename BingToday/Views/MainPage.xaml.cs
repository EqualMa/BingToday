using System;

using BingToday.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingToday.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
