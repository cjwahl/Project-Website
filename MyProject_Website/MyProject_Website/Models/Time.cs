using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject_Website.Models
{
    public class Time
    {
        public long unixTimestamp { get; set; }

        public DateTime currentTime { get; set; }

        public static long UnixTime()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }
    }
}