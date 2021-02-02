using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conventional_Routing.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Address Address { get; set;  }
    }
}