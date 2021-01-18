using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WisestJobMasters.Models;

namespace WisestJobMasters.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Random()
        {
            var job = new Job() { JobTitle = "C# Programmer", JobCategory = "Computer Software" };
            return View(job);
        }
    }
}