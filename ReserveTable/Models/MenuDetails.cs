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
    
    public partial class MenuDetails
    {
        public int MenuID { get; set; }
        public string Ingredients { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Qty { get; set; }
    
        public virtual Menu Menu { get; set; }
    }
}
