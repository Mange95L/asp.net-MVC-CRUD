//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEvent
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
        public int userId { get; set; }
        public int categoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
