using KeepTrack.Core;
using System.Collections.Generic;

namespace KeepTrack.Data
{
    public class KTTask : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<KTActivityType> ActivityTypes { get; set; }
        public KTTimeline TaskTimeline { get; set; }
    }

}
