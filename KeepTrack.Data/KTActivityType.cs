using KeepTrack.Core;

namespace KeepTrack.Data
{
    public class KTActivityType : IIdentifiable
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public KTIcon Icon { get; set; }
    }

}
