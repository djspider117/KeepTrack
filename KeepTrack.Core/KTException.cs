using System;
using System.Collections.Generic;
using System.Text;

namespace KeepTrack.Core
{

    [Serializable]
    public class KTException : Exception
    {
        public KTException() { }
        public KTException(string message) : base(message) { }
        public KTException(string message, Exception inner) : base(message, inner) { }
        protected KTException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
