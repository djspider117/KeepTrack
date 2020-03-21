using GhostCore.Collections;
using GhostCore.MVVM;
using KeepTrack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTRuntimeAppContext : ViewModelBase<IKTAppContext>
    {
        private ViewModelCollection<KTIconViewModel, KTIcon> _icons;
        private ViewModelCollection<KTActivityTypeViewModel, KTActivityType> _activities;
        private ViewModelCollection<KTProjectViewModel, KTProject> _projects;
        private ViewModelCollection<KTTimelineViewModel, KTTimeline> _timelines;
        private ViewModelCollection<KTTimeEventViewModel, KTTimeEvent> _timeEvents;
        private ViewModelCollection<KTTaskViewModel, KTTask> _tasks;

        public ViewModelCollection<KTIconViewModel, KTIcon> Icons
        {
            get { return _icons; }
            set { _icons = value; OnPropertyChanged(nameof(Icons)); }
        }
        public ViewModelCollection<KTActivityTypeViewModel, KTActivityType> Activities
        {
            get { return _activities; }
            set { _activities = value; OnPropertyChanged(nameof(Activities)); }
        }
        public ViewModelCollection<KTProjectViewModel, KTProject> Projects
        {
            get { return _projects; }
            set { _projects = value; OnPropertyChanged(nameof(Projects)); }
        }
        public ViewModelCollection<KTTaskViewModel, KTTask> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; OnPropertyChanged(nameof(Tasks)); }
        }
        public ViewModelCollection<KTTimelineViewModel, KTTimeline> Timelines
        {
            get { return _timelines; }
            set { _timelines = value; OnPropertyChanged(nameof(Timelines)); }
        }
        public ViewModelCollection<KTTimeEventViewModel, KTTimeEvent> TimeEvents
        {
            get { return _timeEvents; }
            set { _timeEvents = value; OnPropertyChanged(nameof(TimeEvents)); }
        }

        public KTRuntimeAppContext(IKTAppContext model)
            : base(model)
        {
            InitializeCollection(model.Icons, ref _icons);
            InitializeCollection(model.Activities, ref _activities);
            InitializeCollection(model.Projects, ref _projects);
            InitializeCollection(model.Tasks, ref _tasks);
            InitializeCollection(model.Timelines, ref _timelines);
            InitializeCollection(model.TimeEvents, ref _timeEvents);
        }

        private void InitializeCollection<TViewModel, TModel>(IList<TModel> src, ref ViewModelCollection<TViewModel, TModel> target) where TViewModel : ViewModelBase<TModel>
        {
            if (src == null)
            {
                target = new ViewModelCollection<TViewModel, TModel>();
                return;
            }

            var lst = new List<TViewModel>();
            var type = typeof(TViewModel);
            var ctor = type.GetConstructor(new Type[] { typeof(TModel) });

            foreach (var item in src)
            {
                var obj = ctor.Invoke(new object[] { item });
                lst.Add(obj as TViewModel);
            }
            target = new ViewModelCollection<TViewModel, TModel>(src, lst);
        }
    }
}
