using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEvent
{
    public class BasicParticipant
    {
        public int id { get; set; }
        public System.DateTime registered { get; set; }
        public string username { get; set; }
        public string eventName { get; set; }
    }
}