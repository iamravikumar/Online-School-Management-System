//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineSchool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GUARDIANREVIEW
    {
        public int Review_ID { get; set; }
        public string ReviewDescription { get; set; }
        public int Guardian_ID { get; set; }
    
        public virtual GUARDIAN GUARDIAN { get; set; }
    }
}
