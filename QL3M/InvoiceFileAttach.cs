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
    
    public partial class InvoiceFileAttach
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public byte[] FileContent { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
