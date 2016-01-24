using MyProject_Website.Models;
using MyProject_Website.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject_Website.Controllers
{
    public class InformationController : ApiController
    {
        private TimeRepository timeRepository;

        public InformationController()
        {
            this.timeRepository = new TimeRepository();
        }

        public Time[] Get()
        {
            return timeRepository.GetTime();
        }
    }
}