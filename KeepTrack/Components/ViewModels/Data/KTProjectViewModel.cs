using System.Collections.Generic;
using GhostCore.Collections;
using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTProjectViewModel : IdentifiableViewModel<KTProject>
    {
        private KTIconViewModel _iconvm;
        private ViewModelCollection<KTTaskViewModel, KTTask> _tasks;

        public string Name
        {
            get { return Model.Name; }
            set { Model.Name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Description
        {
            get { return Model.Description; }
            set { Model.Description = value; OnPropertyChanged(nameof(Description)); }
        }

        public KTIconViewModel Icon
        {
            get { return _iconvm; }
            set { _iconvm = value; OnPropertyChanged(nameof(Icon)); }
        }

        public ViewModelCollection<KTTaskViewModel, KTTask> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; OnPropertyChanged(nameof(Tasks)); }
        }


        public KTProjectViewModel()
            : this(new KTProject())
        {

        }
        public KTProjectViewModel(KTProject model)
            : base(model)
        {
            if (model.Tasks != null)
            {
                var lst = new List<KTTaskViewModel>();
                foreach (var item in model.Tasks)
                {
                    lst.Add(new KTTaskViewModel(item));
                }

                _tasks = new ViewModelCollection<KTTaskViewModel, KTTask>(model.Tasks, lst);
            }
        }
    }
}
