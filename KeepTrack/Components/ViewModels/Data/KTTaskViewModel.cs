using System.Collections.Generic;
using GhostCore.Collections;
using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTTaskViewModel : IdentifiableViewModel<KTTask>
    {
        private KTTimelineViewModel _timeline;
        private ViewModelCollection<KTActivityTypeViewModel, KTActivityType> _activityTypes;

        public string Name
        {
            get { return Model.Name; }
            set { Model.Name = value; OnPropertyChanged(nameof(Name)); }
        }


        public KTTimelineViewModel Timeline
        {
            get { return _timeline; }
            set { _timeline = value; OnPropertyChanged(nameof(Timeline)); }
        }

        public ViewModelCollection<KTActivityTypeViewModel, KTActivityType> ActivityTypes
        {
            get { return _activityTypes; }
            set { _activityTypes = value; OnPropertyChanged(nameof(ActivityTypes)); }
        }


        public KTTaskViewModel()
            : this(new KTTask())
        {

        }
        public KTTaskViewModel(KTTask model)
            : base(model)
        {
            if (model.TaskTimeline != null)
            {
                _timeline = new KTTimelineViewModel(model.TaskTimeline);
            }

            if (model.ActivityTypes != null)
            {
                var lst = new List<KTActivityTypeViewModel>();
                foreach (var item in model.ActivityTypes)
                {
                    lst.Add(new KTActivityTypeViewModel(item));
                }
                _activityTypes = new ViewModelCollection<KTActivityTypeViewModel, KTActivityType>(Model.ActivityTypes, lst);
            }
        }
    }
}
