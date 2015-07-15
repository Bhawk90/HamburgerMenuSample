using HamburgerMenuSample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HamburgerMenuSample
{
    public sealed partial class MainPage : Page
    {
        // The user control where the content will be placed
        private UserControl TargetUserControl = null;

        // An invisible frame that we will use as a helper to load the content
        private Frame HiddenFrame = null;

        public MainPage()
        {
            this.InitializeComponent();

            TargetUserControl = targetUserControl;
            HiddenFrame = new Frame();
        }

        #region Application Logic

        public bool Navigate(Type target)
        {
            var navigation = HiddenFrame.Navigate(target);

            if (navigation)
            {
                TargetUserControl.Content = HiddenFrame.Content as UIElement;
            }

            return navigation;
        }

        #endregion

        #region Event Handlers

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            // Toggle visibility of the pane
            MainView.IsPaneOpen = !MainView.IsPaneOpen;
        }

        private void listHamburgerMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (HamburgerMenuItem)listHamburgerMenu.SelectedItem;

            if (item.TargetPage != null)
            {
                Navigate(item.TargetPage);
            }
        }

        #endregion
    }
}
