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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace KeepTrack.Components.Views
{
    public sealed partial class KTIconView : UserControl
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(KTIconViewModel), typeof(KTIconView), new PropertyMetadata(KTIconViewModel.Default));

        public static readonly DependencyProperty ContentTransitionProperty =
            DependencyProperty.Register("ContentTransition", typeof(TransitionCollection), typeof(KTIconView), new PropertyMetadata(new TransitionCollection()));

        public TransitionCollection ContentTransition
        {
            get { return (TransitionCollection)GetValue(ContentTransitionProperty); }
            set { SetValue(ContentTransitionProperty, value); }
        }

        public KTIconViewModel ViewModel
        {
            get { return (KTIconViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public KTIconView()
        {
            InitializeComponent();
        }
    }
}
