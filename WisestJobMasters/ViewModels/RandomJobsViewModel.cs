using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WisestJobMasters.Models;

namespace WisestJobMasters.ViewModels
{
    public class RandomJobsViewModel
    {
        public Job Job { get; set; }
        public List<Applicant> Applicants { get; set; }
    }
}