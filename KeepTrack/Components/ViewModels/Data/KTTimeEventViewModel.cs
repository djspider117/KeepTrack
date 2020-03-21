using System;
using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTTimeEventViewModel : IdentifiableViewModel<KTTimeEvent>
    {
        public DateTime Time
        {
            get { return Model.Time; }
            set { Model.Time = value; OnPropertyChanged(nameof(Time)); }
        }

        public string Comment
        {
            get { return Model.Comment; }
            set { Model.Comment = value; OnPropertyChanged(nameof(Comment)); }
        }

        public KTTimeEventType Type
        {
            get { return Model.Type; }
            set { Model.Type = value; OnPropertyChanged(nameof(Type)); }
        }

        public KTTimeEventViewModel()
        : this(new KTTimeEvent())
        {

        }
        public KTTimeEventViewModel(KTTimeEvent model)
            : base(model)
        {

        }
    }
}
