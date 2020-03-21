using KeepTrack.Components.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace KeepTrack.Components.Pages
{
    public sealed partial class LoadingPage : Page
    {
        public LoadingPage()
        {
            InitializeComponent();
            Loaded += LoadingPage_Loaded;
        }

        private async void LoadingPage_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= LoadingPage_Loaded;
            await AppLoader.Instance.InitializeAsync();
            await Task.Delay(1750);

            Frame.Navigate(typeof(MainPage));
        }
    }
}
