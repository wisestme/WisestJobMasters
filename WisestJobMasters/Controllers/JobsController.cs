using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WisestJobMasters.Models;
using WisestJobMasters.ViewModels;

namespace WisestJobMasters.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Random()
        {
            var job = new Job() { JobTitle = "C# Programmer", JobCategory = "Computer Software" };
            var applicants = new List<Applicant>
            {
                new Applicant {FirstName = "Chijioke"},
                new Applicant {FirstName = "Emeka"},
                new Applicant {FirstName = "Chidiebube"}
            };

            var viewModel = new RandomJobsViewModel
            {
                Job = job,
                Applicants = applicants
            };
            return View(viewModel);
        }
    }
}