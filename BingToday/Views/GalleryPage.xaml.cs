using System;

using BingToday.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingToday.Views
{
    public sealed partial class GalleryPage : Page
    {
        public GalleryPageViewModel ViewModel { get; } = new GalleryPageViewModel();

        public GalleryPage()
        {
            InitializeComponent();
        }
    }
}
