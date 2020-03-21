using KeepTrack.Core;
using System.Collections.Generic;

namespace KeepTrack.Data
{
    public class KTProject : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public KTIcon Icon { get; set; }
        public IList<KTTask> Tasks { get; set; }
    }

}
