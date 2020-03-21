using GhostCore.MVVM;
using System;

namespace KeepTrack.Core
{

    public class IdentifiableViewModel<T> : ViewModelBase<T> where T : IIdentifiable
    {
        public int Id
        {
            get { return Model.Id; }
            set { Model.Id = value; OnPropertyChanged(nameof(Id)); }
        }


        public IdentifiableViewModel()
        : this(default)
        {

        }
        public IdentifiableViewModel(T model)
            : base(model)
        {

        }
    }
}
