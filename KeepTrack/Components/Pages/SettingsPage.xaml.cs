using GhostCore;
using KeepTrack.Components.ViewModels.Data;
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

namespace KeepTrack.Components.Pages
{
    public sealed partial class SettingsPage : Page
    {
        public KTRuntimeAppContext Context { get; set; }

        public SettingsPage()
        {
            Context = ServiceLocator.Instance.Resolve<KTRuntimeAppContext>();
            InitializeComponent();
        }
    }
}
