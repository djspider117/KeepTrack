using System;
using System.Collections.Generic;
using System.Text;

namespace KeepTrack.Data
{
    public class KTAppContext : IKTAppContext
    {
        public IList<KTIcon> Icons { get; set; }
        public IList<KTActivityType> Activities { get; set; }
        public IList<KTProject> Projects { get; set; }
        public IList<KTTask> Tasks { get; set; }
        public IList<KTTimeline> Timelines { get; set; }
        public IList<KTTimeEvent> TimeEvents { get; set; }
    }
}
