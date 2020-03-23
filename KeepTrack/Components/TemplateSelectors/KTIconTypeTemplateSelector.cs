using KeepTrack.Components.ViewModels.Data;
using KeepTrack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KeepTrack.Components.TemplateSelectors
{
    public class KTIconTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultFontIconTemplate { get; set; }
        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate CustomFontIconTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is KTIconViewModel vm)
            {
                var type = vm.Type;

                switch (type)
                {
                    case KTIconType.MDLFontIcon:
                        return DefaultFontIconTemplate;
                    case KTIconType.CustomFontIcon:
                        return CustomFontIconTemplate;
                    case KTIconType.Image:
                        return ImageTemplate;
                    default:
                        break;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
