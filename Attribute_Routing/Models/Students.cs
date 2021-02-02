using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attribute_Routing.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Address Address { get; set; }
    }
}