using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WisestJobMasters.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int YearsOfExperience { get; set; }
    }
}