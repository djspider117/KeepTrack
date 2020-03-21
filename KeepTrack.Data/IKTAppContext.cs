using System.Collections.Generic;

namespace KeepTrack.Data
{
    public interface IKTAppContext
    {
        IList<KTIcon> Icons { get; set; }
        IList<KTActivityType> Activities { get; set; }
        IList<KTProject> Projects { get; set; }
        IList<KTTask> Tasks { get; set; }
        IList<KTTimeline> Timelines { get; set; }
        IList<KTTimeEvent> TimeEvents { get; set; }
    }
}
