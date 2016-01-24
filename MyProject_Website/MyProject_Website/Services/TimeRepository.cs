using MyProject_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject_Website.Services
{
    public class TimeRepository
    {
        public Time[] GetTime()
        {
            return new Time[]
        {
             new Time
             {
                  unixTimestamp = Time.UnixTime(),
                  currentTime = DateTime.Now
             }
        };
        }
    }
}