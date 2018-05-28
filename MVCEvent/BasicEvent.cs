using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEvent
{
    public class BasicEvent
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
        public string creator { get; set; }
        public string category { get; set; }
    }
}