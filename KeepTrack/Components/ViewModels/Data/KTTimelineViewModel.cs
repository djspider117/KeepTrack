using System;
using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTTimelineViewModel : IdentifiableViewModel<KTTimeline>
    {

        public DateTime DateCreated
        {
            get { return Model.DateCreated; }
            set { Model.DateCreated = value; OnPropertyChanged(nameof(DateCreated)); }
        }

        public KTTimelineViewModel()
        : this(new KTTimeline())
        {

        }
        public KTTimelineViewModel(KTTimeline model)
            : base(model)
        {

        }
    }
}
