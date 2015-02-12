using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coal.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Modified { get; set; }
        public DateTime ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}