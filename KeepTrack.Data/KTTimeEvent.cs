using KeepTrack.Core;
using System;

namespace KeepTrack.Data
{
    public class KTTimeEvent : IIdentifiable
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }
        public KTTimeEventType Type { get; set; }
    }
    public enum KTTimeEventType
    {
        Start,
        Pause,
        Resume,
        Stop,
        BreakStart,
        BreakEnd
    }
}
