//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReserveTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<System.DateTime> DateIn { get; set; }
        public Nullable<System.TimeSpan> TimeIn { get; set; }
        public Nullable<System.TimeSpan> TimeOut { get; set; }
        public string CheckColor { get; set; }
    }
}
