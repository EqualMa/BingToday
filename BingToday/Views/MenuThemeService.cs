using BingToday.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BingToday.Views
{
    public class MenuThemeService : DependencyObject
    {
        public static ShellViewModel CurrentShellViewModel => (Window.Current.Content as ShellPage).DataContext as ShellViewModel;
        #region Background

        public static Color DefaultBackgroundColor => Colors.OrangeRed;

        public static Color GetNewBackgroundColor(DependencyObject obj)
        {
            if (obj != null)
                return (Color)obj.GetValue(NewBackgroundColorProperty);
            else return DefaultBackgroundColor;
        }

        public static void SetNewBackgroundColor(DependencyObject obj, Color value)
        {
            if (obj != null)
                obj.SetValue(NewBackgroundColorProperty, value);
        }

        // Using a DependencyProperty as the backing store for NewBackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewBackgroundColorProperty =
            DependencyProperty.RegisterAttached("NewBackgroundColor", typeof(Color), typeof(MenuThemeService), new PropertyMetadata(DefaultBackgroundColor, NewBackgroundColorChanged));

        private static void NewBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is Color c && c != null)
                CurrentShellViewModel.NewBackgroundColor = c;

        }

        #endregion


        #region Foreground
        public static Color DefaultForegroundColor => Colors.White;

        public static Color GetNewForegroundColor(DependencyObject obj)
        {
            if (obj != null)
                return (Color)obj.GetValue(NewForegroundColorProperty);
            else return DefaultForegroundColor;
        }

        public static void SetNewForegroundColor(DependencyObject obj, Color value)
        {
            if (obj != null)
                obj.SetValue(NewForegroundColorProperty, value);
        }

        // Using a DependencyProperty as the backing store for NewBackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewForegroundColorProperty =
            DependencyProperty.RegisterAttached("NewForegroundColor", typeof(Color), typeof(MenuThemeService), new PropertyMetadata(DefaultForegroundColor, NewForegroundColorChanged));

        private static void NewForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is Color c && c != null)
                CurrentShellViewModel.NewForegroundColor = c;

        }

        #endregion

        #region DisplayMode

        public const SplitViewDisplayMode DefaultSplitViewDisplayMode = SplitViewDisplayMode.CompactInline;

        public static SplitViewDisplayMode GetNewSplitViewDisplayMode(DependencyObject obj)
        {
                return (SplitViewDisplayMode)obj.GetValue(NewSplitViewDisplayModeProperty);
        }

        public static void SetNewSplitViewDisplayMode(DependencyObject obj, SplitViewDisplayMode value)
        {
                obj.SetValue(NewSplitViewDisplayModeProperty, value);
        }

        // Using a DependencyProperty as the backing store for NewBackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewSplitViewDisplayModeProperty =
            DependencyProperty.RegisterAttached("NewSplitViewDisplayMode", typeof(SplitViewDisplayMode), typeof(MenuThemeService), new PropertyMetadata(DefaultSplitViewDisplayMode, NewSplitViewDisplayModeChanged));

        private static void NewSplitViewDisplayModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SplitViewDisplayMode m)
                CurrentShellViewModel.NewSplitViewDisplayMode = m;

        }

        #endregion
    }
}
