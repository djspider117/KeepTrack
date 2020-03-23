using GhostCore;
using KeepTrack.Components.ViewModels.Data;
using KeepTrack.Data;
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

namespace KeepTrack.Components.Controls
{
    public sealed partial class ActivitySettingsControl : UserControl
    {
        public KTRuntimeAppContext AppContext { get; }

        public ActivitySettingsControl()
        {
            AppContext = ServiceLocator.Instance.Resolve<KTRuntimeAppContext>();
            DataContext = AppContext;

            InitializeComponent();
        }

    }
}
