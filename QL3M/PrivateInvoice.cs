//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL3M
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrivateInvoice
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<double> AmountMoney { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual User User { get; set; }
    }
}
