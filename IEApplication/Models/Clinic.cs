//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clinic
    {
        public int Id { get; set; }
        public string clinicName { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string contact { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public Nullable<int> Postcode { get; set; }
        public string Website { get; set; }
    }
}
