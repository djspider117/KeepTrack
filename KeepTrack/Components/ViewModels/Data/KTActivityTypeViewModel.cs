using KeepTrack.Core;
using KeepTrack.Data;

namespace KeepTrack.Components.ViewModels.Data
{
    public class KTActivityTypeViewModel : IdentifiableViewModel<KTActivityType>
    {
        private KTIconViewModel _iconvm;

        public string ActivityName
        {
            get { return Model.ActivityName; }
            set { Model.ActivityName = value; OnPropertyChanged(nameof(ActivityName)); }
        }

        public KTIconViewModel Icon
        {
            get { return _iconvm; }
            set { _iconvm = value; OnPropertyChanged(nameof(Icon)); }
        }

        public KTActivityTypeViewModel()
            : this(new KTActivityType())
        {

        }

        public KTActivityTypeViewModel(KTActivityType model)
            : base(model)
        {
            if (model.Icon != null)
            {
                _iconvm = new KTIconViewModel(model.Icon);
            }
        }
    }
}
