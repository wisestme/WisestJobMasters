using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WisestJobMasters.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string JobCity { get; set; }
        public string JobCategory { get; set; }
        public DateTime VacancyDeadline { get; set; }
        public bool VacancyStatus { get; set; }
    }
}