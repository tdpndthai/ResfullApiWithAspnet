using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResfullApiWithAspnet.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
    }
}