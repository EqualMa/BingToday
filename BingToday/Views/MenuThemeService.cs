using BingToday.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace BingToday.Views
{
    public class MenuThemeService : DependencyObject
    {
        public static ShellViewModel CurrentShellViewModel => (Window.Current.Content as ShellPage).DataContext as ShellViewModel;

        public static Color GetNewBackgroundColor(DependencyObject obj)
        {
            return (Color)obj.GetValue(NewBackgroundColorProperty);
        }

        public static void SetNewBackgroundColor(DependencyObject obj, Color value)
        {
            obj.SetValue(NewBackgroundColorProperty, value);
        }

        // Using a DependencyProperty as the backing store for NewBackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewBackgroundColorProperty =
            DependencyProperty.RegisterAttached("NewBackgroundColor", typeof(Color), typeof(MenuThemeService), new PropertyMetadata(Windows.UI.Colors.White, NewBackgroundColorChanged));

        private static void NewBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var c = (Color)e.NewValue;
            CurrentShellViewModel.NewBackgroundColor = c;

        }
    }
}
