using KeepTrack.Core;
using System;
using System.Collections.Generic;

namespace KeepTrack.Data
{
    public class KTTimeline : List<KTTimeEvent>, IIdentifiable
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }

}
