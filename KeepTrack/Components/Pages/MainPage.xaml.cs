using KeepTrack.Components.Pages;
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

namespace KeepTrack
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void nvMainNav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs e)
        {
            Type targetType = null;

            if (e.IsSettingsSelected)
            {
                targetType = typeof(SettingsPage);
            }

            if (e.SelectedItem is NavigationViewItem nvi && targetType == null)
            {
                switch (nvi.Tag?.ToString())
                {
                    case "time_track":
                        targetType = typeof(TimeTrackingPage);
                        break;
                    case "projects":
                        targetType = typeof(ProjectsPage);
                        break;
                    default:
                        break;
                }

            }
            contentFrame.Navigate(targetType);
        }
    }
}
