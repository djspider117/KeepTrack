using System;
using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTIconViewModel : IdentifiableViewModel<KTIcon>
    {

        public KTIconType Type
        {
            get { return Model.Type; }
            set { Model.Type = value; OnPropertyChanged(nameof(Type)); }
        }


        public string IconString
        {
            get { return Model.IconString; }
            set { Model.IconString = value; OnPropertyChanged(nameof(IconString)); }
        }


        public string CustomFontName
        {
            get { return Model.CustomFontName; }
            set { Model.CustomFontName = value; OnPropertyChanged(nameof(CustomFontName)); }
        }

        public Uri CustomImagePath
        {
            get { return Model.CustomImagePath; }
            set { Model.CustomImagePath = value; OnPropertyChanged(nameof(CustomImagePath)); }
        }

        public KTIconViewModel()
        : this(new KTIcon())
        {

        }

        public KTIconViewModel(KTIcon model)
            : base(model)
        {

        }
    }
}
