//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace concert.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int IDBooking { get; set; }
        public Nullable<int> B_OrderID { get; set; }
        public Nullable<int> IDShow { get; set; }
        public Nullable<int> IDCus { get; set; }
        public Nullable<int> NumCard { get; set; }
        public string DateBooking { get; set; }
        public Nullable<int> IDZone { get; set; }
        public Nullable<int> Total { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Show Show { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
