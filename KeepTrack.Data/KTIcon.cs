using KeepTrack.Core;
using System;

namespace KeepTrack.Data
{
    public class KTIcon : IIdentifiable
    {
        public int Id { get; set; }
        public KTIconType Type { get; set; }
        public string IconString { get; set; }
        public string CustomFontName { get; set; }
        public Uri CustomImagePath { get; set; }
    }

    public enum KTIconType
    {
        MDLFontIcon,
        CustomFontIcon,
        Image
    }
}
