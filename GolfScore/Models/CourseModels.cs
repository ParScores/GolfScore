using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScore.Models
{
    public class CourseModels
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public Guid? AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string RegionalArea { get; set; }
        public string Postcode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string MainContact { get; set; }

    }
}